using System.Security.Cryptography;
using System.Text;

public class FileEncryptor
{
    private const int KeySize = 256;
    private const int BlockSize = 128;
    private const int Iterations = 10000;

    public async Task EncryptFileAsync(string password, string inputFilePath, string outputFilePath, IProgress<double> progress)
    {
        byte[] salt = GenerateSalt();
        var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations, HashAlgorithmName.SHA512);
        byte[] key = pbkdf2.GetBytes(KeySize / 8);
        byte[] iv = GenerateIV();

        FileInfo fileInfo = new FileInfo(inputFilePath);
        string metadata = $"{fileInfo.Name}";

        try
        {
            using (FileStream inputFileStream = new FileStream(inputFilePath, FileMode.Open, FileAccess.Read))
            using (FileStream outputFileStream = new FileStream(outputFilePath, FileMode.Create, FileAccess.Write))
            {
                // Write metadata length and metadata to the output file
                byte[] metadataBytes = Encoding.UTF8.GetBytes(metadata);
                byte[] metadataLength = BitConverter.GetBytes(metadataBytes.Length);
                await outputFileStream.WriteAsync(metadataLength, 0, metadataLength.Length);
                await outputFileStream.WriteAsync(metadataBytes, 0, metadataBytes.Length);

                // Write salt and IV to the output file
                await outputFileStream.WriteAsync(salt, 0, salt.Length);
                await outputFileStream.WriteAsync(iv, 0, iv.Length);

                using (Aes aes = Aes.Create())
                {
                    aes.Key = key;
                    aes.IV = iv;
                    aes.Padding = PaddingMode.PKCS7;

                    using (CryptoStream cryptoStream = new CryptoStream(outputFileStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        byte[] buffer = new byte[1048576]; // 1MB buffer
                        int bytesRead;
                        double totalBytesRead = 0;
                        double totalBytes = inputFileStream.Length;

                        while ((bytesRead = await inputFileStream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                        {
                            await cryptoStream.WriteAsync(buffer, 0, bytesRead);
                            totalBytesRead += bytesRead;
                            progress?.Report(totalBytesRead / totalBytes);
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Encryption failed: " + ex.Message);
            throw;
        }
    }

    public async Task<(bool, string)> DecryptFileAsync(string password, string inputFilePath, string outputFilePath, IProgress<double> progress)
    {
        try
        {
            using (FileStream inputFileStream = new FileStream(inputFilePath, FileMode.Open, FileAccess.Read))
            {
                // Read metadata length from the input file
                byte[] metadataLengthBytes = new byte[4];
                await inputFileStream.ReadAsync(metadataLengthBytes, 0, metadataLengthBytes.Length);
                int metadataLength = BitConverter.ToInt32(metadataLengthBytes, 0);

                // Read metadata from the input file
                byte[] metadataBytes = new byte[metadataLength];
                await inputFileStream.ReadAsync(metadataBytes, 0, metadataBytes.Length);
                string metadata = Encoding.UTF8.GetString(metadataBytes);
                string originalFileName = metadata.Split(';')[0];

                // Read salt and IV from the input file
                byte[] salt = new byte[16]; // The salt is 16 bytes
                await inputFileStream.ReadAsync(salt, 0, salt.Length);
                byte[] iv = new byte[BlockSize / 8]; // The IV is 16 bytes
                await inputFileStream.ReadAsync(iv, 0, iv.Length);

                var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations, HashAlgorithmName.SHA512); // Usando SHA-512
                byte[] key = pbkdf2.GetBytes(KeySize / 8);

                using (FileStream outputFileStream = new FileStream(outputFilePath, FileMode.Create, FileAccess.Write))
                using (Aes aes = Aes.Create())
                {
                    aes.Key = key;
                    aes.IV = iv;
                    aes.Padding = PaddingMode.PKCS7;

                    using (CryptoStream cryptoStream = new CryptoStream(inputFileStream, aes.CreateDecryptor(), CryptoStreamMode.Read))
                    {
                        byte[] buffer = new byte[1048576]; // 1MB buffer
                        int bytesRead;
                        double totalBytesRead = 0;
                        double totalBytes = inputFileStream.Length - metadataLengthBytes.Length - metadataBytes.Length - salt.Length - iv.Length;

                        while ((bytesRead = await cryptoStream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                        {
                            await outputFileStream.WriteAsync(buffer, 0, bytesRead);
                            totalBytesRead += bytesRead;
                            progress?.Report(totalBytesRead / totalBytes);
                        }
                    }
                }
                return (true, originalFileName);
            }
        }
        catch (CryptographicException)
        {
            Console.WriteLine("Decryption failed: incorrect password or data corruption");
            return (false, null);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Decryption failed: " + ex.Message);
            return (false, null);
        }
    }

    private byte[] GenerateSalt()
    {
        byte[] salt = new byte[16]; // Salt size
        using (var rng = RandomNumberGenerator.Create())
        {
            rng.GetBytes(salt);
        }
        return salt;
    }

    private byte[] GenerateIV()
    {
        byte[] iv = new byte[BlockSize / 8]; // IV size
        using (var rng = RandomNumberGenerator.Create())
        {
            rng.GetBytes(iv);
        }
        return iv;
    }
}

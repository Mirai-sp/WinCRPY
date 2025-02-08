using System.Security.Cryptography;

public class FileEncryptor
{
    private const int KeySize = 256;
    private const int BlockSize = 128;
    private const int Iterations = 10000;

    public async Task EncryptFileAsync(string password, string inputFilePath, string outputFilePath, IProgress<double> progress)
    {
        byte[] salt = GenerateSalt();
        var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations, HashAlgorithmName.SHA256);
        byte[] key = pbkdf2.GetBytes(KeySize / 8);
        byte[] iv = new byte[BlockSize / 8];

        using (FileStream inputFileStream = new FileStream(inputFilePath, FileMode.Open))
        using (FileStream outputFileStream = new FileStream(outputFilePath, FileMode.Create))
        using (Aes aes = Aes.Create())
        {
            aes.Key = key;
            aes.IV = iv;

            // Write salt at the beginning of the output file
            await outputFileStream.WriteAsync(salt, 0, salt.Length);

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
                    progress.Report(totalBytesRead / totalBytes);
                }
            }
        }
    }

    public async Task DecryptFileAsync(string password, string inputFilePath, string outputFilePath, IProgress<double> progress)
    {
        using (FileStream inputFileStream = new FileStream(inputFilePath, FileMode.Open))
        {
            byte[] salt = new byte[16]; // The salt is 16 bytes
            await inputFileStream.ReadAsync(salt, 0, salt.Length);

            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations, HashAlgorithmName.SHA256);
            byte[] key = pbkdf2.GetBytes(KeySize / 8);
            byte[] iv = new byte[BlockSize / 8];

            using (FileStream outputFileStream = new FileStream(outputFilePath, FileMode.Create))
            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;

                using (CryptoStream cryptoStream = new CryptoStream(inputFileStream, aes.CreateDecryptor(), CryptoStreamMode.Read))
                {
                    byte[] buffer = new byte[1048576]; // 1MB buffer
                    int bytesRead;
                    double totalBytesRead = salt.Length;
                    double totalBytes = inputFileStream.Length;

                    while ((bytesRead = await cryptoStream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                    {
                        await outputFileStream.WriteAsync(buffer, 0, bytesRead);
                        totalBytesRead += bytesRead;
                        progress.Report(totalBytesRead / totalBytes);
                    }
                }
            }
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
}

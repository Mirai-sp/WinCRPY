using System.Security.Cryptography;
using System.Text;

public class TextEncryptor
{
    private const int KeySize = 256;
    private const int BlockSize = 128;
    private const int Iterations = 10000;

    public string EncryptText(string password, string plaintext)
    {
        byte[] salt = GenerateSalt();
        var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations, HashAlgorithmName.SHA256);
        byte[] key = pbkdf2.GetBytes(KeySize / 8);
        byte[] iv = new byte[BlockSize / 8];

        using (Aes aes = Aes.Create())
        {
            aes.Key = key;
            aes.IV = iv;
            aes.Padding = PaddingMode.PKCS7;

            using (MemoryStream ms = new MemoryStream())
            {
                // Write salt to the memory stream
                ms.Write(salt, 0, salt.Length);

                using (CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    using (StreamWriter sw = new StreamWriter(cs, Encoding.UTF8))
                    {
                        sw.Write(plaintext);
                    }
                }

                return Convert.ToBase64String(ms.ToArray());
            }
        }
    }

    public string DecryptText(string password, string encryptedText)
    {
        byte[] encryptedBytes = Convert.FromBase64String(encryptedText);

        using (MemoryStream ms = new MemoryStream(encryptedBytes))
        {
            // Read salt from the memory stream
            byte[] salt = new byte[16];
            ms.Read(salt, 0, salt.Length);

            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations, HashAlgorithmName.SHA256);
            byte[] key = pbkdf2.GetBytes(KeySize / 8);
            byte[] iv = new byte[BlockSize / 8];

            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;
                aes.Padding = PaddingMode.PKCS7;

                using (CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Read))
                {
                    using (StreamReader sr = new StreamReader(cs, Encoding.UTF8))
                    {
                        return sr.ReadToEnd();
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

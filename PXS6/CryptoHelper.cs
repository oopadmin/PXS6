using System;
using System.Text;
using System.Security.Cryptography;

namespace PXS6
{
    public class CryptoHelper
    {
        public static string ToSHA256(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(input);
                byte[] hash = sha256.ComputeHash(bytes);

                StringBuilder sb = new StringBuilder();
                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("x2"));
                }

                return sb.ToString();
            }
        }

        public static string ToBase32(string input)
        {
            const string Base32Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ234567";

            byte[] bytes = Encoding.UTF8.GetBytes((string)input);
            StringBuilder sb = new StringBuilder();
            int bitBuffer = 0;
            int bitCount = 0;

            foreach (byte b in bytes)
            {
                bitBuffer = (bitBuffer << 8) | b;
                bitCount += 8;

                while (bitCount >= 5)
                {
                    int index = (bitBuffer >> (bitCount - 5)) & 0x1F;
                    sb.Append(Base32Alphabet[index]);
                    bitCount -= 5;
                }
            }

            if (bitCount > 0)
            {
                int index = (bitBuffer << (5 - bitCount)) & 0x1F;
                sb.Append(Base32Alphabet[index]);
            }

            while (sb.Length % 8 != 0)
            {
                sb.Append('=');
            }

            return sb.ToString();
        }

        public static string FromBase32(string input)
        {
            const string Base32Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ234567";

            // loại bỏ padding và viết hoa
            string cleanInput = input.TrimEnd('=').ToUpperInvariant();

            // Bảng tra ngược: ký tự -> giá trị
            Dictionary<char, int> lookup = new Dictionary<char, int>();
            for (int i = 0; i < Base32Alphabet.Length; i++)
            {
                lookup[Base32Alphabet[i]] = i;
            }

            int bitBuffer = 0;
            int bitCount = 0;
            List<byte> bytes = new List<byte>();

            foreach (char c in cleanInput)
            {
                bitBuffer = (bitBuffer << 5) | lookup[c];
                bitCount += 5;

                while (bitCount >= 8)
                {
                    int b = (bitBuffer >> (bitCount - 8)) & 0xFF;
                    bytes.Add((byte)b);
                    bitCount -= 8;
                }
            }

            return Encoding.UTF8.GetString(bytes.ToArray());
        }

        public static string XorStrings(string input, string key)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                char xorChar = (char)(input[i] ^ key[i % key.Length]);
                sb.Append(xorChar);
            }

            return sb.ToString();
        }

        public static string ShuffleStrings(string input, string chunk)
        {
            int seed = (int)(Convert.ToInt64(chunk, 16) % int.MaxValue);
            Random rng = new Random(seed);

            char[] chars = input.ToCharArray();
            for (int i = chars.Length - 1; i > 0; i--)
            {
                int j = rng.Next(i + 1);
                (chars[i], chars[j]) = (chars[j], chars[i]);
            }

            return new string(chars);
        }

        public static string UnShuffleStrings(string input, string chunk)
        {
            int seed = (int)(Convert.ToInt64(chunk, 16) % int.MaxValue);
            Random rng = new Random(seed);

            // giả lập lại shuffle
            int[] indices = new int[input.Length];
            for (int i = 0; i < input.Length; i++) { indices[i] = i; }
            for (int i = input.Length - 1; i > 0; i--)
            {
                int j = rng.Next(i + 1);
                (indices[i], indices[j]) = (indices[j], indices[i]);
            }

            // sắp xếp lại
            int[] inverse = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                inverse[indices[i]] = i;
            }
            char[] result = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                result[i] = input[inverse[i]];
            }

            return new string(result);
        }
    }
}

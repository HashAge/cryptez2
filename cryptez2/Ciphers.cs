using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cryptez2
{
    internal class Ciphers
    {
        public string cesaer_method(string plain, int shift)
        {
            plain.ToLower();
            char[] chr = plain.ToCharArray();
            for (int i = 0; i < chr.Length; i++)
            {
                if (chr[i] + shift > 122)
                {
                    int div = chr[i] + shift - 123;
                    chr[i] = Convert.ToChar(97 + div);
                }
                else chr[i] = Convert.ToChar(chr[i] + shift);
            }
            plain = new string(chr);
            return plain;
        }
        public string vigenere_method(string plain, string shift)
        {
            plain.Trim();
            char[] mes_char = plain.ToCharArray();
            char[] code_char = shift.ToCharArray();
            char[] code_map = new char[plain.Length];
            int[] int_code_map = new int[plain.Length];
            for (int x = 0, i = 0; x < plain.Length; x++)
            {
                if (i < shift.Length)
                {
                    code_map[x] = code_char[i];
                    i++;
                }
                else
                {
                    i = 0;
                    code_map[x] += code_char[i];
                    i++;
                }
                int_code_map[x] = Convert.ToInt32(code_map[x] - 97);
            }
            for (int i = 0; i < plain.Length; i++)
            {
                if (Convert.ToChar(mes_char[i] + int_code_map[i]) > 122)
                {
                    int div = mes_char[i] + int_code_map[i] - 123;
                    mes_char[i] = Convert.ToChar(97 + div);
                }
                else mes_char[i] = Convert.ToChar(mes_char[i] + int_code_map[i]);

            }
            plain = new string(mes_char);
            return plain;
        }
        public string base32_method(string plain)
        {
            byte[] mes_byte = Encoding.ASCII.GetBytes(plain);
            const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ234567";
            string output = "";
            for (int bitIndex = 0; bitIndex < mes_byte.Length * 8; bitIndex += 5)
            {
                int dualbyte = mes_byte[bitIndex / 8] << 8;
                if (bitIndex / 8 + 1 < mes_byte.Length)
                    dualbyte |= mes_byte[bitIndex / 8 + 1];
                dualbyte = 0x1f & (dualbyte >> (16 - bitIndex % 8 - 5));
                output += alphabet[dualbyte];
            }
            return output;
        }
     /*   public string atbash_method(string plain)
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] chr_arr = plain.ToCharArray();
            for (int i = 0; i < plain.Length; i++) chr_arr[i] = (char)(int)(alphabet[alphabet.Length] - chr_arr[i]);
            plain = new string(chr_arr);
            return plain;
        }*/
    }
}

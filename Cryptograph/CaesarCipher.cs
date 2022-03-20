using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptograph
{
    public static class CaesarCipher
    {
        public static string Encrypt(string Text, int Shift, string Alphabet)
        {
            var Result = new StringBuilder();
            foreach (var letter in Text)
            {
                if (letter == ' ')
                {
                    Result.Append(letter);
                    continue;
                }

                int j = -1;
                for (int i = 0; i < Alphabet.Length; i++)
                {
                    if (letter.ToString().ToUpper() == Alphabet[i].ToString())
                    {
                        j = i;
                        break;
                    }
                }

                if (j == -1)
                {
                    Result.Append(letter);
                    continue;
                }

                j += Shift;
                if (j >= Alphabet.Length)
                {
                    j -= Alphabet.Length;
                }

                if (letter.ToString() == letter.ToString().ToLower())
                {
                    Result.Append(Alphabet[j].ToString().ToLower());
                }
                else
                    Result.Append(Alphabet[j]);
            }

            return Result.ToString();
        }

        public static string Decrypt(string Text, int Shift, string Alphabet)
        {
            var Result = new StringBuilder();
            foreach (var letter in Text)
            {
                if (letter == ' ')
                {
                    Result.Append(letter);
                    continue;
                }

                int j = -1;
                for (int i = 0; i < Alphabet.Length; i++)
                {
                    if (letter.ToString().ToUpper() == Alphabet[i].ToString())
                    {
                        j = i;
                        break;
                    }
                }

                if (j == -1)
                {
                    Result.Append(letter);
                    continue;
                }

                j -= Shift;
                if (j >= Alphabet.Length)
                    j -= Alphabet.Length;

                if (j < 0)
                    j = Alphabet.Length + j;

                if (letter.ToString() == letter.ToString().ToLower())
                {
                    Result.Append(Alphabet[j].ToString().ToLower());
                }
                else
                    Result.Append(Alphabet[j]);
            }

            return Result.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptograph
{
    public class VigenereCipher
    {
        public static string Encrypt(string Text, string Key, string Alphabet)
        {
            List<int> TextValues = new List<int>();
            List<int> KeyValues = new List<int>();
            List<int> CipherValues = new List<int>();

            foreach (var Char in Text)
            {
                for (int i = 0; i < Alphabet.Length; i++)
                {
                    if (Char.ToString().ToUpper() == Alphabet[i].ToString())
                    {
                        TextValues.Add(i);
                    }
                }
            }

            StringBuilder sb = new StringBuilder();
            int j = 0;
            for (int i = 0; i < Text.Length; i++)
            {
                sb.Append(Key[j]);

                if (j < Key.Length - 1)
                    j++;
                else
                    j = 0;
            }
            Key = sb.ToString();
            sb.Clear();

            foreach (var Char in Key)
            {
                for (int i = 0; i < Alphabet.Length; i++)
                {
                    if (Char == Alphabet[i])
                    {
                        KeyValues.Add(i);
                    }
                }
            }

            for (int i = 0; i < TextValues.Count; i++)
            {
                CipherValues.Add((TextValues[i] + KeyValues[i]) % Alphabet.Length);
            }

            foreach (var Value in CipherValues)
            {
                for (int i = 0; i < Alphabet.Length; i++)
                {
                    if (Value == i)
                        sb.Append(Alphabet[i]);
                }
            }

            string Coded = sb.ToString();
            sb.Clear();

            j = 0;
            bool  isLetter = false;
            bool isUpper = false;
            for (int i = 0; i < Text.Length; i++)
            {
                foreach (var letter in Alphabet)
                {
                    if (letter.ToString() == Text[i].ToString().ToUpper())
                    {
                        isLetter = true;
                        if (Text[i].ToString() == Text[i].ToString().ToUpper())
                            isUpper = true;
                        break;
                    }

                }

                if (isLetter)
                {
                    if (isUpper)
                    {
                        sb.Append(Coded[j]);
                        j++;
                    }
                    else
                    {
                        sb.Append(Coded[j].ToString().ToLower());
                        j++;
                    }

                }
                else
                    sb.Append(Text[i]);

                isLetter = false;
                isUpper = false;
            }

            return sb.ToString();
        }

        public static string Decrypt(string Text, string Key, string Alphabet)
        {
            List<int> TextValues = new List<int>();
            List<int> KeyValues = new List<int>();
            List<int> CipherValues = new List<int>();

            foreach (var Char in Text)
            {
                for (int i = 0; i < Alphabet.Length; i++)
                {
                    if (Char.ToString().ToUpper() == Alphabet[i].ToString())
                    {
                        TextValues.Add(i);
                    }
                }
            }

            StringBuilder sb = new StringBuilder();
            int j = 0;
            for (int i = 0; i < Text.Length; i++)
            {
                sb.Append(Key[j]);

                if (j < Key.Length - 1)
                    j++;
                else
                    j = 0;
            }
            Key = sb.ToString();
            sb.Clear();

            foreach (var Char in Key)
            {
                for (int i = 0; i < Alphabet.Length; i++)
                {
                    if (Char == Alphabet[i])
                    {
                        KeyValues.Add(i);
                    }
                }
            }

            for (int i = 0; i < TextValues.Count; i++)
            {
                int k = TextValues[i] - KeyValues[i];
                if (k < 0)
                    k += Alphabet.Length;
                CipherValues.Add(k % Alphabet.Length);
            }

            foreach (var Value in CipherValues)
            {
                for (int i = 0; i < Alphabet.Length; i++)
                {
                    if (Value == i)
                        sb.Append(Alphabet[i]);
                }
            }

            string Coded = sb.ToString();
            sb.Clear();

            j = 0;
            bool isLetter = false;
            bool isUpper = false;
            for (int i = 0; i < Text.Length; i++)
            {
                foreach (var letter in Alphabet)
                {
                    if (letter.ToString() == Text[i].ToString().ToUpper())
                    {
                        isLetter = true;
                        if (Text[i].ToString() == Text[i].ToString().ToUpper())
                            isUpper = true;
                        break;
                    }

                }

                if (isLetter)
                {
                    if (isUpper)
                    {
                        sb.Append(Coded[j]);
                        j++;
                    }
                    else
                    {
                        sb.Append(Coded[j].ToString().ToLower());
                        j++;
                    }

                }
                else
                    sb.Append(Text[i]);

                isLetter = false;
                isUpper = false;
            }

            return sb.ToString();
        }
    }
}

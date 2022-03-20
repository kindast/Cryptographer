using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptograph
{
    public class Base64Coder
    {
        private const string EncryptAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/";

        public static void Encrypt(string Text)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in System.Text.Encoding.Unicode.GetBytes(Text))
                sb.Append(Convert.ToString(b, 2));

            sb.Append("00000000");
            string binaryStr = sb.ToString();
            
            sb.Clear();
            List<string> bytes = new List<string>();
            for (int i = 0; i <= binaryStr.Length; i++)
            {
                if (i % 6 == 0 && i != 0)
                {
                    bytes.Add(sb.ToString());
                    sb.Clear();

                    if (i != binaryStr.Length)
                        sb.Append(binaryStr[i]);
                }
                else if (i != binaryStr.Length)
                    sb.Append(binaryStr[i]);
            }

            foreach (string str in bytes)
            {
                int i = Convert.ToInt32(str, 2);
                sb.Append(EncryptAlphabet[i]);
            }

            string Result = sb.ToString();
            return;
        }
    }
}

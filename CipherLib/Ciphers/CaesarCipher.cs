using System.Text;

namespace CipherLib
{
    public static class CaesarCipher
    {
        /// <summary>
        /// Шифрует или дешифрует текст шифром Цезаря
        /// </summary>
        /// <param name="Text">Текст для шифрования или дешифрования.</param>
        /// <param name="Shift">Сдвиг.</param>
        /// <param name="Alphabet">Алфавит, на котором написан текст.</param>
        /// <param name="isDecrypt">Если true, то дешифрует. Если false, то шифрует.</param>
        /// <returns>Строка с зашифрованным или дешифрованным текстом.</returns>
        /// <exception cref="Exceptions.InputIsEmptyException">Текст для шифрования или дешифрования не содержит ни одного символа.</exception>
        public static string EnDecrypt(string Text, int Shift, string Alphabet, bool isDecrypt)
        {
            if (Text == string.Empty)
                throw new Exceptions.InputIsEmptyException();

            var Result = new StringBuilder();
            foreach (var letter in Text)
            {
                //Поиск буквы в алфавите
                int j = -1;
                for (int i = 0; i < Alphabet.Length; i++)
                {
                    if (letter.ToString().ToUpper() == Alphabet[i].ToString())
                    {
                        j = i;
                        break;
                    }
                }

                //Добавляем символ без изменений, если буква не нашлась
                if (j == -1)
                {
                    Result.Append(letter);
                    continue;
                }

                if (!isDecrypt)
                {
                    //Зашифровываем текст. Сдвигаем индекс вперед
                    j += Shift;
                    if (j >= Alphabet.Length)
                        j -= Alphabet.Length;
                }
                else
                {
                    //Дешифровываем текст. Сдвигаем индекс назад
                    j -= Shift;
                    if (j >= Alphabet.Length)
                        j -= Alphabet.Length;

                    if (j < 0)
                        j = Alphabet.Length + j;
                }
                
                //Добавляем прописную или строчную букву
                if (letter.ToString() == letter.ToString().ToLower())
                    Result.Append(Alphabet[j].ToString().ToLower());
                else
                    Result.Append(Alphabet[j]);
            }

            return Result.ToString();
        }
    }
}

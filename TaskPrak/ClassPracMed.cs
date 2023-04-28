using System;
using System.Text;
using System.Text.RegularExpressions;

namespace TaskPrak
{
    internal class ClassPracMed
    {
        public static void HandleError(Exception ex) // Метод отлова / оповещения об ошибке
        {
            Console.ForegroundColor = ConsoleColor.Red;

            // Оповещаем пользователя об ошибке
            Console.WriteLine($"An error occurred: {ex.Message}");
            Console.ResetColor();
            Console.ReadLine();
        }

        public static string FixRegistrText(string text) // Метод исправления текста (Регистр)
        {
            StringBuilder result = new StringBuilder(text.ToLower()); // Делаем все буквы маленькими
            bool startOfSentence = true;  // Флаг, указывающий на начало предложения

            for (int i = 0; i < result.Length; i++)
            {
                if (startOfSentence && Char.IsLetter(result[i]))
                {
                    result[i] = Char.ToUpper(result[i]);
                    startOfSentence = false;
                }
                else if (result[i] == '.' || result[i] == '!' || result[i] == '?')
                {
                    startOfSentence = true;
                }
            }

            return result.ToString();
        }

        public static string FixSyntaxText(string text)
        {
            // Разбиваем текст на предложения
            string[] sentences = text.Split(new char[] { '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);

            // Исправляем пробелы в каждом предложении и склеиваем предложения обратно в текст
            StringBuilder result = new StringBuilder();
            int endIndex = 0;
            foreach (string sentence in sentences)
            {
                string trimmedSentence = sentence.Trim();
                if (trimmedSentence.Length > 0)
                {
                    // Заменяем последовательности пробелов на один пробел
                    string processedSentence = Regex.Replace(trimmedSentence, @"\s+", " ");
                    result.Append(processedSentence);

                    // Добавляем знак припинания, если он был в исходном тексте
                    endIndex = text.IndexOf(sentence, endIndex) + sentence.Length;
                    if (endIndex < text.Length)
                    {
                        result.Append(text[endIndex]);
                        result.Append(' ');
                    }
                }
            }

            return result.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TaskPrak.ClassPracMed;

namespace TaskPrak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {   
                //var a = new int[] { 1, 2, 3 };
                //int b = a[4];
                // Код, который может вызвать ошибку
            }
            catch (Exception ex)
            {
                // Отлавливаем ошибку и обрабатываем ее
                HandleError(ex);
            }

            // -----------------------------------------------------------------------------------------------------------------------

            string text = "Это Текст    с НеКоРРектным регистрОм.   Он нуждается в исправлении ! Кто-то может помочь?";
            string fixedText = FixSyntaxText(FixRegistrText(text));
            Console.WriteLine(fixedText); // "Это Текст С Некорректным Регистром. Он Нуждается В Исправлении! Кто-То Может Помочь?"

            Console.ReadLine();
        }
    }
}

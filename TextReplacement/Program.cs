using System;
using System.Text;
namespace TextReplacement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть будь-який текст: ");
            string text = Console.ReadLine() ?? "";
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                int position = i + 1;
                if (position % 15 == 0)
                {
                    result.Append('?');
                }
                else if (position % 3 == 0)
                {
                    result.Append('X');
                }
                else if (position % 5 == 0)
                {
                    result.Append('9');
                }
                else
                {
                    result.Append(text[i]);
                }
            }
            Console.WriteLine("Результат: " + result);
        }
    }
}

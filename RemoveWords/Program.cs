namespace RemoveWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть текст: ");
            string text = Console.ReadLine() ?? "";
            Console.Write("Введіть кількість слів X: ");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x < 0)
            {
                Console.WriteLine("X не може бути від'ємним!");
                return;
            }
            string[] words = text.Split(
                new char[] { ' ', '\t', '\n', '\r', },
                StringSplitOptions.RemoveEmptyEntries
                );
            string result = "";
            for (int i = x; i < words.Length; i++)
            {
                if (result.Length > 0)
                {
                    result += " ";
                }
                result += words[i];
            }
            Console.WriteLine("Результат: " + result);
        }
    }
}

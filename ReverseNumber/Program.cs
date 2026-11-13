namespace ReverseNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть ціле число: ");
            long number = Convert.ToInt64(Console.ReadLine());
            bool isNegative = number < 0;
            long reversed = 0;
            while (number != 0)
            {
                long digit = number % 10;
                reversed = reversed * 10 + digit;
                number /= 10;
            }
            if (isNegative)
            {
                reversed = -reversed;
            }
            Console.WriteLine("Результат: " + reversed);
        }
    }
}

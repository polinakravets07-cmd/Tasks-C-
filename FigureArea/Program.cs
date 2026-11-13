using System;
using System.Globalization;
namespace FigureArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Оберіть фігуру:");
            Console.WriteLine("1 - Квадрат");
            Console.WriteLine("2 - Круг");
            Console.WriteLine("3 - Прямокутник");
            Console.WriteLine("4 - Трикутник");
            Console.Write("Ваш вибір: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            double a, b, area;
            switch (choice)
            {
                case 1:
                    Console.Write("Введіть сторону квадрата: ");
                    a = double.Parse(Console.ReadLine() !.Replace(',', '.'), CultureInfo.InvariantCulture);
                    area = a * a;
                    Console.WriteLine("Площа квадрата: " + area);
                    break;
                case 2:
                    Console.Write("Введіть радіус круга: ");
                    a = double.Parse(Console.ReadLine()!.Replace(',', '.'), CultureInfo.InvariantCulture);
                    area = Math.PI * a * a;
                    Console.WriteLine("Площа круга: " + area);
                    break;
                case 3:
                    Console.Write("Введіть першу сторону прямокутника: ");
                    a = double.Parse(Console.ReadLine()!.Replace(',', '.'), CultureInfo.InvariantCulture);
                    Console.Write("Введіть другу сторону прямокутника: ");
                    b = double.Parse(Console.ReadLine()!.Replace(',', '.'), CultureInfo.InvariantCulture);
                    area = a * b;
                    Console.WriteLine("Площа прямокутника: " + area);
                    break;
                case 4:
                    Console.Write("Введіть основу трикутника: ");
                    a = double.Parse(Console.ReadLine()!.Replace(',', '.'), CultureInfo.InvariantCulture);
                    Console.Write("Введіть висоту трикутника: ");
                    b = double.Parse(Console.ReadLine()!.Replace(',', '.'), CultureInfo.InvariantCulture);
                    area = a * b / 2;
                    Console.WriteLine("Площа трикутника: " + area);
                    break;
                default:
                    Console.WriteLine("Невірний вибір фігури!");
                    break;
            }
        }
    }
}

using static Guiao8.Ex83;

namespace Guiao8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Exercicio 8.1
            Ex81.Date date = new Ex81.Date(10, 5, 2023);
            while (true)
            {
                Console.WriteLine("\n1 - create new date.");
                Console.WriteLine("2 - show current date.");
                Console.WriteLine("3 - increment date.");
                Console.WriteLine("4 - decrement date.");
                Console.WriteLine("0 - exit.");
                Console.Write("Enter your choice: ");
                string? choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.Write("Day: ");
                        int day = int.Parse(Console.ReadLine());
                        Console.Write("Month: ");
                        int month = int.Parse(Console.ReadLine());
                        Console.Write("Year: ");
                        int year = int.Parse(Console.ReadLine());
                        date.Set(day, month, year);
                        break;
                    case "2":
                        Console.WriteLine(date);
                        break;
                    case "3":
                        date.Increment();
                        break;
                    case "4":
                        date.Decrement();
                        break;
                    case "0":
                        Console.WriteLine("Done.");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
            */



            /* Exercicio 8.3
            try
            {
                Triangle t1 = new Triangle(3, 4, 5);
                Triangle t2 = new Triangle(6, 8, 10);
                Circle c1 = new Circle(1);
                Circle c2 = new Circle(2);
                Circle c3 = new Circle(1);
                Rectangle ret1 = new Rectangle(10, 5);
                Rectangle ret2 = new Rectangle(6, 7);
                Rectangle ret3 = new Rectangle(10, 5);

                Console.WriteLine($"{t1} Area = {t1.Area()}");
                Console.WriteLine($"{t1} P = {t1.Perimeter()}");
                Console.WriteLine($"{t1} == {t2} : {t1.Equals(t2)}");

                Console.WriteLine($"{c1} Area = {c1.Area()}");
                Console.WriteLine($"{c1} P = {c1.Perimeter()}");
                Console.WriteLine($"{c1} == {c2} : {c1.Equals(c2)}");
                Console.WriteLine($"{c1} == {c3} : {c1.Equals(c3)}");

                Console.WriteLine($"{ret1} Area = {ret1.Area()} {ret1} P = {ret1.Perimeter()}");
                Console.WriteLine($"{ret1} == {ret2} : {ret1.Equals(ret2)}");
                Console.WriteLine($"{ret1} == {ret3} : {ret1.Equals(ret3)}");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            */
        }
    }
}

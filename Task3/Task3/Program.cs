using Task3;

namespace LearnItCSD06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duration d1 = new Duration(1, 50, 55);
            Console.WriteLine($"D1 : {d1.ToString()}");

            Duration d2 = new Duration(3600);
            Console.WriteLine($"D2 : {d2.ToString()}");

            Duration d3 = new Duration(7800);
            Console.WriteLine($"D3 : {d3.ToString()}");

            Duration d4 = new Duration(666);
            Console.WriteLine($"D4 : {d4.ToString()}");

            Duration d5;
            d5 = d1 + d3;
            Console.WriteLine($"D1 + D3 : {d5.ToString()}");

            d5 = d1 + 7800;
            Console.WriteLine($"D1 + 7800 : {d5.ToString()}");

            d5 = 666 + d1;
            Console.WriteLine($"666 + D1 : {d5.ToString()}");

            d5 = d1++;
            Console.WriteLine($"D1 : {d1.ToString()}");
            Console.WriteLine($"D1++ : {d5.ToString()}");

            d5 = ++d1;
            Console.WriteLine($"D1 : {d1.ToString()}");
            Console.WriteLine($"++D1 : {d5.ToString()}");

            d5 = d1--;
            Console.WriteLine($"D1 : {d1.ToString()}");
            Console.WriteLine($"D1-- : {d5.ToString()}");

            d5 = --d1;
            Console.WriteLine($"D1 : {d1.ToString()}");
            Console.WriteLine($"--D1 : {d5.ToString()}");

            if (d1 >= d2)
            {
                Console.WriteLine("Bigger");
            }
            else
            {
                Console.WriteLine("smaller");
            }
        }
    }
}
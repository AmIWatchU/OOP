using System;

namespace Lab1
{
    class Example1
    {
        static void Main(string[] args)
        {
            string message = "Hello World!"; // Giving string message a value
            Console.WriteLine(message);

            /*
             Явні перетворення
             */
            
            long l = 20000000000;
            int i = (int)l;
            short s = (short)i;
            byte b = (byte)s;
            Console.WriteLine($"l= {l}\ni= {i}\ns= {s}\nb= {b}");
            /*
             Неявне перетворення
             */
            byte by = 100;
            short sh = by;
            int x = sh;
            long y = x;
            Console.WriteLine(y);
            /*
             Оператори перетворення
            */
            Console.WriteLine("Введiть число з якого ви хочете отримати квадрат:");
            string r = Console.ReadLine();
            int x1 = int.Parse(r);
            int x2 = Convert.ToInt32(r);
            Console.WriteLine($"x^2 = {x1 * x2}");
            

            Console.ReadKey();

        }
    }
}


using System;

namespace Name_cycle_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            string symbol;
            string frame = "";

            Console.WriteLine("Введите имя:");
            name = Console.ReadLine();
            Console.WriteLine("Введите символ");
            symbol = Console.ReadLine();

            for (int i = 0; i < name.Length; i++)
            {
                frame += symbol;
            }

            frame += symbol + symbol;

            Console.WriteLine();
            Console.WriteLine(frame);
            Console.WriteLine(symbol + name + symbol);
            Console.WriteLine(frame);

            Console.ReadKey();
        }
    }
}

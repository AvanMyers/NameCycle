using System;

namespace Name_cycle_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            string symbol;
            string nameAndSymbol;
            string frame = "";

            Console.WriteLine("Введите имя:");
            name = Console.ReadLine();
            Console.WriteLine("Введите символ");
            symbol = Console.ReadLine();
            nameAndSymbol = symbol + name + symbol;

            for (int i = 0; i < nameAndSymbol.Length; i++)
            {
                frame += symbol;
            }

            Console.WriteLine();
            Console.WriteLine(frame);
            Console.WriteLine(nameAndSymbol);
            Console.WriteLine(frame);
            Console.ReadKey();
        }
    }
}

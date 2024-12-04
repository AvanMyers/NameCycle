using System;

namespace Name_cycle_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            string symbol;
            string lineOuput;
            string frame = "";

            Console.WriteLine("Введите имя:");
            name = Console.ReadLine();
            Console.WriteLine("Введите символ");
            symbol = Console.ReadLine();
            lineOuput = symbol + name + symbol;

            for (int i = 0; i < lineOuput.Length; i++)
            {
                frame += symbol;
            }

            Console.WriteLine();
            Console.WriteLine(frame);
            Console.WriteLine(lineOuput);
            Console.WriteLine(frame);
            Console.ReadKey();
        }
    }
}

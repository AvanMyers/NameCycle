using System;

namespace Name_cycle_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            string simbol;
            string simbolName = "";

            Console.WriteLine("Введите имя:");
            name = Console.ReadLine();
            Console.WriteLine("Введите символ");
            simbol = Console.ReadLine();


            for (int i = 0; i < name.Length; i++)
            {
                simbolName += simbol;
            }

            simbolName += simbol + simbol;

            Console.WriteLine();
            Console.WriteLine(simbolName);
            Console.WriteLine(simbol + name + simbol);
            Console.WriteLine(simbolName);

            Console.ReadKey();
        }
    }
}

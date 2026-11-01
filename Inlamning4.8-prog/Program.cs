using System;

namespace Inlamning4._8_prog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange triagelns sidlängd: ");
            int langd = int.Parse(Console.ReadLine());

            for (int rad = 1; rad <= langd; rad++)
            {
                for (int kolumn = 1; kolumn <= rad; kolumn++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
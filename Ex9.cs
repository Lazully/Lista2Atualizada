// Escreva um aplicativo mostra todos os números ímpares de 1 até 100.

using System;

namespace Ex9
{
    class Ex9
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"=========== Números ímpares ==========={Environment.NewLine}");

            Impares();
        }

        public static void Impares()
        {
            for (int i = 0; i <= 100; i++)
            {
                if(i%2 == 1)
                {
                    Console.WriteLine($"{i}");
                }
            }
        }
    }
}

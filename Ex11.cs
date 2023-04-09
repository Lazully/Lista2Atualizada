//Escreva um programa que solicita 10 números ao usuário, através de um laço while, e ao final
//mostre qual destes números é o maior.


using System;

namespace Ex11
{
    class Ex11
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"========= Maior número ========={Environment.NewLine}");

            Verifica();
        }

        public static void Verifica()
        {
            int i;
            float n, contMaior = -99999999999999;

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine($"Digite o {i+1}º número: ");
                n = Convert.ToSingle(Console.ReadLine());

                if(n > contMaior)
                {
                    contMaior = n;
                }
            }
            Console.WriteLine($"{Environment.NewLine}{Environment.NewLine}O maior número é: {contMaior}");
        }
    }
}

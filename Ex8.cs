﻿// Solicitar um nome e escrevê-lo de trás pra frente

using System;

namespace Ex8
{
    class Ex8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========== Como é seu nome ao contrário? ==========");

            StringReverse();
        }

        public static void StringReverse()
        {
            string nome;

            Console.WriteLine($"{Environment.NewLine}Informe o nome: ");
            nome = Console.ReadLine();

            for (int i = 0; i < nome.Length; i++)
            {
                char c = nome[i];
            }

            Console.WriteLine($"{Environment.NewLine}Nome ao contrárioe: ");
            for (int i = nome.Length - 1; i >= 0; i--)
            {
                char c = nome[i];
                Console.WriteLine(c);
            }
        }
    }
}
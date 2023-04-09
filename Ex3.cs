﻿/*Faça um programa que calcula o produto dos números digitados pelo usuário. O programa deve
permitir que o usuário digite uma quantidade não determinada de números. O programa ncerra
quando o usuário digita o valor zero.*/

using System;

namespace Ex3
{
    class Ex3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=============== Produto dos números ===============");

            ProdutoDosNumeros();

            Console.WriteLine($"{Environment.NewLine}=============== Fim ===============");
        }

        public static void ProdutoDosNumeros()
        {
            int produto = 1, numEntrada = 0;
            //laço de repetição para pessoa digitar até que seja entrado um número maior que 1000
            do
            {
                Console.WriteLine($"{Environment.NewLine}Digite um número: ");
                numEntrada = Convert.ToInt32(Console.ReadLine());

                if (numEntrada == 0)
                    break;

                produto *= numEntrada;
            } while (numEntrada != 0);

            Console.WriteLine($"{Environment.NewLine}Produto: {produto}");

        }
    }
}
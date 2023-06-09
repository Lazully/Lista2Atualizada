﻿/*Um funcionário recebe aumento anual. Em 2005 foi contratado por 2000 reais. Em 2006 recebeu
aumento de 1.5%. A partir de 2007, os aumentos sempre correspondem ao dobro do ano anterior.
Faça programa que determine o salário atual do funcionário.*/

using System;

namespace Ex15
{
    class Ex15
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============== Calcula Aumento de Salário ==============");

            Console.WriteLine($"{Environment.NewLine}Qual o último ano do contrato de trabalho? ");

            Console.WriteLine("Salário final: " + CalculaSalario(Convert.ToInt32(Console.ReadLine())));
        }

        public static double CalculaSalario(int anoFinal)
        {
            double salarioFinal = 0, salarioBase = 2000, taxaAumento = 0.015;
            int anoContratoInicio = 2005;

            if (anoFinal <= anoContratoInicio)
            {
                return 0;
            }
            else if (anoFinal == anoContratoInicio + 1)
                return salarioBase;

            for (int anoAtual = anoContratoInicio + 1; anoAtual <= anoFinal; anoAtual++)
            {
                int multiplicador = anoContratoInicio - anoAtual;
                double aumento = salarioBase * (taxaAumento * multiplicador);
                salarioBase += aumento;
                Console.WriteLine($"({anoAtual}) Novo salário: {Math.Round(salarioBase, 2)}" + $"Aumento: {Math.Round(aumento, 2)}");
            }

            return salarioFinal;
        }
    }
}

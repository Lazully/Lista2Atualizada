// Solicitar a idade de várias pessoas e imprimir: Total de pessoas com menos de 21 anos. Total de
// pessoas com mais de 50 anos. O programa termina quando idade for =-99.


using System;

namespace Ex6
{
    class Ex6
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"========== Qual a sua Idade? ==========");

            idade();
        }

        public static void idade()
        {
            int idade, cont21 = 0, cont50 = 0, contElse = 0;

            Console.WriteLine($"{Environment.NewLine}Informe a idade (para encerrar, digite -99): ");
            idade = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.WriteLine($"{Environment.NewLine}Informe a idade (para encerrar, digite -99): ");
                idade = Convert.ToInt32(Console.ReadLine());

                    if (idade < 21)
                        cont21++;
                    if (idade > 50)
                        cont50++;
                    if (idade >= 21 && idade <= 50)
                        contElse++;

            } while (idade != -99);

            Console.WriteLine($"{Environment.NewLine}O total de pessoas com menos de 21 anos é de: {cont21}");
            Console.WriteLine($"O total de pessoas com mais de 50 anos é de: {cont50}");
            Console.WriteLine($"O total de pessoas com mais de 21 anos e menos de 50 anos é de: {contElse}");
        }
    }
}

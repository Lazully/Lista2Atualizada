//Solicitar um número entre 1 e 4. Se a pessoa digitar um número diferente, mostrar a mensagem
//"entrada inválida" e solicitar o número novamente. Se digitar correto mostrar o número digitado

using System;

namespace Ex7
{
    class Ex7
    {
        static void Main(string[] args)
        {
            int numeroDigitado;

            Console.WriteLine("Digite um número de 1 a 4: ");
            numeroDigitado = Convert.ToInt32(Console.ReadLine());

            if (numeroDigitado > 0 && numeroDigitado < 5)
            {
                switch (numeroDigitado)
                {
                    case 1:
                        Console.WriteLine($"Número digitado: {numeroDigitado}");
                        break;
                    case 2:
                        Console.WriteLine($"Número digitado: {numeroDigitado}");
                        break;
                    case 3:
                        Console.WriteLine($"Número digitado: {numeroDigitado}");
                        break;
                    case 4:
                        Console.WriteLine($"Número digitado: {numeroDigitado}");
                        break;
                }
            }else
                Console.WriteLine($"Número inválido! ");
        }
    }
}

/*Escreva um programa que pergunte ao usuário quantos alunos tem na sala dele.
Em seguida, através de um laço, peça ao usuário para que entre com as notas de todos os alunos
da sala, um por vez. Por fim, o programa deve mostrar a média aritmética da turma.*/


using System;

namespace Ex10
{
    class Ex10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========== Calcula Nota ===========");

            NotaAluno();//chamada da função
        }

        private static void NotaAluno()
        {
            //variáveis
            int n, i;
            float notaAluno, soma = 0, media = 0;

            //entrada da quantidade de alunos
            Console.WriteLine($"{Environment.NewLine}Quantos alunos tem na sala? ");
            n = Convert.ToInt32(Console.ReadLine());

            //para i=0, i< que quantidade de alunos, i incrementado
            for(i = 0; i<= n; i++)
            {
                //fazer (laço de repetição)
                do
                {
                    Console.WriteLine($"Entre com a nota do aluno {i+1}: ");
                    notaAluno = Convert.ToSingle(Console.ReadLine());

                    soma += notaAluno;//soma das notas
                    i++;//incrementa i
                } while (i < n);//enquanto i foi menor que o número de alunos
                media = soma / n;//média aritmética
            }
            Console.WriteLine($"{Environment.NewLine}A média aritmética da sala é de: {media}");
        }
    }
}

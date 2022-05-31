using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            //Leitura de notas
            float media = 0;

            Console.WriteLine("Para iniciarmos, por favor digite seu nome: ");
            String nome = Console.ReadLine();
            Console.WriteLine("Olá {0}! Bem vindo(a) ao programa de cálculo de média!", nome);

            Console.WriteLine("Irei auxiliar você a calcular a média do seu aluno!");

            Console.WriteLine("Digite a primeira nota: ");
            int.TryParse(Console.ReadLine(), out int nota1);

            Console.WriteLine("Digite a segunda nota: ");
            int.TryParse(Console.ReadLine(), out int nota2);

            Console.WriteLine("Digite a terceira nota: ");
            int.TryParse(Console.ReadLine(), out int nota3);

            media = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine("A média do aluno é: {0}", media);

            if(media < 70)
            {
                Console.WriteLine("Aluno está em recuperação.");
            }
            else
            {
                Console.WriteLine("Aluno aprovado!");
            }
        }
    }
}

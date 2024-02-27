using System;

namespace Atividade01
{
    class Program
    {
        // Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais velha.
        static void Main(string[] args)
        {
     
            Pessoa A = new Pessoa();
            Pessoa B = new Pessoa();

            Console.WriteLine("Digite seu nome 1: ");
            A.Nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade 1: ");
            A.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu nome 2: ");
            B.Nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade 2: ");
            B.Idade = int.Parse(Console.ReadLine());

            if (A.Idade > B.Idade)
            {
                Console.WriteLine($"A Pessoa mais velha é a 1");
            }
            else if (A.Idade < B.Idade)
            {
                Console.WriteLine("A Pessoa 2 pe mais velha");
            }
            else
            {
                Console.WriteLine("Ambas tem a mesma idade");
            }
        }
    }
}

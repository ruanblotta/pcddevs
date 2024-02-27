using System;

namespace mediaSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            FolhaPagamento A = new FolhaPagamento();
            FolhaPagamento B = new FolhaPagamento();
            
            Console.WriteLine("Informe o nome do funcionário 01: ");
            A.Nome = Console.ReadLine();

            Console.WriteLine("Informe o salário do funcionário 01: ");
            A.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o nome do funcionário 02: ");
            B.Nome = Console.ReadLine();

            Console.WriteLine("Informe o salário do funcionário 02: ");
            B.Salario = double.Parse(Console.ReadLine());

            double MediaSal;

            MediaSal = (A.Salario + B.Salario) / 2;

            Console.WriteLine("A media salarial entre os funcionário é de R$:" + MediaSal);
        }
    }
}




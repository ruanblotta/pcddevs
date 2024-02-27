using System;

namespace calcAreaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double xA, xB, xC, yA, yB, yC;
            Console.WriteLine("Infomre o valor dos lados do triangulo X: ");
            xA = double.Parse(Console.ReadLine());
            xB = double.Parse(Console.ReadLine());
            xC = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor dos lados do triangulo Y: ");
            yA = double.Parse(Console.ReadLine());
            yB = double.Parse(Console.ReadLine());
            yC = double.Parse(Console.ReadLine());

            double p = (xA + xB + xC) / 2.0;
            double areaX = Math.Sqrt(pX * (p - xA) * (p - xB) * (p - xC));

            p = (yA + yB + yC) / 2.0;
            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

            Console.WriteLine("A area do triângulo X:" + areaX);
            Console.WriteLine("A area do triângulo Y:" + areaY);

            if (areaX > areaY)
            {
                Console.WriteLine("A Area do Triangulo X é maior.");
            }
            else
            {
                Console.WriteLine("A Area do Triangulo Y é maior.");
            }
        }
    }
}

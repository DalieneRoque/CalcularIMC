using System;

namespace CalcularIMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o peso em Kg: ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Informe a altura em metros: ");
            double altura = double.Parse(Console.ReadLine());

            double valorIMC = peso / (altura * altura);

            if (valorIMC < 20)
            {
                Console.WriteLine($"\n IMC =  {valorIMC:F2} -> Abaixo do peso.");

            }
            else if ((valorIMC >= 20) && (valorIMC  <= 24)) 
            {
                Console.WriteLine($"\n IMC =  {valorIMC:F2} -> Normal.");
            }
            else if ((valorIMC >= 25) && (valorIMC <= 29))
            {
                Console.WriteLine($"\n IMC =  {valorIMC:F2} -> Acima do peso.");
            }
            else if ((valorIMC >= 30) && (valorIMC <= 34))
            {
                Console.WriteLine($"\n IMC =  {valorIMC:F2} -> Obeso.");
            }
            else
            {
                Console.WriteLine($"\n IMC = {valorIMC:F2} -> Muito Obeso.");
            }

            Console.ReadKey();
        }
    }
}

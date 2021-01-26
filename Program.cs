using System;
using System.Globalization;

namespace ExercicioDeFixacaoV23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos têm na sua casa?");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha):");
            string[] vet = Console.ReadLine().Split(' ');
            string nome2 = vet[0];
            int n3 = int.Parse(vet[1]);
            double n4 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(n1);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome2);
            Console.WriteLine(n3);
            Console.WriteLine(n4.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

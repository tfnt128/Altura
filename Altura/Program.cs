using System;
using System.Globalization;

namespace Altura
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com um número de pessoas: ");
            int n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            float[] vet = new float[n]; //criando o vetor com o número N que o usuário digitar
            float soma = 0; //criando a variavel para somar no looping

            for (int i = 0; i < n; i++)
            {
                Console.Write("Altura da pessoa (" + (i + 1) + "): ");
                vet[i] = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                soma += vet[i]; //soma de vetores
            }
            float media = soma / n; //cálculo da média
 
            Console.WriteLine("A média de altura das pessoas inseridas é = " + media.ToString("F2", CultureInfo.InvariantCulture));
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.WriteLine("Realizando: conversão valor em Dolar para Reais ( 1 USD = 5,05 BRL em 26/04/23):");
            Console.Write("Digite o valor em Dolar:");
            a = double.Parse(Console.ReadLine());

            b = a*5.05;
            Console.WriteLine($"A conversão de {a} USD resultou em {b} BRL.");

        }
    }
}

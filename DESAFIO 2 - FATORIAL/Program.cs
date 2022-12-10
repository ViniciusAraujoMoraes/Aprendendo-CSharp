using System;
using System.Data;
using System.Diagnostics.Metrics;

class Programa
{
        static void Main(string[] args)
    {
        int fatorial = 1;

        for(int n1 = 1; n1 < 11; n1++)
        {
            fatorial *= n1;
            Console.WriteLine("Fatorial de " + n1 + " é igual a " + fatorial);
        }
        Console.WriteLine("Aperte Enter para fechar...");
        Console.ReadLine();
    }
}
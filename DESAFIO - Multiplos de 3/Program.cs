// Crie um programa que imprima todos os multiplos de 3 entre 1 um e 100;
using System;
using System.Data;
using System.Diagnostics.Metrics;
class Programa
{
    static void Main(string[] args)
    {
        int n1;
        for (n1 = 1; n1 < 100; n1++)
        {
            if (n1 % 3 == 0)
            {             
                Console.WriteLine(n1);
            }
            n1 = n1 + 1;
        }
        Console.WriteLine("Aperte Enter para fechar...");
        Console.ReadLine();
    }

}
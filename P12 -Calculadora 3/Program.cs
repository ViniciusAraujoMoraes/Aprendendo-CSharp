using System;
using System.Data;
using System.Diagnostics.Metrics;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 12 - Calcula Poupança");

        double salario = 3000;
        double rendimento = 1.005;
        for (int ano = 1; ano < 6; ano++)
        {

            for (int meses = 1; meses < 13; meses++)
            {
                salario *= 1.005;
                 
            }
            rendimento += .001;

        }
        Console.WriteLine("Depois de 5 anos você terá R$ " + salario);


        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}
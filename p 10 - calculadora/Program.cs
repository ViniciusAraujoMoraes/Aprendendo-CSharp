﻿using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 10 - Calcula Poupança");

        // calcule quanto a popanca que rende 0.5% (0.005) ao mês de acordo com o periodo de meses digitados.

        double salario = 3000;
        int meses = 1;

        while (meses < 13)
        {
            salario = (salario * 0.005) + salario;
            Console.WriteLine("No mes " + meses + " seu saldo é " + salario);
            meses = meses + 1;
            
        }
      

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}
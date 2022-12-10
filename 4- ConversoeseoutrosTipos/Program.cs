using System;

class Programa
{
    static void Main(string[] args)
    {
        double salario = 300.15;
        Console.WriteLine(salario); ;

        int salarioInteiro = (int)salario;
        Console.WriteLine(salarioInteiro);

        //long é um tipo de variavel de 64 bits
        long x = 20000000000000000;
        Console.WriteLine(x);

        short y = 15000;
        Console.WriteLine(y);

        Console.WriteLine("Aperte enter para fechar...");
        Console.ReadLine();
    }
}
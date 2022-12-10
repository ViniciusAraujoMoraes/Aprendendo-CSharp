using System;

class Programa
{

    static void Main(string[] args)
    {
        Console.WriteLine("Esxecultando Porjeto 7 - Condicionais");

        int idadeJoao = 16;
        int quantidadePessoas = 2;
        if (idadeJoao >= 18)
        {
            Console.WriteLine("Pode entrar");
        }
        else if (quantidadePessoas > 1)
        {
            Console.WriteLine("Pode entrar");
        }
        else
        {
            Console.WriteLine("Não Pode entrar");
        }
        Console.WriteLine("Tecle enter para finalizar...");
        Console.ReadLine();

    }
}

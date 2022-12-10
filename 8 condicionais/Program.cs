using System;

class Programa
{

    static void Main(string[] args)
    {
        Console.WriteLine("Esxecultando Porjeto 8 - Condicionais");

        int idadeJoao = 16;
        int quantidadePessoas = 2;
        bool acompanhado = quantidadePessoas > 1;
        if (idadeJoao >= 18 && acompanhado)
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

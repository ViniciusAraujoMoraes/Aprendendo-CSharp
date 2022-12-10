using System;

class Programa
{

    static void Main(string[] args)
    {
        Console.WriteLine("Esxecultando Porjeto 8 - Condicionais");

        int idadeJoao = 16;
        int quantidadePessoas = 1;

        bool acompanhado = quantidadePessoas > 1;

        string textoAdicional;

        if (acompanhado == true) {
            textoAdicional = "joão esta acompanhado";
        }
        else
        {
            textoAdicional = "joão esta sozinho";

        }
        if (idadeJoao >= 18 || acompanhado)
        {
            Console.WriteLine(textoAdicional);
            Console.WriteLine("Pode entrar");
        }
        else
        {
            Console.WriteLine(textoAdicional);
            Console.WriteLine("Não Pode entrar");
        }
        Console.WriteLine("Tecle enter para finalizar...");
        Console.ReadLine();

    }
}

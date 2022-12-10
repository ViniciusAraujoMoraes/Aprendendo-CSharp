using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Execultando o Projeto 5 - Caraceters e Textos");

        //char armazena letras na memoria
        char letra = 'a';
        Console.WriteLine(letra);

        letra = (char)65;
        Console.WriteLine(letra);

        letra = (char)(5+65);
        Console.WriteLine(letra);

        letra = (char)6;
        Console.WriteLine(letra);

        letra = (char)(84+2);
        Console.WriteLine(letra);

        string primeiraFrase = "Alura - Curso de Tecnologia";
            Console.WriteLine(primeiraFrase + 2022);

        Console.WriteLine(@"Cursos disponiveis:
- Go 
- Python 
- Java");

        Console.WriteLine("Digite enter para fechar");
        Console.ReadLine();
    }
}
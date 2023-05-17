using System;
using Sistema_UC12.Classes;

class Program
{
    static void Main(string[] args)
    {
        PessoaFisica Ygor = new PessoaFisica();
        Ygor.nome = "Ygor";

        Console.WriteLine(Ygor.nome); 
    }
}
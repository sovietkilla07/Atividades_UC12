using System;
using Sistema_UC12.Classes;

class Program
{
    static void Main(string[] args)
    {
        Pessoa novaPessoa = new Pessoa();

        novaPessoa.nome = "Ygor";
        novaPessoa.endereco = "Rua Broadway, 255";
        novaPessoa.enderecoComercial = false;

        Console.WriteLine(novaPessoa.nome);
    }
}
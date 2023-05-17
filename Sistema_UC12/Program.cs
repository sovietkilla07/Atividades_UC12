using System;
using Sistema_UC12;
using Sistema_UC12.Classes;

class Program
{
    static void Main(string[] args)
    {
        Endereco end = new Endereco();
        end.logradouro = "Rua Isabela Luna Tavares";
        end.numero = 553;
        end.complemento = "Casa";
        end.enderecoComercial = false;

        PessoaFisica novapf = new PessoaFisica();

        novapf.cpf = "657.242.782-33";
        novapf.endereco = end;
        novapf.dataNascimento = new DateTime(2004, 01, 18);
        novapf.nome = "Ygor de Andrade Guides";

        Console.WriteLine(novapf.endereco.logradouro);
        Console.WriteLine(novapf.endereco.numero);
        Console.WriteLine(novapf.endereco.complemento);
        Console.WriteLine(novapf.endereco.enderecoComercial);
        Console.WriteLine(novapf.cpf);
        Console.WriteLine(novapf.dataNascimento);
        Console.WriteLine(novapf.nome);
    }
}
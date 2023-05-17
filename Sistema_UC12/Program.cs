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

        bool idadeValidada = novapf.validarDataNascimento(novapf.dataNascimento);
        if(idadeValidada == true){
            Console.WriteLine($"Pode beber pinga.");
        }else{
            Console.WriteLine($"Ainda vai ficar só no refri.");
        }


        //Console.WriteLine(novapf.endereco.logradouro);
        //Console.WriteLine(novapf.endereco.numero);
        //Console.WriteLine(novapf.endereco.complemento);
        //Console.WriteLine(novapf.endereco.enderecoComercial);
        //Console.WriteLine(novapf.cpf);
        //Console.WriteLine(novapf.dataNascimento);
        //Console.WriteLine(novapf.nome);

        //Interpolação

        Console.WriteLine($"O endereço do {novapf.nome} é {novapf.endereco.logradouro}, número {novapf.endereco.numero}.");

        //Concatenação

        Console.WriteLine("O endereço do " + novapf.nome + " é " + novapf.endereco.logradouro + ", número " + novapf.endereco.numero + ".");
    }
}
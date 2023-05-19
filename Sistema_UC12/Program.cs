using System;
using Sistema_UC12;
using Sistema_UC12.Classes;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine(@$"
        #############################################################################
        #                                                                           #
        # Seja Bem-Vindo ao sistema de cadastro de pessoa física e pessoa jurídica! #
        #                                                                           #
        #############################################################################
        ");
        Console.WriteLine("Iniciando");
        Thread.Sleep(750);

        for (var contador = 0; contador < 10; contador++)
        {
            Console.Write("|");
            Thread.Sleep(750);
        }

        Console.Clear();
        Console.WriteLine(@$"
        
        #############################################################################
        #                                                                           #
        #                 Escolha uma das opções abaixo:                            #
        #                                                                           #
        #############################################################################
        #                                                                           #
        #                 1 - Pessoa Física (PF)                                    #
        #                 2 - Pessoa Jurídica (PJ)                                  #
        #                                                                           #
        #                 0 - Sair                                                  #
        #############################################################################
        
        ");

        string opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
            Console.WriteLine("Você escolheu a opção 1.");
            break;

            case "2":
            Console.WriteLine("Você escolheu a opção 2.");
            break;

            case "0":
            Console.WriteLine("Você escolheu a opção 0.");
            break;

            default:
            Console.WriteLine("Opção inválida! Digite uma das opções apresentadas.");
            break;
        }

        Console.ResetColor();

        //Endereco end = new Endereco();
        //end.logradouro = "Rua Isabela Luna Tavares";
        //end.numero = 553;
        //end.complemento = "Casa";
        //end.enderecoComercial = false;

        //PessoaFisica novapf = new PessoaFisica();

        //novapf.cpf = "657.242.782-33";
        //novapf.endereco = end;
        //novapf.dataNascimento = new DateTime(2004, 01, 18);
        //novapf.nome = "Ygor de Andrade Guides";

        //bool idadeValidada = novapf.validarDataNascimento(novapf.dataNascimento);
        //if(idadeValidada == true){
            //Console.WriteLine($"Pode beber pinga.");
        //}else{
            //Console.WriteLine($"Ainda vai ficar só no refri.");
        //}


        //Console.WriteLine(novapf.endereco.logradouro);
        //Console.WriteLine(novapf.endereco.numero);
        //Console.WriteLine(novapf.endereco.complemento);
        //Console.WriteLine(novapf.endereco.enderecoComercial);
        //Console.WriteLine(novapf.cpf);
        //Console.WriteLine(novapf.dataNascimento);
        //Console.WriteLine(novapf.nome);

        //Interpolação

        //Console.WriteLine($"O endereço do {novapf.nome} é {novapf.endereco.logradouro}, número {novapf.endereco.numero}.");

        //Concatenação

        //Console.WriteLine("O endereço do " + novapf.nome + " é " + novapf.endereco.logradouro + ", número " + novapf.endereco.numero + ".");

        //PessoaJuridica novaPj = new PessoaJuridica();
        //novaPj.endereco = end;
        //novaPj.nome = "SENAI";
        //novaPj.cnpj = "01234567890001";
        //novaPj.razaoSocial = "Empresa de cosméticos.";

        //novaPj.validarCNPJ(novaPj.cnpj);
        
        //if (novaPj.validarCNPJ(novaPj.cnpj))
        //{
            //Console.WriteLine("CNPJ válido.");
        //}
        //else
        //{
        //    Console.WriteLine("CNPJ inválido.");
        //}
    }
}
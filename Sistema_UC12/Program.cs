using System;
using Sistema_UC12;
using Sistema_UC12.Classes;

class Program
{
    static void Main(string[] args)
    {
        void barraCarregamento(string textoCarregamento)
        {
            Console.WriteLine(textoCarregamento);
            Thread.Sleep(500);

            for (var contador = 0; contador < 10; contador++)
            {
                Console.Write("|");
                Thread.Sleep(500);
            }
        }

        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine(@$"
        #############################################################################
        #                                                                           #
        # Seja Bem-Vindo ao sistema de cadastro de pessoa física e pessoa jurídica! #
        #                                                                           #
        #############################################################################
        ");
        
        barraCarregamento("Iniciando");

        Console.Clear();

        string opcao;

        do
        {
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

        opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
            Console.WriteLine("Você escolheu a opção 1.");

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

            Console.WriteLine($"O endereço do {novapf.nome} é {novapf.endereco.logradouro}, número {novapf.endereco.numero}.");

            bool idadeValidada = novapf.validarDataNascimento(novapf.dataNascimento);
            if(idadeValidada == true){
                Console.WriteLine($"Pode beber pinga.");
            }else{
                Console.WriteLine($"Ainda vai ficar só no refri.");
            }

            break;

            case "2":
            Console.WriteLine("Você escolheu a opção 2.");

            PessoaJuridica novaPj = new PessoaJuridica();

            Endereco endPj = new Endereco();
            endPj.logradouro = "Rua Niteroi";
            endPj.numero = 180;
            endPj.complemento = "SENAI";
            endPj.enderecoComercial = true;

            novaPj.endereco = endPj;
            novaPj.nome = "SENAI";
            novaPj.cnpj = "01234567890001";
            novaPj.razaoSocial = "Empresa de cosméticos.";

            Console.WriteLine($"O endereço do {novaPj.nome} é {novaPj.endereco.logradouro}, número {novaPj.endereco.numero}.");

            novaPj.validarCNPJ(novaPj.cnpj);

            if (novaPj.validarCNPJ(novaPj.cnpj))
            {
                Console.WriteLine("CNPJ válido.");
            }
            else
            {
                Console.WriteLine("CNPJ inválido.");
            }

            break;

            case "0":
            Console.WriteLine("Obrigado por utilizar nosso sistema!");
            Thread.Sleep(750);
            barraCarregamento("Finalizando");
            break;

            default:
            Console.WriteLine("Opção inválida! Digite uma das opções apresentadas.");
            break;
        }

        }while(opcao != "0");

        Console.ResetColor();

        

        


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

        
    }
}
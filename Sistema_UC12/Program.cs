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

        List<PessoaFisica> listapf = new List<PessoaFisica>();

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
            
            string? opcaoPF;

            do
            {
                Console.Clear();
                Console.WriteLine(@$"
        
                #############################################################################
                #                                                                           #
                #                 Escolha uma das opções abaixo:                            #
                #                                                                           #
                #############################################################################
                #                                                                           #
                #                 1 - Cadastrar Pessoa Física                               #
                #                 2 - Mostrar Pessoas Físicas                               #
                #                                                                           #
                #                 0 - Voltar ao menu anterior                               #
                #                                                                           #
                #############################################################################
        
        ");
                opcaoPF = Console.ReadLine();

                switch (opcaoPF)
                {
                    case "1":

                        PessoaFisica novapf = new PessoaFisica();
                        Endereco end = new Endereco();
                        novapf.endereco = end;       

			            Console.WriteLine("Digite o nome da pessoa física:");
                        novapf.nome = Console.ReadLine();

			            Console.WriteLine("Digite a data de nascimento (AAAA/MM/DD):");
                        novapf.dataNascimento = DateTime.Parse(Console.ReadLine());
                        bool idadeValidada = novapf.validarDataNascimento(novapf.dataNascimento);

                        if(idadeValidada == true){
                            Console.WriteLine($"Pode beber pinga.");
                        }else{
                            Console.WriteLine($"Ainda vai ficar só no refri.");
                        }

			            Console.WriteLine("Digite o CPF:");
                        novapf.cpf = Console.ReadLine();

			            Console.WriteLine("Digite o logradouro da PF que deseja cadastrar:");
                        end.logradouro = Console.ReadLine();

                        Console.WriteLine("Digite o número do endereço da PF:");
                        end.numero = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o complemento do endereço:");
                        end.complemento = Console.ReadLine();

                        Console.WriteLine("O local especificado é um endereço comercial? S/N");
                        string endCom = Console.ReadLine().ToUpper();
                        if (endCom == "S")
                        {
                            end.enderecoComercial = true;
                        }
                        else
                        {
                            end.enderecoComercial = false;
                        }

                        listapf.Add(novapf);
                        Console.WriteLine("Cadastro efetuado com sucesso!");
                        Thread.Sleep(5000);

                        break;

                    case "2":

                    Console.Clear();

                    if(listapf.Count > 0)
                    {
                        foreach(PessoaFisica cadaPessoa in listapf)
                        {
                            Console.Clear();
                            Console.WriteLine(@$"

                            Nome: {cadaPessoa.nome}
                            Endereço: {cadaPessoa.endereco.logradouro}, número {cadaPessoa.endereco.numero} ({cadaPessoa.endereco.complemento})
                            Data de nascimento: {cadaPessoa.dataNascimento}
                            CPF: {cadaPessoa.cpf}
                            ");
                        }
                        Console.WriteLine("Digite qualquer tecla para continuar.");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Lista vazia! Aguarde alguns instantes para voltar ao menu.");
                        Thread.Sleep(5000);
                    }

                        break;

                    case "0":
                        break;

                    default:

                    Console.Clear();
                    Console.WriteLine("Opção inválida. Por favor, digite outra opção.");
                    Thread.Sleep(2000);
                        break;
                }

            } while (opcaoPF != "0");


            






            // Console.WriteLine($"O endereço do {novapf.nome} é {novapf.endereco.logradouro}, número {novapf.endereco.numero}.");

             

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
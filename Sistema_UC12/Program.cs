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

                        Console.WriteLine("O endereço especificado é comercial? S/N");
                        string endCom = Console.ReadLine().ToUpper();
                        if (endCom == "S")
                        {
                            end.enderecoComercial = true;
                        }
                        else
                        {
                            end.enderecoComercial = false;
                        }

                        using(StreamWriter sw = new StreamWriter($"{novapf.nome}.txt"))
                        {
                            sw.WriteLine(novapf.nome);
                            sw.WriteLine(novapf.dataNascimento);
                        }

                        Console.WriteLine("Cadastro efetuado com sucesso!");
                        Thread.Sleep(5000);

                        break;

                    case "2":

                    Console.WriteLine("Digite o nome da PF que deseja consultar:");
                    string registro = Console.ReadLine();

                    using(StreamReader sr = new StreamReader($"{registro}.txt"))
                    {
                        string linha;
                        while((linha = sr.ReadLine()) != null)
                        {
                            Console.WriteLine($"{linha}");
                        }
                    }

                    Console.WriteLine("Sucesso! Digite qualquer tecla para continuar.");
                    Console.ReadLine();

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
            
            string? opcaoPJ;

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
                #                 1 - Cadastrar Pessoa Jurídica                             #
                #                 2 - Mostrar Pessoas Jurídicas                             #
                #                                                                           #
                #                 0 - Voltar ao menu anterior                               #
                #                                                                           #
                #############################################################################
                
                ");

                opcaoPJ = Console.ReadLine();

                switch (opcaoPJ)
                {
                    case "1":

                        PessoaJuridica novapj = new PessoaJuridica ();
                        Endereco endpj = new Endereco ();
                        novapj.endereco = endpj;

                        Console.WriteLine("Digite o nome da pessoa jurídica:");
                        novapj.nome = Console.ReadLine();

                        Console.WriteLine("Digite o CNPJ da pessoa jurídica:");
                        novapj.cnpj = Console.ReadLine();
                        //Método de validação do CNPJ//
                        if (novapj.validarCNPJ(novapj.cnpj))
                        {
                            Console.WriteLine("CNPJ válido!");
                        }
                        else
                        {
                            Console.WriteLine("CNPJ inválido! Verifique se os números digitados estão corretos.");
                        }

                        Console.WriteLine("Digite o logradouro da pessoa jurídica:");
                        endpj.logradouro = Console.ReadLine();

                        Console.WriteLine("Digite o número do endereço da pessoa jurídica:");
                        endpj.numero = int.Parse (Console.ReadLine ());

                        Console.WriteLine("Digite o complemento do endereço:");
                        endpj.complemento = Console.ReadLine();

                        Console.WriteLine("O endereço especificado é comercial? S/N");
                        string endComPj = Console.ReadLine().ToUpper();
                        if (endComPj =="S")
                        {
                            endpj.enderecoComercial = true;
                        }
                        else
                        {
                            endpj.enderecoComercial = false;
                        }

                        using (StreamWriter swpj = new StreamWriter ($"{novapj.nome}.txt"))
                        {
                            swpj.WriteLine(novapj.nome);
                            swpj.WriteLine(novapj.cnpj);
                        }

                        Console.WriteLine("Cadastro concluído com sucesso!");
                        Thread.Sleep(5000);

                    break;

                    case "2":

                    Console.WriteLine("Digite o nome da PJ que deseja consultar:");
                    string registroPj = Console.ReadLine();

                    using (StreamReader srpj = new StreamReader ($"{registroPj}.txt"))
                    {
                        string linha;
                        while ((linha = srpj.ReadLine()) != null)
                        {
                            Console.WriteLine($"{linha}");
                        }
                    }

                    Console.WriteLine("Sucesso! Digite qualquer tecla para continuar.");
                    Console.ReadLine();

                    break;

                    case "0":

                    break;

                    default:

                    break;
                }
            }
            while (opcaoPJ != "0");
            

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
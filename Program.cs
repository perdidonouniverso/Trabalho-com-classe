using System;
using POO;
using System.Threading;
using System.Collections.Generic;
using System.IO;


class Program{
    //Listas:
    static List<Cliente> listaClientes = new List<Cliente>();
    static List<Funcionarios> listaFuncionarios = new List<Funcionarios>();
    static List<Produtos> listaProdutos = new List<Produtos>();
    static List<Gerente> listaGerente = new List<Gerente>();
    static List<Vendedor> listaVendedor = new List<Vendedor>();
    static List<Vendas> listaVendas = new List<Vendas>();

    //Variaveis para controle de quantidade
    static int qtde_clientes;
    static int qtde_produtos;
    static int qtde_gerentes;
    static int qtde_vendedores;

    //Variaveis para controle de codigo
    static int codigoCliente;
    static int codigoProduto;
    static int codigoFuncionario;


    public static void Main(string[] args){
        //Variavel para escolha do Usuario:
        string escolha;
        
        
        Console.WriteLine("Seja bem-vindo ao programa!");
        Thread.Sleep(3000);
    
        do{
            Console.Clear();
            Console.WriteLine("SISTEMA DE CADASTRO E VENDAS");
            Console.WriteLine("");
            Console.WriteLine("1-Cadastros    2-Vender");
            Console.WriteLine("3-Sair");

            escolha = Console.ReadLine();

            switch(escolha){
                case "1":
                    Console.Clear();
                    Console.Clear();
                    Console.WriteLine("CADASTROS");
                    Console.WriteLine("");
                    Console.WriteLine("1-Consultar cadastros");
                    Console.WriteLine("2-Cadastrar cliente");
                    Console.WriteLine("3-Cadastrar produtos");
                    Console.WriteLine("4-Cadastrar gerente");
                    Console.WriteLine("5-Cadastrar vendedor");

                    //Variavel para escolha de usiuario:
                    string escolhaUser;

                    escolhaUser = Console.ReadLine();

                    switch(escolhaUser){
                        case "1":

                            ConsultaCadastros();

                        break;
                        case "2":

                            Preencherinformacoes(1);

                        break;
                        case "3":

                            Preencherinformacoes(2);

                        break;
                        case "4":

                            Preencherinformacoes(3);

                        break;
                        case "5":

                            Preencherinformacoes(4);

                        break;
                        default:
                            Console.Clear();
                        break;

                    }





                break;
                case "2":

                    Vender();

                break;
                default:
                    Console.Clear();
                break;


            }
           


        }while(escolha != "3");


    }


    public static void ConsultaCadastros(){
        Console.Clear();

        Console.WriteLine("CONSULTA AOS CADASTROS:");
        Console.WriteLine("");
        Console.WriteLine("1-Consultar todos os cadastros");
        Console.WriteLine("2-Consultar apenas um cadastro");

        string escolha;

        escolha = Console.ReadLine();
        switch(escolha){
            case "1":
                Console.Clear(); 
                Console.WriteLine("CONSULTA AOS CADASTROS:");
                Console.WriteLine("");
                Console.WriteLine("1-Consultar dados dos clientes");
                Console.WriteLine("2-Consultar dados de funcionarios");
                Console.WriteLine("3-Consultar dados de gerentes");
                Console.WriteLine("4-Consultar dados de vendedores");
                Console.WriteLine("5-Consultar dados de produtos");
                
                escolha = Console.ReadLine();
                switch(escolha){
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Lista de clientes cadastrados:");
                        Console.WriteLine("");
                        foreach (Cliente cliente in listaClientes)
                        {
                            Console.WriteLine(cliente.GetCodigoCliente() + " " + cliente.GetNome());
                        }
                        
                        Console.WriteLine("");
                        Console.WriteLine("Pressione qualquer tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();


                    break;
                    case "2":
 
                        Console.Clear();
                        Console.WriteLine("Lista de funcionaros cadastrados:");
                        Console.WriteLine("");
                        foreach (Funcionarios funcionario in listaFuncionarios)
                        {
                            Console.WriteLine(funcionario.GetCodigoFuncionario() + " " + funcionario.GetNome());
                        }
                        
                        Console.WriteLine("");
                        Console.WriteLine("Pressione qualquer tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();


                    break;
                    case "3":

                        Console.Clear();
                        Console.WriteLine("Lista de gerentes cadastrados:");
                        Console.WriteLine("");
                        foreach (Gerente gerente in listaGerente)
                        {
                            Console.WriteLine(gerente.GetCodigoFuncionario() + " " + gerente.GetNome());
                        }
                        
                        Console.WriteLine("");
                        Console.WriteLine("Pressione qualquer tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();


                    break;
                    case "4":

                        Console.Clear();
                        Console.WriteLine("Lista de vendedores cadastrados:");
                        Console.WriteLine("");
                        foreach (Vendedor vendedor in listaVendedor)
                        {
                            Console.WriteLine(vendedor.GetCodigoFuncionario() + " " + vendedor.GetNome());
                        }
                        
                        Console.WriteLine("");
                        Console.WriteLine("Pressione qualquer tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();


                    break;
                    case "5":

                        Console.Clear();
                        Console.WriteLine("Lista de produtos cadastrados:");
                        Console.WriteLine("");
                        foreach (Produtos produtos in listaProdutos)
                        {
                            Console.WriteLine(produtos.GetCodigo() + " " + produtos.GetNomeProduto());
                        }
                        
                        Console.WriteLine("");
                        Console.WriteLine("Pressione qualquer tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();

                    break;
                    default:

                    break;
                }


            break;
            case "2":
                Console.Clear();
                Console.WriteLine("CONSULTA AOS CADASTROS:");
                Console.WriteLine("");
                Console.WriteLine("1-Consultar dados dos clientes");
                Console.WriteLine("2-Consultar dados de funcionarios");
                Console.WriteLine("3-Consultar dados de gerentes");
                Console.WriteLine("4-Consultar dados de vendedores");
                Console.WriteLine("5-Consultar dados de produtos");

                escolha = Console.ReadLine();
                switch(escolha){
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Digite o nome do cliente:");
                        string nomeProcurado = Console.ReadLine();
                        Console.Clear();
                        foreach (Cliente cliente in listaClientes)
                        {
                            Console.Clear();
                            if(cliente.GetNome() == nomeProcurado){
                                Cliente clienteProcurado = cliente;
                                Console.Clear();
                                Console.WriteLine("DADOS DO CLIENTE:");
                                Console.WriteLine("");
                                Console.WriteLine("Nome do cliente: " + clienteProcurado.GetNome());
                                Console.WriteLine(""); 
                                Console.WriteLine("CPF do cliente: " + clienteProcurado.GetCpf());
                                Console.WriteLine("");
                                Console.WriteLine("RG do cliente: " + clienteProcurado.GetRg());
                                Console.WriteLine("");
                                Console.WriteLine("Data de nascimento do cliente: " + clienteProcurado.GetDataNacimento());
                                Console.WriteLine("");
                                Console.WriteLine("Codigo do cliente: " + clienteProcurado.GetCodigoCliente());
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.WriteLine("Endereço do cliente: ");
                                Console.WriteLine(""); 
                                clienteProcurado.ExibeEndereco();
                                Console.WriteLine("Pressione qualquer tecla para sair");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                                

                            }
                        }

                    break;
                    case "2":

                        Console.Clear();
                        Console.WriteLine("Digite o nome do funcionario:");
                        nomeProcurado = Console.ReadLine();
                        Console.Clear();
                        foreach (Funcionarios funcionario in listaFuncionarios)
                        {
                            Console.Clear();
                            if(funcionario.GetNome() == nomeProcurado){
                                Funcionarios funcionarioProcurado = funcionario;
                                Console.Clear();
                                Console.WriteLine("DADOS DO FUNCIONARIO:");
                                Console.WriteLine("");
                                Console.WriteLine("Nome do funcionario: " + funcionarioProcurado.GetNome());
                                Console.WriteLine(""); 
                                Console.WriteLine("CPF do funcionario: " + funcionarioProcurado.GetCpf());
                                Console.WriteLine("");
                                Console.WriteLine("RG do funcionario: " + funcionarioProcurado.GetRg());
                                Console.WriteLine("");
                                Console.WriteLine("Data de nascimento do funcionario: " + funcionarioProcurado.GetDataNacimento());
                                Console.WriteLine("");
                                Console.WriteLine("Codigo do funcionario: " + funcionarioProcurado.GetCodigoFuncionario());
                                Console.WriteLine("");
                                Console.WriteLine("Salario do funcionario: " + funcionarioProcurado.GetSalario());
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.WriteLine("Endereço do funcionario: ");
                                Console.WriteLine(""); 
                                funcionarioProcurado.ExibeEndereco();
                                Console.WriteLine("Pressione qualquer tecla para sair");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                                

                            }
                        }


                    break;
                    case "3":

                        Console.Clear();
                        Console.WriteLine("Digite o nome do gerente:");
                        nomeProcurado = Console.ReadLine();
                        Console.Clear();
                        foreach (Gerente gerente in listaGerente)
                        {
                            Console.Clear();
                            if(gerente.GetNome() == nomeProcurado){
                                Gerente gerenteProcurado = gerente;
                                Console.Clear();
                                Console.WriteLine("DADOS DO GERENTE:");
                                Console.WriteLine("");
                                Console.WriteLine("Nome do gerente: " + gerenteProcurado.GetNome());
                                Console.WriteLine(""); 
                                Console.WriteLine("CPF do gerente: " + gerenteProcurado.GetCpf());
                                Console.WriteLine("");
                                Console.WriteLine("RG do gerente: " + gerenteProcurado.GetRg());
                                Console.WriteLine("");
                                Console.WriteLine("Data de nascimento do gerente: " + gerenteProcurado.GetDataNacimento());
                                Console.WriteLine("");
                                Console.WriteLine("Codigo do gerente: " + gerenteProcurado.GetCodigoFuncionario());
                                Console.WriteLine("");
                                Console.WriteLine("Salario do gerente: " + gerenteProcurado.Bonificacao());
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.WriteLine("Endereço do gerente: ");
                                Console.WriteLine(""); 
                                gerenteProcurado.ExibeEndereco();
                                Console.WriteLine("Pressione qualquer tecla para sair");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                                

                            }
                        }

                    break;
                    case "4":

                        Console.Clear();
                        Console.WriteLine("Digite o nome do vendedor:");
                        nomeProcurado = Console.ReadLine();
                        Console.Clear();
                        foreach (Vendedor vendedor in listaVendedor)
                        {
                            Console.Clear();
                            if(vendedor.GetNome() == nomeProcurado){
                                Vendedor vendedorProcurado = vendedor;
                                Console.Clear();
                                Console.WriteLine("DADOS DO VENDEDOR:");
                                Console.WriteLine("");
                                Console.WriteLine("Nome do vendedor: " + vendedorProcurado.GetNome());
                                Console.WriteLine(""); 
                                Console.WriteLine("CPF do vendedor: " + vendedorProcurado.GetCpf());
                                Console.WriteLine("");
                                Console.WriteLine("RG do vendedor: " + vendedorProcurado.GetRg());
                                Console.WriteLine("");
                                Console.WriteLine("Data de nascimento do vendedor: " + vendedorProcurado.GetDataNacimento());
                                Console.WriteLine("");
                                Console.WriteLine("Codigo do vendedor: " + vendedorProcurado.GetCodigoFuncionario());
                                Console.WriteLine("");
                                Console.WriteLine("Salario do vendedor: " + vendedorProcurado.GetSalario());
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.WriteLine("Endereço do vendedor: ");
                                Console.WriteLine(""); 
                                vendedorProcurado.ExibeEndereco();
                                Console.WriteLine("Pressione qualquer tecla para sair");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                                

                            }
                        }

                    break;
                    case "5":

                         Console.Clear();
                        Console.WriteLine("Digite o nome do produto:");
                        nomeProcurado = Console.ReadLine();
                        Console.Clear();
                        foreach (Produtos produto in listaProdutos)
                        {
                            Console.Clear();
                            if(produto.GetNomeProduto() == nomeProcurado){
                                Produtos produtoProcurado = produto;
                                Console.Clear();
                                Console.WriteLine("DADOS DO PRODUTO:");
                                Console.WriteLine("");
                                Console.WriteLine("Nome do produto: " + produtoProcurado.GetNomeProduto());
                                Console.WriteLine(""); 
                                Console.WriteLine("Codigo do produto: " + produtoProcurado.GetCodigo());
                                Console.WriteLine("");
                                Console.WriteLine("Marca do produto: " + produtoProcurado.GetMarca());
                                Console.WriteLine("");
                                Console.WriteLine("Descrição do produto: " + produtoProcurado.GetDescricao());
                                Console.WriteLine("");
                                Console.WriteLine("Valor unitario do produto: " + produtoProcurado.GetValorUnitario());
                                Console.WriteLine("");
                                Console.WriteLine("Pressione qualquer tecla para sair");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                                

                            }
                        }

                    break;
                    default:

                    break;
                }

            break;
            default:

            break;


        }


    }


    public static void Vender(){

        Console.Clear();
        Console.WriteLine("Digite o nome do cliente:");
        string clienteProcurado = Console.ReadLine();
        
        //Variaveis para validacao 
        bool clienteValidacao = false, vendedorValidacao = false, produtoValidacao = false;

        //Venda
        Vendas venda = new Vendas();


        foreach(Cliente cliente in listaClientes){
            if(cliente.GetNome() == clienteProcurado){
                Cliente clienteComprador = cliente;
                venda.SetCliente(clienteComprador);
                clienteValidacao = true;
                break;
            }
            else{
                Console.WriteLine("Não foi possivel localizar o cliente!");
                Thread.Sleep(4000);
                Console.Clear();
                break;
            }
        }
        Console.WriteLine("");
        Console.WriteLine("Digite o nome do vendedor:");
        string vendedorProcurado = Console.ReadLine();
        
        foreach(Vendedor vendedor in listaVendedor){
            if(vendedor.GetNome() == vendedorProcurado){
                Vendedor vendedorCompra = vendedor;
                venda.SetVendedor(vendedorCompra);
                vendedorValidacao = true;
                break;
            }
            else{
                Console.WriteLine("Não foi possivel localizar o vendedor!");
                Thread.Sleep(4000);
                Console.Clear();
                break;
            }
        }

        Console.WriteLine("");
        Console.WriteLine("Digite o nome do produto:");
        string produtoProcurado = Console.ReadLine();
        
        foreach(Produtos produto in listaProdutos){
            if(produto.GetNomeProduto() == produtoProcurado){
                Produtos produtoVenda = produto;
                venda.SetProduto(produtoVenda);
                produtoValidacao = true;
                break;
            }
            else{
                Console.WriteLine("Não foi possivel localizar o produto!");
                Thread.Sleep(4000);
                Console.Clear();
                break;
            }
        }
        
        if(produtoValidacao == true && vendedorValidacao == true && clienteValidacao == true){
            listaVendas.Add(venda);
            Console.Clear();
            Console.WriteLine("Venda efetuada com sucesso!");
            Console.WriteLine("");
            Console.WriteLine("Pressione qualquer tecla para continuar!");
            Console.ReadKey();
        }else{
            Console.Clear();
            Console.WriteLine("Venda cancelada por falta de informações validas!");
            Console.WriteLine("");
            Console.WriteLine("Pressione qualquer tecla para continuar!");
            Console.ReadKey();
        }

    }

    public static void SalvarDadosCliente(Cliente cliente){
            
        listaClientes.Add(cliente);
        //Arquivos txt
        qtde_clientes++;
        
    }

    public static void SalvarDadosProduto(Produtos produto){
            
        listaProdutos.Add(produto);
        //Arquivos txt salver tudo salvar e trazer pelo txt 
        qtde_produtos++;
        
    }
    public static void SalvarDadosGerente(Gerente gerente){
            
        listaGerente.Add(gerente);
        listaFuncionarios.Add(gerente);
        //Arquivos txt salver tudo 
        qtde_gerentes++;
        
    }

    public static void SalvarDadosVendedor(Vendedor vendedor){
            
        listaVendedor.Add(vendedor);
        listaFuncionarios.Add(vendedor);
        //Arquivos txt salver tudo 
        qtde_vendedores++;
        
    }

    public static void Preencherinformacoes(int escolha){
        //Tabela de parametros:
        //1 Cliente
        //2 Produto
        //3 Gerente
        //4 Vendedor
        if(escolha == 1){
            Console.Clear();
            Console.WriteLine("Digite seu estado:");
            string estado = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Digite sua cidade:");
            string cidade = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Digite seu cep:");
            string cep = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Digite seu bairro:");
            string bairro = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Digite seu rua:");
            string rua = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Digite seu numero de residencia:");
            string numeroResidencia = Console.ReadLine();
                        
            Endereco endereco = new Endereco(estado, cidade, cep, bairro, rua, numeroResidencia);

            Console.Clear();
            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Digite seu cpf:");
            string cpf = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Digite seu rg:");
            string rg = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Digite seu data de nascimento:");
            string dataNacimento = Console.ReadLine();

            //Trazer codigo para ca com txt(para saber qual codigo foi o ultimo)


            
            Cliente cliente = new Cliente(cpf, nome, rg, dataNacimento, endereco, codigoCliente);

            Console.Clear();

            SalvarDadosCliente(cliente);

            
            

            Console.WriteLine("Dados cadastrados com sucesso!");      
            Console.WriteLine("");
            Console.WriteLine("Codigo do cliente: " + codigoCliente);
            Console.WriteLine("");
            Console.WriteLine("Pressione qualquer tecla para continuar!");
            Console.ReadKey();
            Console.Clear();

            codigoCliente++;
            //Salvar o numero no txt
        }
        else if(escolha == 2){
            Console.Clear();
            Console.WriteLine("Digite o nome do produto:");
            string nomeProduto = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Digite a marca do produto:");
            string marca = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Digite uma descrição para o produto:");
            string descricao = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Digite o valor unitario do produto:");
            double valorUnitario = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            //Trazer codigo para ca com txt(para saber qual codigo foi o ultimo)

            Produtos produto = new Produtos(nomeProduto,codigoProduto, marca, descricao, valorUnitario, codigoProduto);

            Console.Clear();

            SalvarDadosProduto(produto);

            

            Console.WriteLine("Dados cadastrados com sucesso!");      
            Console.WriteLine("");
            Console.WriteLine("Codigo do produto: " + codigoProduto);
            Console.WriteLine("");
            Console.WriteLine("Pressione qualquer tecla para continuar!");
            Console.ReadKey();
            Console.Clear();

            codigoProduto++;
            //Salvar o numero no txt

                        
        }
        else if(escolha == 3){
            Console.Clear();
            Console.WriteLine("Digite seu estado:");
            string estado = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Digite sua cidade:");
            string cidade = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Digite seu cep:");
            string cep = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Digite seu bairro:");
            string bairro = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Digite seu rua:");
            string rua = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Digite seu numero de residencia:");
            string numeroResidencia = Console.ReadLine();

            Endereco endereco = new Endereco(estado, cidade, cep, bairro, rua, numeroResidencia);

            Console.Clear();
            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Digite seu cpf:");
            string cpf = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Digite seu rg:");
            string rg = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Digite seu data de nascimento:");
            string dataNacimento = Console.ReadLine();

            //Trazer codigo para ca com txt(para saber qual codigo foi o ultimo)

            Gerente gerente = new Gerente(cpf, nome, dataNacimento, rg, endereco, codigoFuncionario);

            Console.Clear();

            SalvarDadosGerente(gerente);

            

            Console.WriteLine("Dados cadastrados com sucesso!");      
            Console.WriteLine("");
            Console.WriteLine("Codigo do funcionario: " + codigoFuncionario);
            Console.WriteLine("");
            Console.WriteLine("Pressione qualquer tecla para continuar!");
            Console.ReadKey();
            Console.Clear();

            codigoFuncionario++;
            //Salvar o numero no txt
        }
        else if(escolha == 4){
            Console.Clear();
            Console.WriteLine("Digite seu estado:");
            string estado = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Digite sua cidade:");
            string cidade = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Digite seu cep:");
            string cep = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Digite seu bairro:");
            string bairro = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Digite seu rua:");
            string rua = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Digite seu numero de residencia:");
            string numeroResidencia = Console.ReadLine();

            Endereco endereco = new Endereco(estado, cidade, cep, bairro, rua, numeroResidencia);

            Console.Clear();
            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Digite seu cpf:");
            string cpf = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Digite seu rg:");
            string rg = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Digite seu data de nascimento:");
            string dataNacimento = Console.ReadLine();

            //Trazer codigo para ca com txt(para saber qual codigo foi o ultimo)

            Vendedor vendedor = new Vendedor(cpf, nome, dataNacimento, rg, endereco, codigoFuncionario);

            Console.Clear();

            SalvarDadosVendedor(vendedor);

            Console.WriteLine("Dados cadastrados com sucesso!");      
            Console.WriteLine("");
            Console.WriteLine("Codigo do funcionario: " + codigoFuncionario);
            Console.WriteLine("");
            Console.WriteLine("Pressione qualquer tecla para continuar!");
            Console.ReadKey();
            Console.Clear();


            codigoFuncionario++;
            //Salvar o numero no txt
        }
    }

    
}
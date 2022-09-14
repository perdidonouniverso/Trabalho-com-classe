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

    //Variaveis para controle de quantidade
    static int qtde_clientes;
    static int qtde_produtos;

    //Variaveis para controle de codigo
    static int codigoCliente;
    static int codigoProduto;



    public static void Main(string[] args){
        //Variavel para escolha do Usuario:
        string escolha;
        
        
        Console.WriteLine("Seja bem-vindo ao programa!");
        Thread.Sleep(3000);
        Console.Clear();
    
        do{

            Console.WriteLine("SISTEMA DE CADASTRO E VENDAS");
            Console.WriteLine("");
            Console.WriteLine("1-Cadastrar    2-Vender");
            Console.WriteLine("3-Sair");

            escolha = Console.ReadLine();

            switch(escolha){
                case "1":
                    Console.Clear();
                    Console.Clear();
                    Console.WriteLine("CADASTROS");
                    Console.WriteLine("");
                    Console.WriteLine("1-Consultar e modificar cadastros");
                    Console.WriteLine("2-Cadastrar cliente");
                    Console.WriteLine("3-Cadastrar produtos");
                    Console.WriteLine("4-Cadastrar gerente");
                    Console.WriteLine("5-Cadastrar vendedor");

                    //Variavel para escolha de usiuario:
                    string escolhaUser;

                    escolhaUser = Console.ReadLine();

                    switch(escolhaUser){
                        case "1":



                        break;
                        case "2":

                            Preencherinformacoes(1);

                        break;

                    }





                break;
                case "2":

                    //Vender

                break;
                default:
                    Console.Clear();
                break;


            }
           


        }while(escolha != "3");


    }



    public static void SalvarDadosCliente(Cliente cliente){
            
        listaClientes.Add(cliente);
        //Arquivos txt
        qtde_clientes++;
        
    }

    public static void SalvarDadosProduto(Produtos produto){
            
        listaProdutos.Add(produto);
        //Arquivos txt salver tudo 
        qtde_produtos++;
        
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

            codigoCliente++;
            //Salvar o numero no txt
            

            Console.WriteLine("Dados cadastrados com sucesso!");      
            Console.WriteLine("");
            Console.WriteLine("Codigo do cliente: " + codigoCliente);
            Console.WriteLine("");
            Console.WriteLine("Pressione qualquer tecla para continuar!");
            Console.ReadKey();
            Console.Clear();
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

            Produtos produto = new Produtos(nomeProduto,codigoProduto, marca, descricao, valorUnitario);

            Console.Clear();

            SalvarDadosProduto();

            codigoCliente++;
            //Salvar o numero no txt

                        
        }
    }

    
}
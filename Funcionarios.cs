namespace POO{
    public class Funcionarios{
        private string cpf= "";
        private string nome= "";
        private string rg= "";
        private string dataNacimento= "";
        private Endereco endereco;
        private double salario = 1800.00;
        private int codigoFuncionario;


        public Funcionarios(string cpf, string nome, string dataNacimento, string rg, Endereco endereco, int codigoFuncionario){
            this.cpf = cpf;
            this.nome = nome;
            this.dataNacimento = dataNacimento;
            this.rg = rg;
            this.endereco = endereco;
            this.codigoFuncionario = codigoFuncionario;

        }

        public void ExibeEndereco(){
            Console.WriteLine("Estado : " + endereco.GetEstado());
            Console.WriteLine("Cep : " + endereco.GetCep());
            Console.WriteLine("Cidade : " + endereco.GetCidade());
            Console.WriteLine("Bairro: " + endereco.GetBairro());
            Console.WriteLine("Rua: " + endereco.GetRua());
            Console.WriteLine("Número da residencia: " + endereco.GetNumeroResidencia());

        }

        public int GetCodigoFuncionario(){
            return codigoFuncionario;
        } 
        public void SetCodigoFuncionario(int codigoFuncionario){
            this.codigoFuncionario = codigoFuncionario;
        }

        public double GetSalario(){
            return salario;
        } 
        public void SetSalario(double salario){
            this.salario = salario;
        }

        public string GetCpf(){
            return cpf;
        } 
        public void SetCpf(string cpf){
            this.cpf = cpf;
        }
        public string GetNome(){
            return nome;
        }
        public void SetNome(string nome){
            this.nome = nome;
        }
        public string GetRg(){
            return rg;
        }
        public void SetRg(string rg){
            this.rg = rg;
        }
        public string GetDataNacimento(){
            return dataNacimento;
        }
        public void SetDataNacimento(string dataNacimento){
            this.dataNacimento = dataNacimento;
	    }
        public Endereco GetEndereco(){
            return endereco;
        }
        public void SetEndereco(Endereco endereco){
            this.endereco = endereco;
	    }

        //Bonificação para todos os funcionarios 
        public virtual double Bonificacao(){
            return salario * 0.25 + (salario);
        }
    }

}
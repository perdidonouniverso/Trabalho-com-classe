namespace POO{
  
    public class Cliente{

        private string cpf= "";
        private string nome= "";
        private string rg= "";
        private string dataNacimento= "";
        private Endereco endereco;
        private int codigoCliente;




        
        public Cliente(string cpf, string nome, string rg, string dataNacimento, Endereco endereco, int codigoCliente){
            this.cpf = cpf;
            this.nome = nome;
            this.rg = rg;
            this.dataNacimento = dataNacimento;
            this.endereco = endereco;


        }

        public int GetCodigoCliente(){
            return codigoCliente;
        } 
        public void SetCodigoCliente(int codigoCliente){
            this.codigoCliente = codigoCliente;
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
     }
}
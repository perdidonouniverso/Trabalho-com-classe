namespace POO{
    public class Produtos{

        private string nomeProduto = "";
        private string marca = "";
        private string descricao = "";
        private double valorUnitario = 0;
        private int codigoProduto;

        public Produtos(string nomeProduto, int codigo, string marca, string descricao, double valorUnitario, int codigoProduto){
            this.nomeProduto = nomeProduto;
            this.marca = marca;
            this.descricao = descricao;
            this.valorUnitario = valorUnitario;
            this.codigoProduto = codigoProduto;
        }

        public double GetValorUnitario(){
            return valorUnitario;
        } 
        public void SetValorUnitario(double valorUnitario){
            this.valorUnitario = valorUnitario;
        }

        public double GetCodigo(){
            return codigoProduto;
        } 
        public void SetCodigo(int codigoProduto){
            this.codigoProduto = codigoProduto;
        }

        

        public string GetNomeProduto(){
            return nomeProduto;
        } 
        public void SetNomeProduto(string nomeProduto){
            this.nomeProduto = nomeProduto;
        }

        public string GetMarca(){
            return marca;
        } 
        public void SetMarca(string marca){
            this.marca = marca;
        }


        public string GetDescricao(){
            return descricao;
        } 
        public void SetDescricao(string descricao){
            this.descricao = descricao;
        }

    }
}
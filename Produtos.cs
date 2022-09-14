namespace POO{
    public class Produtos{

        private string nomeProduto = "";
        private int codigo;
        private string marca = "";
        private string descricao = "";
        private double valorUnitario = 0;

        public Produtos(string nomeProduto, int codigo, string marca, string descricao, double valorUnitario){
            this.nomeProduto = nomeProduto;
            this.codigo = codigo;
            this.marca = marca;
            this.descricao = descricao;
            this.valorUnitario = valorUnitario;
        }

        public double GetValorUnitario(){
            return valorUnitario;
        } 
        public void SetValorUnitario(double valorUnitario){
            this.valorUnitario = valorUnitario;
        }

        public int GetCodigo(){
            return codigo;
        } 
        public void SetCodigo(int codigo){
            this.codigo = codigo;
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
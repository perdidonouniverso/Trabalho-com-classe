namespace POO{
    public class Vendas{
        private Cliente cliente;

        private Vendedor vendedor;

        private Produtos produto;

        
        public Cliente GetCliente(){
            return cliente;
        } 
        public void SetCliente(Cliente cliente){
            this.cliente = cliente;
        }
        public Vendedor GetVendedor(){
            return vendedor;
        }
         public void SetVendedor(Vendedor vendedor){
            this.vendedor = vendedor;
        }
        public Produtos GetProduto(){
            return produto;
        }
        public void SetProduto(Produtos produto){
            this.produto = produto;
        }
    }
}
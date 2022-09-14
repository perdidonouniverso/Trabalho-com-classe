namespace POO{


    public class Endereco{
        private string estado = "";
        private string cidade = "";
        private string cep = "";
        private string bairro = "";
        private string rua = "";
        private string numeroResidencia = "";

        public Endereco(string estado, string cidade, string cep, string bairro, string rua, string numeroResidencia){
            this.estado = estado;
            this.cidade = cidade;
            this.cep = cep;
            this.bairro = bairro;
            this.rua = rua;
            this.numeroResidencia = numeroResidencia;
        }

        public string GetEstado(){
            return estado;
        } 
        public void SetEstado(string estado){
            this.estado = estado;
        }

        public string GetCidade(){
            return cidade;
        } 
        public void SetCidade(string cidade){
            this.cidade = cidade;
        }

        public string GetCep(){
            return cep;
        } 
        public void SetCep(string cep){
            this.cep = cep;
        }

        public string GetBairro(){
            return bairro;
        } 
        public void SetBairro(string bairro){
            this.bairro = bairro;
        }

        public string GetRua(){
            return rua;
        } 
        public void SetRua(string rua){
            this.rua = rua;
        }

        public string GetNumeroResidencia(){
            return numeroResidencia;
        } 
        public void SetNumeroResidencia(string numeroResidencia){
            this.numeroResidencia = numeroResidencia;
        }


    }
}
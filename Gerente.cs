namespace POO{
    public class Gerente:Funcionarios{

        public Gerente(string cpf, string nome, string dataNacimento, string rg, Endereco endereco, int codigoFuncionario):base(cpf, nome, dataNacimento, rg, endereco, codigoFuncionario){
            
        }
        

        public override double Bonificacao()
        {
            return base.Bonificacao() * 0.10 + (base.Bonificacao());
        }
        
    }

}
namespace POO{
    public class Gerente:Funcionarios{
        public override double Bonificacao()
        {
            return base.Bonificacao() * 0.10 + (base.Bonificacao());
        }
        
    }

}
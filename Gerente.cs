namespace PracticeAula5._1._1
{
    internal class Gerente : Funcionario
    {
        public Gerente(string nome, string sobrenome, double valorHora, string turno) : base(nome, sobrenome, valorHora)
        {
            Turno = turno;
        }
        public string Turno { get; private set; }

        public override void ExibirDados()
        {
            base.ExibirDados();
            Console.WriteLine("##### INFORMAÇÕES ADICIONAIS: ######");
            Console.WriteLine($"Turno do Gerente: {Turno}");
            Console.WriteLine($"Salário com adicional: {CalcSalarioAdicional():C} \n");
        }
        public override double CalcSalarioAdicional()
        {
            double salarioBase = base.CalcSalarioBase();
            if (Turno.ToLower() == "noite")
            {
                return salarioBase * 1.1;
            }
            else
            {
                return salarioBase;
            }
        }

        public override string GetTipoFuncionario()
        {
            return "Gerente";
        }
    }
}

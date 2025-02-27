namespace PracticeAula5._1._1
{
    internal class Vendedor : Funcionario
    {
        public Vendedor(string nome, string sobrenome, double valorHora, int numVendas) : base(nome, sobrenome, valorHora)
        {
            NumVendas = numVendas;
        }
        public int NumVendas { get; set; }

        public override void ExibirDados()
        {
            base.ExibirDados();
            Console.WriteLine("##### INFORMAÇÕES ADICIONAIS: ######");
            Console.WriteLine($"Número de vendas: {NumVendas}");
            Console.WriteLine($"Salário com adicional: {CalcSalarioAdicional():C} \n");
        }
        public override double CalcSalarioAdicional()
        {
            double salarioBase = base.CalcSalarioBase();
            return salarioBase + salarioBase * NumVendas / 1000;
        }

        public override string GetTipoFuncionario()
        {
            return "Vendedor";
        }
    }
}

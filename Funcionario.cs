namespace PracticeAula5._1._1
{
    internal class Funcionario
    {
        public Funcionario(string nome, string sobrenome, double valorHora)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            ValorHora = valorHora;
        }

        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public double ValorHora { get; private set; }

        public virtual void ExibirDados()
        {
            Console.WriteLine("###### INFORMAÇÕES BÁSICAS: #######");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Sobrenome: {Sobrenome}");
            Console.WriteLine($"Valor Hora: {ValorHora:C}");
            Console.WriteLine($"Tipo de Funcionário: {GetTipoFuncionario()}");
            Console.WriteLine($"Salário Base Mensal: {CalcSalarioBase():C}");
        }
        public virtual double CalcSalarioBase()
        {
            return ValorHora * 160;
        }

        public virtual double CalcSalarioAdicional()
        {
            return CalcSalarioBase();
        }

        public virtual string GetTipoFuncionario()
        {
            return "Funcionário";
        }
    }
}


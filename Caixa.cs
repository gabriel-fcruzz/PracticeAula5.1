using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAula5._1._1
{
    internal class Caixa : Funcionario
    {
        public Caixa(string nome, string sobrenome, double valorHora, double valorVendas) : base(nome, sobrenome, valorHora)
        {
            ValorVendas = valorVendas;
        }
        public double ValorVendas { get; private set; }

        public override void ExibirDados()
        {
            base.ExibirDados();
            Console.WriteLine("##### INFORMAÇÕES ADICIONAIS: ######");
            Console.WriteLine($"Valor das vendas: {ValorVendas:C}");
            Console.WriteLine($"Salário com adicional: {CalcSalarioAdicional():C} \n");
        }

        public override double CalcSalarioAdicional()
        {
            double salarioBase = base.CalcSalarioBase();
            return salarioBase + ValorVendas * 0.01;
        }

        public override string GetTipoFuncionario()
        {
            return "Caixa";
        }
    }
}

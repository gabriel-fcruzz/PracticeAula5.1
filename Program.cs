namespace PracticeAula5._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var colecaoFuncionarios = new List<Funcionario>
        {
            new Vendedor("Gabriel", "Cruz", 50, 52),
            new Vendedor("Guilherme", "Dufes", 50, 53),
            new Vendedor("Gabriel", "Santos", 50, 54),
            new Vendedor("Henrique", "Goldstein", 50, 55),
            new Caixa("João", "Henrique", 50, 75670),
            new Caixa("Maria", "Lobo", 50, 35867),
            new Caixa("Carlos", "Alberto", 50, 15697),
            new Caixa("Bruno", "Henrique", 50, 25367),
            new Gerente("Júlio", "Guimarães", 150, "Manhã"),
            new Gerente("Thiago", "Vieira", 150, "Noite")
        };
            foreach (var funcionario in colecaoFuncionarios)
            {
                funcionario.ExibirDados();
            }
        }
    }
}

using System;
using BBank.Funcionarios;
using BBank.Sistemas;

namespace BBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //MostrarAuteticacao();
            //MostrarBonificacoes();
            //MostrarNovosSalarios();

            Console.ReadLine();
        }
        public static void MostrarAuteticacao()
        {
            SistemaInterno sistema = new SistemaInterno();
            
            Diretor roberta = new Diretor("000.000.000-00");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            sistema.Logar(roberta, "456");
            Console.WriteLine(roberta.Nome);

            GerenteDeConta bruno = new GerenteDeConta("111.111.111-11");
            bruno.Nome = "Bruno";
            bruno.Senha = "456";
            
            sistema.Logar(bruno, "456");
            Console.WriteLine(bruno.Nome);

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "789";

            sistema.Logar(parceiro, "789");
            Console.WriteLine("Parceiro");
        }

        public static void MostrarBonificacoes() 
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Auxiliar carlos = new Auxiliar("000.000.000-00");
            carlos.Nome = "Carlos";
            Console.WriteLine(carlos.Nome);
            Console.WriteLine("Salário: " + carlos.Salario);
            gerenciador.Resgistrar(carlos);
            Console.WriteLine("Bonificação: " + carlos.GetBonificacao());
            Console.WriteLine();

            Diretor roberta = new Diretor("111.111.111-11");
            roberta.Nome = "Roberta";
            Console.WriteLine(roberta.Nome);
            Console.WriteLine("Salário: " + roberta.Salario);
            gerenciador.Resgistrar(roberta);
            Console.WriteLine("Bonificação: " + roberta.GetBonificacao());
            Console.WriteLine();

            GerenteDeConta bruno = new GerenteDeConta("222.222.222-22");
            bruno.Nome = "Bruno";
            Console.WriteLine(bruno.Nome);
            Console.WriteLine("Salário: " + bruno.Salario);
            gerenciador.Resgistrar(bruno);
            Console.WriteLine("Bonificação: " + bruno.GetBonificacao());
            Console.WriteLine();

            Designer julia = new Designer("333.333.333-33");
            julia.Nome = "Roberta";
            Console.WriteLine(julia.Nome);
            Console.WriteLine("Salário: " + julia.Salario);
            gerenciador.Resgistrar(julia);
            Console.WriteLine("Bonificação: " + julia.GetBonificacao());
            Console.WriteLine();

            Console.WriteLine("Qtd de funcionários: " + Funcionario.TotalDeFuncionarios);
            Console.WriteLine("Total das Bonificações: " + gerenciador.GetTotalBonificacao());
        }

        public static void MostrarNovosSalarios()
        {
            Auxiliar carlos = new Auxiliar("000.000.000-00");
            carlos.Nome = "Carlos";
            Console.WriteLine(carlos.Nome);
            Console.WriteLine("Salário inicial: " + carlos.Salario);
            carlos.AumentarSalario();
            Console.WriteLine("Salário final: " + carlos.Salario);
            Console.WriteLine();

            Diretor roberta = new Diretor("111.111.111-11");
            roberta.Nome = "Roberta";
            Console.WriteLine(roberta.Nome);
            Console.WriteLine("Salário inicial: " + roberta.Salario);
            roberta.AumentarSalario();
            Console.WriteLine("Salário final: " + roberta.Salario);
            Console.WriteLine();

            GerenteDeConta bruno = new GerenteDeConta("222.222.222-22");
            bruno.Nome = "Bruno";
            Console.WriteLine(bruno.Nome);
            Console.WriteLine("Salário inicial: " + bruno.Salario);
            bruno.AumentarSalario();
            Console.WriteLine("Salário final: " + bruno.Salario);
            Console.WriteLine();

            Designer julia = new Designer("333.333.333-33");
            julia.Nome = "Julia";
            Console.WriteLine(julia.Nome);
            Console.WriteLine("Salário inicial: " + julia.Salario);
            julia.AumentarSalario();
            Console.WriteLine("Salário final: " + julia.Salario);
            Console.WriteLine();

            Console.WriteLine("Qtd de funcionários: " + Funcionario.TotalDeFuncionarios);
        }
    }
}

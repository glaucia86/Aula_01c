using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Model;

namespace Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Dados do Funcionario
            Funcionario func = new Funcionario();

            func.IdFuncionario = 1;
            func.Nome = "Glaucia Lemos";
            func.Salario = 4000;

            Console.WriteLine("----------- Dados do Funcionário -------------- ");
            Console.WriteLine("Id do Funcionário..........: " + func.IdFuncionario);
            Console.WriteLine("Nome do Funcionário........: " + func.Nome);
            Console.WriteLine("Salário....................: R$ " + func.Salario);

            #endregion

            #region Dados do Estagiário
            Estagiario est = new Estagiario();
            est.IdFuncionario = 2;
            est.Nome = "Luciano Galdino";
            est.Salario = 1500;
            est.Tipo = "Desenvolvedor";

            Console.WriteLine("\n----------- Dados do Estagiário -------------- ");
            Console.WriteLine("Id do Estagiário........: " + est.IdFuncionario);
            Console.WriteLine("Nome do Estagiário......: " + est.Nome);
            Console.WriteLine("Salário.................: R$ " + est.Salario);
            Console.WriteLine("Tipo....................: " + est.Tipo);

            #endregion

            #region Dados do Terceirizado
            Terceirizado terc = new Terceirizado();
            terc.IdFuncionario = 3;
            terc.Nome = "Jake Lemos";
            terc.Salario = 3500;
            terc.Categoria = "Suporte";

            Console.WriteLine("\n----------- Dados do Terceirizado -------------- ");
            Console.WriteLine("Id do Terceirizado.............: " + terc.IdFuncionario);
            Console.WriteLine("Nome...........................: " + terc.Nome);
            Console.WriteLine("Salário........................: " + terc.Salario);
            Console.WriteLine("Categoria......................: " + terc.Categoria);

            #endregion

            Console.ReadKey();


        }
    }
}

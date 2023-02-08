using Projeto02.Entities;
using Projeto02.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02.Controllers
{
    public class FuncionarioController
    {
        public void CadastrarFuncionario()
        {
            try
            {
                Console.WriteLine("\n *** Cadastro de funcionário ***");

                #region Capturar dados do funcionário

                var funcionario = new Funcionario();
                funcionario.Id = Guid.NewGuid();

                Console.Write("Nome do funcionário.....: ");
                funcionario.Nome = Console.ReadLine();

                Console.Write("Data de Nascimento......: ");
                funcionario.DataNascimento = DateTime.Parse(Console.ReadLine());

                Console.Write("Cpf.....................: ");
                funcionario.Cpf = Console.ReadLine();

                Console.Write("Matrícula...............: ");
                funcionario.Matricula = Console.ReadLine();

                Console.Write("Data de Admissão........: ");
                funcionario.DataAdmissao = DateTime.Parse(Console.ReadLine());

                #endregion

                #region Capturando dados do setor do funcionário

                funcionario.Setor = new Setor();
                funcionario.Setor.Id = Guid.NewGuid();

                Console.Write("Sigla do setor.........: ");
                funcionario.Setor.Sigla = Console.ReadLine();

                Console.Write("Descrição do setor.....: ");
                funcionario.Setor.Descricao = Console.ReadLine();

                #endregion

                #region Exportando os dados para o arquivo

                Console.Write("\n Informe 1 (CSV) ou 2 (TXT) ");
                var opcao = int.Parse(Console.ReadLine());

                FuncionarioRepository funcionarioRepository = null;

                switch (opcao)
                {
                    case 1:
                        funcionarioRepository = new FuncionarioRepositoryCSV();
                        break;

                    case 2:
                        funcionarioRepository = new FuncionarioRepositoryTXT();
                        break;

                    default:
                        Console.WriteLine("\n Formato inválido!");
                        break;
                }

                if (funcionarioRepository != null)
                {
                    funcionarioRepository.ExportarDados(funcionario);

                    Console.WriteLine("\n Dados gravados com sucesso!");
                }

                #endregion

            }
            catch (Exception e)
            {
                Console.WriteLine($"\n Falha ao cadastrar: {e.Message}");
            }
        }
    }
}
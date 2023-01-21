using Projeto02.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02.Repositories
{
    public class FuncionarioRepositoryTXT : FuncionarioRepository
    {
        public override void ExportarDados(Funcionario funcionario)
        {
            #region Definindo nome e local do arquivo

            var path = "c:\\Temp\\funcionarios.txt";

            #endregion

            #region Gravando conteúdo do arquivo

            using (var streamWriter = new StreamWriter(path, true))
            {
                streamWriter.WriteLine($"Id do funcionário................: {funcionario.Id}");
                streamWriter.WriteLine($"Nome do funcionário..............: {funcionario.Nome}");
                streamWriter.WriteLine($"Data de Nascimento do funcionário: {funcionario.DataNascimento.ToString("dd/MM/yyyy")}");
                streamWriter.WriteLine($"Cpf do funcionário...............: {funcionario.Cpf}");
                streamWriter.WriteLine($"Matrícula do funcionário.........: {funcionario.Matricula}");
                streamWriter.WriteLine($"Data de admissãp do funcionário..: {funcionario.DataAdmissao.ToString("dd/MM/yyyy")}");

                streamWriter.WriteLine($"Id do Setor......................: {funcionario.Setor.Id}");
                streamWriter.WriteLine($"Sigla do Setor...................: {funcionario.Setor.Sigla}");
                streamWriter.WriteLine($"Descrição do Setor:..............: {funcionario.Setor.Descricao}");
                streamWriter.WriteLine("\n");
            }
            #endregion
        }
    }
}
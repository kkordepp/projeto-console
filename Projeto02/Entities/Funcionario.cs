using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02.Entities
{
    public class Funcionario : Pessoa
    {
        #region Propriedades

        public String Cpf { get; set; }
        public String Matricula { get; set; }
        public DateTime DataAdmissao { get; set; }

        #endregion

        #region Vinculos / Associações

        public Setor Setor { get; set; }

        #endregion
    }
}
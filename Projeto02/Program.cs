// localização da classe dentro do projeto
using Projeto02.Controllers;
using Projeto02.Entities;

namespace Projeto02
{
    // definição da classe
    public class Program
    {
        // método para executar o conteúdo da classe
        // ponto de inicialização (Public Static Void Main)
        public static void Main(string[] args)
        {
            // instânciando classe de controle (FuncionarioController)
            var funcionarioController = new FuncionarioController();

            // executar método para cadastrar funcionário
            funcionarioController.CadastrarFuncionario();

            // pausando prompt
            Console.ReadKey();
        }
    }
}
﻿using Projeto02.Controllers;
using Projeto02.Entities;

namespace Projeto02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var funcionarioController = new FuncionarioController();

            funcionarioController.CadastrarFuncionario();

            Console.ReadKey();
        }
    }
}
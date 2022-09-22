using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.LSP
{
    public class CEO : FuncionarioBase
    {
        public CEO(string nome)
        {

        }

        public void DemitirFuncionario(Funcionario funcionario)
        {
            Console.WriteLine($"{funcionario.Nome} está demitido!");
        }
    }
}

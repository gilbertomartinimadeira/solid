using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.LSP
{
    public class Funcionario : FuncionarioBase, IGerenciavel
    {
        public Funcionario(string nome)
        {
            Nome = nome;
        }


        public Gerente Gerente { get; protected set; }


        public void AtribuirGerente(Gerente gerente)
        {
            Gerente = gerente;
        }
    }
}

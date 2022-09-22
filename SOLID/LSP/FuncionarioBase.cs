using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.LSP
{
    public abstract class FuncionarioBase
    {
        public string Nome { get; protected set; }
        public decimal Salario { get; protected set; }
        public virtual void CalcularPreviaSalario(decimal fator)
        {
            if (fator > 3) throw new ArgumentException("Fator não pode ser maior que 3");
            Salario = 40.40m * (fator * 2) * DateTime.Now.Day;
        }

    }
}

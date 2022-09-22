using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.LSP
{
    public class Gerente : Funcionario, IGestor
    {
        public Gerente(string nome) : base(nome)
        {

        }
        public override void CalcularPreviaSalario(decimal fator)
        {
            Salario = 80.40m * fator * DateTime.Now.Day;
        }

        public void ExibirRelatorioDeProdutividade()
        {
            return;
        }
    }

    // interface contravariante
    public interface ITest<in T> where T : Gerente
    {
        void FazAlgo(T t);
        //T RetornaAlgo();

    }
}

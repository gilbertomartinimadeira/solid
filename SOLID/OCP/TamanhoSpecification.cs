using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.OCP
{
    public class TamanhoSpecification : ISpecification<Produto>
    {
        private readonly Tamanho _tamanho;

        public TamanhoSpecification(Tamanho tamanho)
        {
            _tamanho = tamanho;
        }

        public bool IsSatisfiedBy(Produto t) => t.Tamanho == _tamanho;
    }
}

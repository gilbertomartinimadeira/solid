using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.OCP
{
    public class CorSpecification : ISpecification<Produto>
    {
        private readonly Cor _cor;

        public CorSpecification(Cor cor)
        {
            _cor = cor;
        }

        public bool IsSatisfiedBy(Produto t) => t.Cor == _cor;
    }
}

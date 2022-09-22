using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.OCP
{
    public class FiltroOtimizado<T> : IFilter<T>
    {
        public IEnumerable<T> Filtrar(IEnumerable<T> itens, ISpecification<T> specification)
        {
            foreach (var i in itens) if (specification.IsSatisfiedBy(i)) yield return i;
        }
    }
}

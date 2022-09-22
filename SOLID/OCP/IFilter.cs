using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.OCP
{
    public interface IFilter<T>
    {
        IEnumerable<T> Filtrar(IEnumerable<T> itens, ISpecification<T> specification);
    }
}

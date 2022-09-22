using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.OCP
{
    public interface ISpecification<T>
    {
        bool IsSatisfiedBy(T t);
    }
}

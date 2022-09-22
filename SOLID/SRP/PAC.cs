using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.SRP
{
    public class PAC
    {
        public int NumeroPac { get; set; }
        public DateTime DataCriacao { get; set; }

        public DateTime DataUltimaAlteracao { get; set; }

        public bool IsValid()
        {
            return NumeroPac > 0;
        }
    }
}
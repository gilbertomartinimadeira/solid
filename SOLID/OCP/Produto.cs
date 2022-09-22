using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.OCP
{
    public class Produto
    {
        public string Nome { get; set; }
        public Tamanho Tamanho { get; set; }
        public Cor Cor { get; set; }
        public decimal Valor { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.OCP
{
    public class FiltroDeProduto
    {
        public IEnumerable<Produto> FiltrarPorTamanho(IEnumerable<Produto> produtos, Tamanho tamanho)
        {
            foreach (var p in produtos)
            {
                if (p.Tamanho == tamanho) yield return p;
            }
        }

        public IEnumerable<Produto> FiltrarPorCor(IEnumerable<Produto> produtos, Cor cor)
        {
            foreach (var p in produtos)
            {
                if (p.Cor == cor) yield return p;
            }
        }
    }
}

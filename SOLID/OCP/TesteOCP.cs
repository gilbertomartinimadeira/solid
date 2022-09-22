using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.OCP
{
    class TesteOCP
    {
        public void Executar() 
        {
            var produtos = new List<Produto> {
                new Produto{ Nome = "Televisão", Cor = Cor.Prata, Tamanho = Tamanho.Grande},
                new Produto{ Nome = "Celular", Cor = Cor.Preto, Tamanho = Tamanho.Pequeno},
                new Produto{ Nome = "Monitor", Cor = Cor.Branco, Tamanho = Tamanho.Grande},
                new Produto{ Nome = "Notebook", Cor = Cor.Azul, Tamanho = Tamanho.Medio},
                new Produto{ Nome = "Geladeira", Cor = Cor.Verde, Tamanho = Tamanho.Grande},
            };

            var filtroOtimizado = new FiltroOtimizado<Produto>();

            //var produtosBrancos = filtroOtimizado.Filtrar(produtos, new CorSpecification(Cor.Branco));
            var produtosPequenos = filtroOtimizado.Filtrar(produtos, new TamanhoSpecification(Tamanho.Pequeno));

            foreach (var p in produtosPequenos)
            {
                System.Console.WriteLine($"Nome do Produto: {p.Nome}");
            }



            //var filtro = new FiltroDeProduto();

            //var produtosDeTamanhoGrande = filtro.FiltrarPorTamanho(produtos, Tamanho.Grande);

            //foreach (var p in produtosDeTamanhoGrande)
            //{
            //    System.Console.WriteLine($"Nome do Produto: {p.Nome}");
            //}

            //var produtosVerdes = filtro.FiltrarPorCor(produtos, Cor.Verde);

            //foreach (var p in produtosVerdes)
            //{
            //    System.Console.WriteLine($"Nome do Produto: {p.Nome}");
            //}
        }
    }
    
}

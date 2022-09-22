using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.SRP
{
    public class JogadorDeFutebol
    {
        public int Idade { get; set; }
        public string Nome { get; set; }
        public string Posicao { get; set; }

        public bool PosseDeBola { get; set; }

        //POCO  --> Plain Old C# Object

        public void PassarABola(JogadorDeFutebol jogador)
        {
            this.PosseDeBola = false;
            jogador.PosseDeBola = true;

            Nome = "FulanoQuePassouABola";
        }

        public void ChutarAGol() { }
        public void Correr() { }
        public void CobrarFalta() { }
        public void FazerMassagemNoJogadorContundido() { }

    }
}
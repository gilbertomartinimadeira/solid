using System.Collections.Generic;

namespace SOLID.SRP
{
    public class Diario
    {
        public List<string> entradas = new List<string>();

        public void AdicionarEntrada(string texto)
        {
            entradas.Add(texto);
        }

        public void RemoverEntrada(int index)
        {
            entradas.RemoveAt(index);
        }

        public override string ToString()
        {
            return string.Join("\r\n", this.entradas);
        }
    }
}
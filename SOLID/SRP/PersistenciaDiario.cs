using System.IO;

namespace SOLID.SRP
{

    public class PersistenciaDeDiario
    {
        public void EscreverParaArquivo(string nomeArquivo, Diario diario)
        {
            File.WriteAllText(nomeArquivo, diario.ToString());
        }
    }
}






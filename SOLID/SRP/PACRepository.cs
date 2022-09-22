using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.SRP
{
    public class PACRepository
    {
        public void Salvar(PAC pac)
        {
            var existePac = ObterPacPorNumero(123);

            if (existePac == null) { }
        }
        // INSERT INTO PAC (NUMERO_PAC, DATA_CRIACAO) .......

        public PAC ObterPacPorNumero(int numeroPac)
        {
            return new PAC();
        }
    }
}
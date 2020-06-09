using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Beneficiario
    {
        public Subsidio Subsidio { get; set; }
        public Integrante Integrante { get; set; }
        public decimal BonoMercado { get; set; }
        public decimal Beca { get; set; }

        public Beneficiario()
        {

        }


        public void AgregarSubSidio(Subsidio subsidio)
        {
            Subsidio = subsidio;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Integrante 
    {
        public string primerNombre { get; set; }
        public string segundoNombre { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }
        public string Cedula { get; set; }
        public string DireccionVivienda { get; set; }
        public string Discapacidad { get; set; }
        public int Edad { get; set; }
        public Subsidio Subsidio { get; set; }
        public Etnia Etnia { get; set; }


        public Integrante()
        {

        }

        public void AgregarEtnia(Etnia etnia)
        {
            Etnia = etnia;
        }

        public void AgregarSubsidio (Subsidio subsidio)
        {
            Subsidio = subsidio;
        }
    }
}

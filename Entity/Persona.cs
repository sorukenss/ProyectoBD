using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public abstract class Persona
    {
        public string primerNombre { get; set; }
        public string segundoNombre { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }
        public string Cedula { get; set; }
        public string Sexo { get; set; }

        public Persona()
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }

}

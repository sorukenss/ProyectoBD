using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class FichaTecnica
    {
        public Integrante Integrante { get; set; }
        public List<Integrante> integrantesFamilia { get; set; }
    }
}

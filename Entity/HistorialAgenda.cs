using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class HistorialAgenda
    {
        public Integrante Integrante { get; set; }
        public int diaPlaneado { get; set; }
        public int mesPlaneado { get; set; }
        public int añoPlaneado { get; set; }
        public List<Integrante> historialAgendaIntegrante { get; set; }
    }
}

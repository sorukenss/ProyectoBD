using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Subsidio
    {
        public Integrante Integrante { get; set; }
        public IList<Integrante> Integrantes { get; set; }
        public int SalarioDeVengado { get; set; }
        public int IntegrantesFamilias { get; set; }
        public int Estrato { get; set; }
        public decimal PuntajeSisben { get; set; }
        public string Correo { get; set; }

        public Subsidio()
        {
            Integrantes = new List<Integrante>();
        }

        public void AgregarIntegrantes(Integrante integrante)
        {
            integrante.Subsidio = this;
            Integrantes.Add(integrante);
        }

        public void AgregarRepresentanteFamilia(Integrante integrante)
        {
            Integrante = integrante;
        }
    }
}

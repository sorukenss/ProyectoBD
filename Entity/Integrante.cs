using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Integrante : Persona
    {
        public string direccionVivienda { get; set; }
        public bool Discapacidad { get; set; }
        public string estadoCivil { get; set; }
        public bool Hijos { get; set; }
        public int Estrato { get; set; }
        public string tipoDiscapacidad { get; set; }
        public string grupoPoblacional { get; set; }
        public string barrioVivienda { get; set; }
        public string ciudadVivienda { get; set; }
        public string departamentoVivienda { get; set; }
        public string ciudadNacimiento { get; set; }
        public string departamentoNacimiento { get; set; }
        public int diaNacimiento { get; set; }
        public int mesNacimiento { get; set; }
        public int añoNacimiento { get; set; }
        public string familiaId { get; set; }
        public int Edad { get; set; }
        public double puntajeSisben { get; set; }
        public string Escolaridad { get; set; }
        public double Ingresos { get; set; }
        public string regimenAfiliacion { get; set; }
        public string tipoDocumento { get; set; }
        public bool Trabajo { get; set; }
        public string direccionTrabajo { get; set; }
        public bool Internet { get; set; }

        public Integrante()
        {

        }
    }
}

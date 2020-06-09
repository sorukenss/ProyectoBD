using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Administrador : Persona
    {
        public string usuarioId { get; set; }
        public Empleado Empleado { get; set; }
        public string Password { get; set; }
        public Administrador()
        {
        }

        public override string ToString()
        {
            return $"{usuarioId};{primerNombre};{segundoNombre};{primerApellido};{segundoApellido};{Cedula};{Sexo};{Password}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Empleado : Persona
    {
        public Integrante Integrante { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public Empleado()
        {
        }

        public override string ToString()
        {
            return $"{Cedula};{primerNombre};{segundoNombre};{primerApellido};{segundoApellido};{Sexo};{Password};{Email}";
        }   

    }
}

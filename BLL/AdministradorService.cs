using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;
using Infraestructura;


namespace BLL
{
    public class AdministradorService 
    {
        private readonly AdministradorRepository Repositorio;
        public List<Empleado> Empleados;
        private readonly ConectionManager Connection;
        

        public AdministradorService(string connection)
        {
            Connection = new ConectionManager(connection);
            Repositorio = new AdministradorRepository(Connection);
        }

        public string GuardarEmpleado(Empleado empleado)
        {
            Email email = new Email();
            string mensajeEmail = string.Empty;
            try
            {
                Connection.Open();
                Repositorio.GuardarEmpleado(empleado);
                return ($"El empleado ha sigo guardado exitoxamente.");
            }
            catch (Exception ex)
            {
                return ($"Error: no se ha podido guardar el empleado{ex.Message.ToString()}");
            }
            finally
            {
                Connection.Close();
            }
        }

        public string EnviarEmail(string documento)
        {
            Email email = new Email();
            string mensajeEmail = string.Empty;
            try
            {
                mensajeEmail = email.EnviarEmail(documento);
                return ($"Mensaje enviado correctamente.");
            }
            catch(Exception e)
            {
                return ($"Error: no se ha podido enviar el mensaje.");
            }
        }

        public string GenerarPdf(List<Empleado> empleados, string filename)
        {
            DocumentoPdf documentoPdf = new DocumentoPdf();
            try
            {
                documentoPdf.GuardarPDF(empleados, filename);
                return "Se generó el Documento satisfactoriamente";
            }
            catch (Exception e)
            {

                return "Error al crear docuemnto" + e.Message;
            }
        }

        public List<Empleado> ConsultarEmpleados()
        {
            return Repositorio.ConsultarEmpleados();
        }

        public bool IniciarSesionEmpleado(string Usuario, string Password)
        {
            return Repositorio.IniciarSesionEmpleado(Usuario, Password);
        }



    }
}

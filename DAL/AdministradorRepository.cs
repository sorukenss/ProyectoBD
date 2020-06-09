using Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class AdministradorRepository
    {
        private readonly SqlConnection _connection;
        private List<Empleado> ListaEmpleados;
        private SqlDataReader DataReader;

        public AdministradorRepository(ConectionManager connection)
        {
            _connection = connection.Connection;
        }

        public void GuardarEmpleado(Empleado empleado)
        {
            SqlCommand command = new SqlCommand("GuardarEmpleado", _connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("Identificacion", SqlDbType.VarChar).Value = empleado.Cedula;
            command.Parameters.Add("Primer_Nombre", SqlDbType.VarChar).Value = empleado.primerNombre;
            command.Parameters.Add("Segundo_Nombre", SqlDbType.VarChar).Value = empleado.segundoNombre;
            command.Parameters.Add("Primer_Apellido", SqlDbType.VarChar).Value = empleado.primerApellido;
            command.Parameters.Add("Segundo_Apellido", SqlDbType.VarChar).Value = empleado.segundoApellido;
            command.Parameters.Add("Sexo", SqlDbType.VarChar).Value = empleado.Sexo;
            command.Parameters.Add("Contraseña", SqlDbType.VarChar).Value = empleado.Password;
            command.Parameters.Add("Correo", SqlDbType.VarChar).Value = empleado.Email;
            command.ExecuteNonQuery();
            command.Dispose();
        }
        
        
        public List<Empleado> ConsultarEmpleados()
        {
            ListaEmpleados = new List<Empleado>();
            using (var command = _connection.CreateCommand())
            {
                command.Connection.Open();
                command.CommandText = "SELECT * FROM EMPLEADO ";
                var DataReader = command.ExecuteReader();

                if (DataReader.HasRows)
                {
                    while (DataReader.Read())
                    {
                        Empleado empleado = DataReaderMapearEmpleado(DataReader);
                        ListaEmpleados.Add(empleado);
                    }
                }
                command.Connection.Close();
            }

            return ListaEmpleados;
        }

        public bool IniciarSesionEmpleado(string Usuario, string password)
        {
            using (var command = _connection.CreateCommand())
            {
                command.Connection.Open();
                command.CommandText = "SELECT * FROM EMPLEADO WHERE Correo = @Correo AND Contraseña = @Contraseña";
                command.Parameters.AddWithValue("@Correo", Usuario);
                command.Parameters.AddWithValue("@Contraseña", password);
                var DataReader = command.ExecuteReader();
                if (DataReader.HasRows)
                {
                    command.Connection.Close();
                    return true;
                }
                else
                {
                    command.Connection.Close();
                    return false;
                }

            }
        }

        private Empleado DataReaderMapearEmpleado(SqlDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Empleado empleado = new Empleado();

            empleado.Cedula = (string)dataReader["Identificacion"];
            empleado.primerNombre = (string)dataReader["Primer_Nombre"];
            empleado.segundoNombre = (string)dataReader["Segundo_Nombre"];
            empleado.primerApellido = (string)dataReader["Primer_Apellido"];
            empleado.segundoApellido = (string)dataReader["Segundo_Apellido"];
            empleado.Sexo = (string)dataReader["Sexo"];
            empleado.Password = (string)dataReader["Contraseña"];
            empleado.Email = (string)dataReader["Correo"];
            return empleado;
        }
       
    }
}

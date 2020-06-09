using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class ConectionManager
    {
        public SqlConnection Connection;
        public ConectionManager(string connection)
        {
            Connection = new SqlConnection(connection);


        }

        public void Open()
        {
            Connection.Open();
            
        }

        public void Close()
        {
            Connection.Close();

        }
    }
}

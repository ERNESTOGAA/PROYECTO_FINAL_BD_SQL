using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ConexionCSharpconMySQL
{
   public class BdComun
    {

       public static MySqlConnection ObtenerConexion()
       {
           MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=consulta; Uid=root; pwd=1234;");

           conectar.Open();
           return conectar;
       }

    }
}

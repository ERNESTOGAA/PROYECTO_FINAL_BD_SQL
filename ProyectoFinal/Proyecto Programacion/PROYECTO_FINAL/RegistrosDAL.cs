using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ConexionCSharpconMySQL
{
    class ClietesDAL
    {
        public static int Agregar(Cliente pCliente)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into consulta1 (Nombre, Apellidos, Fecha_Nac, Direccion, Telefono, E_mail, Codigo_Postal) values ('{0}','{1}','{2}', '{3}','{4}','{5}','{6}')",
                pCliente.Nombre, pCliente.Apellido, pCliente.Fecha_Nac, pCliente.Direccion, pCliente.Telefono, pCliente.Email, pCliente.CodigoPostal), BdComun.ObtenerConexion());

            retorno = comando.ExecuteNonQuery();

            return retorno;
        }



        public static List<Cliente> Buscar(string pNombre, string pApellido)
        {
            List<Cliente> _lista = new List<Cliente>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT Id, Nombre, Apellidos, Fecha_Nac, Direccion, Telefono, E_mail, Codigo_Postal FROM consulta1  where Nombre ='{0}' or Apellidos='{1}'", pNombre, pApellido), BdComun.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Cliente pCliente = new Cliente();
                pCliente.Id = _reader.GetInt32(0);
                pCliente.Nombre = _reader.GetString(1);
                pCliente.Apellido = _reader.GetString(2);
                pCliente.Fecha_Nac = _reader.GetString(3);
                pCliente.Direccion = _reader.GetString(4);
                pCliente.Telefono = _reader.GetString(5);
                 pCliente.Email = _reader.GetString(6);
                 pCliente.CodigoPostal = _reader.GetString(7);




                _lista.Add(pCliente);
            }

            return _lista;
        }



        public static Cliente ObtenerCliente(int pId)
        {
            Cliente pCliente = new Cliente();
            MySqlConnection conexion = BdComun.ObtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT Id, Nombre, Apellidos, Fecha_Nac, Direccion, Telefono,  E_mail, Codigo_Postal FROM consulta1 where Id={0}", pId), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                pCliente.Id = _reader.GetInt32(0);
                pCliente.Nombre = _reader.GetString(1);
                pCliente.Apellido = _reader.GetString(2);
                pCliente.Fecha_Nac = _reader.GetString(3);
                pCliente.Direccion = _reader.GetString(4);
                pCliente.Telefono = _reader.GetString(5);
                pCliente.Email = _reader.GetString(6);
                 pCliente.CodigoPostal = _reader.GetString(7);



            }

            conexion.Close();
            return pCliente;

        }



        public static int Actualizar(Cliente pCliente)
        {
            int retorno = 0;
            MySqlConnection conexion = BdComun.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Update consulta1 set Nombre='{0}', Apellidos='{1}', Fecha_Nac='{2}', Direccion='{3}', Telefono='{5}', E_mail='{6}', Codigo_Postal='{7}' where Id={4}",
                pCliente.Nombre, pCliente.Apellido, pCliente.Fecha_Nac, pCliente.Direccion, pCliente.Id, pCliente.Telefono, pCliente.Email, pCliente.CodigoPostal), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }


        public static int Eliminar(int pId)
        {
            int retorno = 0;
            MySqlConnection conexion = BdComun.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Delete From consulta1 where Id={0}", pId), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }


    }
}

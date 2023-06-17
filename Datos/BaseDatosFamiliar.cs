using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class BaseDatosFamiliar : GestorConexion
    {
        public BaseDatosFamiliar() : base()
        {

        }

        public void Agregar(ContactoFamiliar contacto)
        {
            using (var Command = connection.CreateCommand())
            {
                Command.CommandText = "Insert Into ContactosFamiliar (Id,Nombre,Telefono,[Fecha Cumpleaños],Ruta)" +
                                      " values (@Id,@Nombre,@Telefono,@FechaCumpleaños,@Ruta)";
                Command.Parameters.Add("Id", SqlDbType.Int).Value = contacto.Id;
                Command.Parameters.Add("Nombre", SqlDbType.VarChar).Value = contacto.Nombre;
                Command.Parameters.Add("Telefono", SqlDbType.VarChar).Value = contacto.Telefono;
                Command.Parameters.Add("FechaCumpleaños", SqlDbType.Date).Value = contacto.FechaCumpleaños.ToShortDateString();
                Command.Parameters.Add("Ruta", SqlDbType.VarChar).Value = contacto.Ruta;
                Open();
                Command.ExecuteNonQuery();
                Close();
            }
        }

        public void Borrar(int id)
        {
            using (var Command = connection.CreateCommand())
            {
                Command.CommandText = $"Delete ContactosFamiliar where Id = {id}";
                Open();
                Command.ExecuteNonQuery();
                Close();
            }
        }

        public void Actualizar(ContactoFamiliar contacto)
        {
            using (var Command = connection.CreateCommand())
            {
                Command.CommandText = "Update ContactosFamiliar Set Nombre = @Nombre," +
                    "Telefono = @Telefono," +
                    "[Fecha Cumpleaños] = @FechaCumpleaños,"+
                    "Ruta = @Ruta " +
                    "Where Id = @Id";
                Command.Parameters.Add("Nombre", SqlDbType.VarChar).Value = contacto.Nombre;
                Command.Parameters.Add("Telefono", SqlDbType.VarChar).Value = contacto.Telefono;                
                Command.Parameters.Add("FechaCumpleaños", SqlDbType.Date).Value = contacto.FechaCumpleaños.ToShortDateString();
                Command.Parameters.Add("Ruta", SqlDbType.Date).Value = contacto.Ruta;
                Command.Parameters.Add("Id", SqlDbType.Int).Value = contacto.Id;                
                Open();
                Command.ExecuteNonQuery();
                Close();
            }
        }

        public List<ContactoFamiliar> Consultar()
        {
            List<ContactoFamiliar> contactos = new List<ContactoFamiliar>();
            var command = connection.CreateCommand();
            command.CommandText = "select * from ContactosFamiliar";
            Open();
            SqlDataReader lector = command.ExecuteReader();
            while (lector.Read())
            {
                contactos.Add(Mapeador(lector));
            }
            Close();
            return contactos;
        }

        public ContactoFamiliar Mapeador(SqlDataReader dataReader)
        {
            if (!dataReader.HasRows)
                return null;
            ContactoFamiliar contacto = new ContactoFamiliar();
            contacto.Id = dataReader.GetInt32(0);
            contacto.Nombre = dataReader.GetString(1);
            contacto.Telefono = dataReader.GetString(2);
            contacto.FechaCumpleaños = dataReader.GetDateTime(3);
            contacto.Ruta = dataReader.GetString(4);
            return contacto;
        }
    }
}

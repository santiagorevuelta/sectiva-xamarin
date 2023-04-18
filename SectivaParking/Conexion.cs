using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using IntelliJ.Lang.Annotations;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SectivaParking
{
    #region Usuario
    public class Login
    {
        public Login() { }
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(50)]
        public string Identifer { get; set; }
        [MaxLength(50)]
        public string Password { get; set; }

    }
    #endregion

    #region BD
    public class Connection
    {
        static object locker = new object();
        SQLiteConnection connection;
        public Connection()
        {
            connection = ConectarBD();
            connection.CreateTable<Login>();
        }

        public SQLite.SQLiteConnection ConectarBD()
        {
            SQLiteConnection conexionBaseDatos;
            string nombreArchivo = "SectivaParking.db3";
            string ruta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string completaRuta = Path.Combine(ruta, nombreArchivo);
            conexionBaseDatos = new SQLiteConnection(completaRuta);
            return conexionBaseDatos;
        }

        public int Insertar(Login registro)
        {
            lock (locker)
            {
                if (registro.Id == 0)
                {
                    return connection.Insert(registro);
                }
                else
                {
                    return connection.Update(registro);
                }
            }
        }

        public Login SelecionarUsuario(string cedula, string ClaveUsuario)
        {
            lock (locker)
            {
                return connection.Table<Login>().FirstOrDefault(x => x.Identifer == cedula && x.Password == ClaveUsuario);
            }
        }

        public Login BuscarCedula(string cedula)
        {
            lock (locker)
            {
                return connection.Table<Login>().FirstOrDefault(x => x.Identifer == cedula);
            }
        }

        public int EliminarUsuario(int Id)
        {
            Login cedula = BuscarCedula(Id.ToString());
            lock (locker)
            {
                return connection.Delete<Login>(cedula.Id);
            }
        }
    }
    #endregion
}

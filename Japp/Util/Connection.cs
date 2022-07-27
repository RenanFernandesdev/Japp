using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Japp.Util
{
    internal class Connection : IDisposable
    {
        MySqlConnection con = new MySqlConnection();

        public Connection()
        {
            con.ConnectionString = @$"";
        }

        public MySqlConnection Conectar()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            return con;
        }

        public void Desconectar()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        public void Dispose()
        {
            ((IDisposable)con).Dispose();
        }

    }
}

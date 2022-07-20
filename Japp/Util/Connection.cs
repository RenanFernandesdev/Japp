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
            con.ConnectionString = @$"Server=172.16.0.121;Database=japp;uid=renan;password=Akrk@001";
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

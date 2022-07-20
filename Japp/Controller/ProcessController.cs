using Japp.Model;
using Japp.Util;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Japp.Controller
{
    internal class ProcessController
    {
        public static void Insert(Process process)
        {
            using (Connection con = new Connection())
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    string command = "INSERT INTO process (name, description, status) " +
                                     "VALUES (@name, " +
                                             "@description, " +
                                             "@status)";

                    cmd.Parameters.Add("@name", MySqlDbType.VarString).Value = process.GetName();
                    cmd.Parameters.Add("@description", MySqlDbType.VarString).Value = process.GetDescription();
                    cmd.Parameters.Add("@status", MySqlDbType.Byte).Value = process.IsStatus();

                    cmd.CommandText = command;

                    try
                    {
                        cmd.Connection = con.Conectar();
                        cmd.ExecuteNonQuery();
                        con.Desconectar();
                    }
                    catch (Exception e)
                    {
                        throw new ArgumentException("Erro ao inserir process no banco de dados:" + e);
                    }
                }
            }
        }
        public static void Update(Process process)
        {
            using (Connection con = new Connection())
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    string command = "UPDATE process SET " +
                                                    "name = @name, " +
                                                    "description = @description, " +
                                                    "status = @status," +
                                                    "WHERE id = @id";

                    cmd.Parameters.Add("@name", MySqlDbType.VarString).Value = process.GetName();
                    cmd.Parameters.Add("@description", MySqlDbType.VarString).Value = process.GetDescription();
                    cmd.Parameters.Add("@status", MySqlDbType.Byte).Value = process.IsStatus();
                    cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = process.GetId();

                    cmd.CommandText = command;
                    try
                    {
                        cmd.Connection = con.Conectar();
                        cmd.ExecuteNonQuery();
                        con.Desconectar();
                    }
                    catch (Exception e)
                    {
                        throw new ArgumentException("Erro ao atualizar process no banco de dados:" + e);
                    }
                }
            }
        }
        public static void Delete(Process process)
        {
            using (Connection con = new Connection())
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    string command = "DELETE FROM process WHERE @id";

                    cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = process.GetId();
                    cmd.CommandText = command;

                    try
                    {
                        cmd.Connection = con.Conectar();
                        cmd.ExecuteNonQuery();
                        con.Desconectar();
                    }
                    catch (Exception e)
                    {
                        throw new ArgumentException("Erro ao deletar process no banco de dados:" + e);
                    }
                }

            }
        }
        public static DataTable Select()
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();

            using (Connection con =  new Connection())
            {
                string command = "SELECT * FROM process";

                try
                {
                    using (MySqlCommand cmd = new MySqlCommand(command, con.Conectar()))
                    {
                        cmd.CommandText = command;

                        da.SelectCommand = cmd;
                        da.Fill(dt);
                        con.Desconectar();
                    }
                }
                catch (Exception e)
                {
                    throw new ArgumentException("Erro ao selecionar process no banco de dados:" + e);
                }
            }
            return dt;
        }

        public static void Execute(Process process)
        {
            using(IWebDriver driver = new ChromeDriver())
            {
                driver.Manage().Window.Maximize();
                foreach(var step in process.GetSteps())
                {
                    StepBuilder stb = new StepBuilder(driver, step);
                    stb.ExecuteVoid();
                }
                MessageBox.Show("Sucesso!");
            }
        }
    }
}

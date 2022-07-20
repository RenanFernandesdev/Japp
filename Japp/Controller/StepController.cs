using System.Data;
using Japp.Model;
using Japp.Util;
using MySql.Data.MySqlClient;

namespace Japp.Controller
{
    internal class StepController
    {
        public static void Insert(IStep step)
        {
            using (Connection con = new Connection())
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    string command = "INSERT INTO steps (idprocess, name, description, action, parameterType, parameter, status, time) " +
                                     "VALUES (@idprocess," +
                                     "@name, " +
                                     "@description, " +
                                     "@action, " +
                                     "@parameterType, " +
                                     "@parameter, " +
                                     "@status, " +
                                     "@time)";

                    cmd.Parameters.Add("@idprocess", MySqlDbType.Int32).Value = step.GetIdProcess();
                    cmd.Parameters.Add("@name", MySqlDbType.VarString).Value = step.GetName();
                    cmd.Parameters.Add("@description", MySqlDbType.VarString).Value = step.GetDescription();
                    cmd.Parameters.Add("@action", MySqlDbType.Int32).Value = (int?)step.GetActions();
                    cmd.Parameters.Add("@parameterType", MySqlDbType.Int32).Value = (int?)step.GetParameterType();
                    cmd.Parameters.Add("@parameter", MySqlDbType.VarString).Value = step.GetParameter();
                    cmd.Parameters.Add("@status", MySqlDbType.Byte).Value = step.IsStatus();
                    cmd.Parameters.Add("@time", MySqlDbType.Int32).Value = step.GetTime();

                    cmd.CommandText = command;

                    try
                    {
                        cmd.Connection = con.Conectar();
                        cmd.ExecuteNonQuery();
                        con.Desconectar();
                    }
                    catch (Exception e)
                    {
                        throw new ArgumentException("Erro ao inserir step no banco de dados:" + e);
                    }
                }
            }
        }

        public static void Update(IStep step)
        {
            using (Connection con = new Connection())
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    string command = "UPDATE steps SET " +
                                                    "idprocess = @idprocess, " +
                                                    "name = @name, " +
                                                    "description = @description, " +
                                                    "action = @action, " +
                                                    "parameterType = @parameterType, " +
                                                    "parameter = @parameter, " +
                                                    "status = @status," +
                                                    "time = @time " +
                                                    "WHERE id = @id";

                    cmd.Parameters.Add("@idprocess", MySqlDbType.Int32).Value = step.GetIdProcess();
                    cmd.Parameters.Add("@name", MySqlDbType.VarString).Value = step.GetName();
                    cmd.Parameters.Add("@description", MySqlDbType.VarString).Value = step.GetDescription();
                    cmd.Parameters.Add("@action", MySqlDbType.Int32).Value = (int?)step.GetActions();
                    cmd.Parameters.Add("@parameterType", MySqlDbType.Int32).Value = (int?)step.GetParameterType();
                    cmd.Parameters.Add("@parameter", MySqlDbType.VarString).Value = step.GetParameter();
                    cmd.Parameters.Add("@status", MySqlDbType.Byte).Value = step.IsStatus();
                    cmd.Parameters.Add("@time", MySqlDbType.Int32).Value = step.GetTime();
                    cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = step.GetId();

                    cmd.CommandText = command;
                    try
                    {
                        cmd.Connection = con.Conectar();
                        cmd.ExecuteNonQuery();
                        con.Desconectar();
                    }
                    catch (Exception e)
                    {
                        throw new ArgumentException("Erro ao atualizar step no banco de dados:" + e);
                    }
                }
            }
        }

        public static void Delete(IStep step)
        {
            using (Connection con = new Connection())
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    string command = "DELETE FROM steps WHERE @id";

                    cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = step.GetId();
                    cmd.CommandText = command;

                    try
                    {
                        cmd.Connection = con.Conectar();
                        cmd.ExecuteNonQuery();
                        con.Desconectar();
                    }
                    catch (Exception e)
                    {
                        throw new ArgumentException("Erro ao deletar step no banco de dados:" + e);
                    }
                }

            }
        }

        public static DataTable Select(int idProcess)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();

            using (Connection con = new Connection())
            {
                string command = "SELECT * FROM steps WHERE @id";

                try
                {
                    using (MySqlCommand cmd = new MySqlCommand(command, con.Conectar()))
                    {
                        cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = idProcess;
                        cmd.CommandText = command;

                        da.SelectCommand = cmd;
                        da.Fill(dt);
                        con.Desconectar();
                    }
                }
                catch (Exception e)
                {
                    throw new ArgumentException("Erro ao selecionar step no banco de dados:" + e);
                }
            }
            return dt;
        }
    }
}

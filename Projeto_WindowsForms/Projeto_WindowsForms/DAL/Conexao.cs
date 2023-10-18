using System.Data.SqlClient;
using System.Data;

namespace Projeto_WindowsForms.DAL
{
    public class Conexao
    {
        private readonly SqlConnection connection;

        private readonly string stringConexao = "server = localhost; database = folhadepagamentoteste; uid = root; password = unlimitedwaifuworks139#";

        public Conexao()
        {
            connection = new SqlConnection(stringConexao);
        }

        public SqlConnection conectar()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                return connection;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool desconectar()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}

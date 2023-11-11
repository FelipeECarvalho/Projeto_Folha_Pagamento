using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class Conexao
    {
        private readonly SqlConnection connection;
        private readonly string stringConexao = "server = localhost; database = recursos_humanos_db; uid = sa; password = unip@123456";

        public Conexao()
        {
            connection = new SqlConnection(stringConexao);
        }

        public SqlConnection Conectar()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                return connection;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Desconectar()
        {
            try
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();

                 return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

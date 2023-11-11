using System.Data.SqlClient;

namespace DAL
{
    public abstract class BaseDAO
    {
        protected readonly Conexao conexao;
        protected SqlDataReader dr;

        public BaseDAO()
        {
            conexao = new Conexao();
        }
    }
}

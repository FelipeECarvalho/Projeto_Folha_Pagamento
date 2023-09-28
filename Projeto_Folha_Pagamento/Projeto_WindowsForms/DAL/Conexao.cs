using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Projeto_WindowsForms.DAL
{
    public class Conexao
    {
        //private SqlConnection connection;
        //private string stringConexao = "Server=localhost;Database=Mudar123;User Id=root;Password=Mudar123";

        //public Conexao()
        //{
        //    connection = new SqlConnection(stringConexao);
        //}

        //public SqlConnection Conectar()
        //{
        //    try
        //    {
        //        if (connection.State == ConnectionState.Closed)
        //        {
        //            connection.Open();
        //        }
        //        return connection;
        //    }
        //    catch (Exception e)
        //    {
        //        return null;
        //    }
        //}

        //public bool Desconectar()
        //{
        //    try
        //    {
        //        if (connection.State == ConnectionState.Open)
        //        {
        //            connection.Close();
        //        }
        //        return true;
        //    }
        //    catch (Exception e)
        //    {
        //        return false;
        //    }
        //}
    }
}

﻿using System;
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
        //private MySqlConnection connection;
        //private String stringConexao = "server = localhost;" +
        //    "database = folhadepagamentoteste; uid = root; password = unlimitedwaifuworks139#";

        //public Conexao()
        //{
        //    connection = new MySqlConnection(stringConexao);
        //}

        //public MySqlConnection conectar()
        //{
        //    try
        //    {
        //        if (connection.State == System.Data.ConnectionState.Closed)
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

        //public bool desconectar()
        //{
        //    try
        //    {
        //        if (connection.State == System.Data.ConnectionState.Open)
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

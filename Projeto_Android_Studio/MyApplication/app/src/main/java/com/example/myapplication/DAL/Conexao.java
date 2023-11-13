package com.example.myapplication.DAL;

import android.os.StrictMode;

import java.sql.Connection;
import java.sql.DriverManager;

public class Conexao {
    Connection con;
    String nome, senha, ip, port, database;

    public Connection Conectar() throws Exception {
        ip = "192.168.0.2";
        database = "recursos_humanos_db";
        nome = "sa";
        senha = "unip@123456";
        port = "1433";

        StrictMode.ThreadPolicy policy = new StrictMode.ThreadPolicy.Builder().permitAll().build();
        StrictMode.setThreadPolicy(policy);

        Connection connection = null;
        String connectionUrl = null;

        try {
            Class.forName("net.sourceforge.jtds.jdbc.Driver");
            connectionUrl = "jdbc:jtds:sqlserver://" + ip + ":" + port + ";databasename=" + database + ";user=" + nome + ";password=" + senha + ";";

            connection = DriverManager.getConnection(connectionUrl);
        }
        catch (Exception ex) {
            throw new Exception(ex.getMessage());
        }

        return connection;
    }
}

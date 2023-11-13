package com.example.myapplication.DAL;

import com.example.myapplication.modelo.Acesso;
import com.example.myapplication.modelo.Colaborador;
import com.example.myapplication.modelo.enums.TipoCargo;
import com.example.myapplication.modelo.enums.TipoSexo;

import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.Statement;

public class AcessoDAO {

    Connection connection;

    public Acesso buscarAcesso(String usuario, String senha) {
        try
        {
            Conexao conexao = new Conexao();
            connection = conexao.Conectar();

            if (connection != null) {
                String query = "SELECT a.id, a.usuario, a.senha, a.ativo, c.id as id_colaborador, c.nome_completo, c.sexo, c.cargo, c.salario, c.data_admissao, c.ativo as c_ativo, c.id_empresa FROM acesso a INNER JOIN colaborador c ON a.id_colaborador = c.id WHERE a.ativo = 1 AND c.ativo = 1 AND a.usuario = '" + usuario + "' AND a.senha = '" + senha + "'";
                Statement st = connection.createStatement();

                ResultSet rs = st.executeQuery(query);

                Acesso acesso = null;
                while (rs.next()) {
                    acesso = new Acesso();
                    acesso.Id = rs.getInt("id");
                    acesso.Usuario = rs.getString("usuario");
                    acesso.Senha = rs.getString("senha");
                    acesso.Ativo = Boolean.parseBoolean(rs.getString("ativo"));

                    acesso.Colaborador = new Colaborador();
                    acesso.Colaborador.Id = rs.getInt("id_colaborador");
                    acesso.Colaborador.NomeCompleto = rs.getString("nome_completo");

                    acesso.Colaborador.Sexo = TipoSexo.ofCode(rs.getString("sexo").charAt(0));
                    acesso.Colaborador.Cargo = TipoCargo.values()[Integer.parseInt(rs.getString("cargo"))];

                    acesso.Colaborador.Salario = Double.parseDouble(rs.getString("salario"));

                    acesso.Colaborador.DataAdmissao = rs.getString("data_admissao");
                    acesso.Colaborador.Ativo = Boolean.parseBoolean(rs.getString("c_ativo"));
                }

                return acesso;
            }
        }
        catch (Exception ex)
        {
            String el = ex.getMessage();
        }

        return null;
    }
}

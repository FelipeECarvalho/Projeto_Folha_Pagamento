package com.example.myapplication.DAL;

import com.example.myapplication.modelo.Colaborador;
import com.example.myapplication.modelo.Empresa;
import com.example.myapplication.modelo.enums.TipoCargo;
import com.example.myapplication.modelo.enums.TipoSexo;

import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;

public class EmpresaDAO {
    Connection connection;

    public ArrayList<Empresa> listarEmpresa() {

        ArrayList<Empresa> listaEmpresa = new ArrayList<>();

        try
        {
            Conexao conexao = new Conexao();
            connection = conexao.Conectar();

            if (connection != null) {
                String query = "SELECT e.id, e.cnpj, e.razao_social, e.nome_fantasia, e.ativo FROM empresa e WHERE e.ativo = 1";
                Statement st = connection.createStatement();

                ResultSet rs = st.executeQuery(query);

                while (rs.next()) {
                    Empresa empresa = new Empresa();
                    empresa.Id = rs.getInt("id_empresa");
                    empresa.Cnpj = rs.getString("cnpj");
                    empresa.RazaoSocial = rs.getString("razao_social");
                    empresa.NomeFantasia = rs.getString("nome_fantasia");
                    empresa.Ativo = Boolean.parseBoolean(rs.getString("e_ativo"));

                    listaEmpresa.add(empresa);
                }
            }
        }
        catch (Exception ex)
        {
            String el = ex.getMessage();
        }

        return listaEmpresa;
    }
}

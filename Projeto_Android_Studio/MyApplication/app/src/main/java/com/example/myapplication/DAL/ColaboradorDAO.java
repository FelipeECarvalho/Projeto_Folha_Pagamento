package com.example.myapplication.DAL;

import com.example.myapplication.modelo.Acesso;
import com.example.myapplication.modelo.Colaborador;
import com.example.myapplication.modelo.Empresa;
import com.example.myapplication.modelo.enums.TipoCargo;
import com.example.myapplication.modelo.enums.TipoSexo;

import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.Statement;
import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import java.util.Locale;

public class ColaboradorDAO {
    Connection connection;

    public ArrayList<Colaborador> listarColaborador() {

        ArrayList<Colaborador> listaColaborador = new ArrayList<>();

        try
        {
            Conexao conexao = new Conexao();
            connection = conexao.Conectar();

            if (connection != null) {
                String query = "SELECT c.id, c.nome_completo, c.sexo, c.cargo, c.salario, c.data_admissao, c.ativo, e.id as id_empresa, e.cnpj, e.razao_social, e.nome_fantasia, e.ativo as e_ativo FROM colaborador c INNER JOIN empresa e ON c.id_empresa = e.id WHERE c.ativo = 1 AND e.ativo = 1";
                Statement st = connection.createStatement();

                ResultSet rs = st.executeQuery(query);

                while (rs.next()) {
                    Colaborador colaborador = new Colaborador();
                    colaborador.Id = rs.getInt("id");
                    colaborador.NomeCompleto = rs.getString("nome_completo");

                    colaborador.Sexo = TipoSexo.ofCode(rs.getString("sexo").charAt(0));
                    colaborador.Cargo = TipoCargo.values()[Integer.parseInt(rs.getString("cargo"))];

                    colaborador.Salario = Double.parseDouble(rs.getString("salario"));

                    colaborador.DataAdmissao = rs.getString("data_admissao");
                    colaborador.Ativo = Boolean.parseBoolean(rs.getString("ativo"));

                    colaborador.Empresa = new Empresa();
                    colaborador.Empresa.Id = rs.getInt("id_empresa");
                    colaborador.Empresa.Cnpj = rs.getString("cnpj");
                    colaborador.Empresa.RazaoSocial = rs.getString("razao_social");
                    colaborador.Empresa.NomeFantasia = rs.getString("nome_fantasia");
                    colaborador.Empresa.Ativo = Boolean.parseBoolean(rs.getString("e_ativo"));

                    listaColaborador.add(colaborador);
                }
            }
        }
        catch (Exception ex)
        {
            String el = ex.getMessage();
        }

        return listaColaborador;
    }
}

package com.example.myapplication.DAL;

import com.example.myapplication.modelo.Colaborador;
import com.example.myapplication.modelo.Empresa;
import com.example.myapplication.modelo.FolhaPagamento;
import com.example.myapplication.modelo.enums.TipoCargo;
import com.example.myapplication.modelo.enums.TipoSexo;

import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;

public class FolhaPagamentoDAO {
    Connection connection;

    public ArrayList<FolhaPagamento> listarFolhaPagamento() {

        ArrayList<FolhaPagamento> listaFolhaPagamento  = new ArrayList<>();

        try
        {
            Conexao conexao = new Conexao();
            connection = conexao.Conectar();

            if (connection != null) {
                String query = "SELECT f.id, f.inss, f.irrf, f.horas_extras, f.valor_horas_extras, f.valor_liquido, f.descontos_totais, f.vencimentos_totais, f.aliquota_inss, f.aliquota_irrf, f.data_criacao, f.ativo, c.id as id_colaborador, c.nome_completo, c.sexo, c.cargo, c.salario, c.data_admissao, c.ativo as c_ativo, c.id_empresa FROM folha_pagamento f INNER JOIN colaborador c ON f.id_colaborador = c.id WHERE f.ativo = 1 AND c.ativo = 1";
                Statement st = connection.createStatement();

                ResultSet rs = st.executeQuery(query);

                while (rs.next()) {
                    FolhaPagamento folhaPagamento = new FolhaPagamento();

                    folhaPagamento.Id = rs.getInt("id");
                    folhaPagamento.Inss = rs.getDouble("inss");
                    folhaPagamento.Irrf = rs.getDouble("irrf");
                    folhaPagamento.HorasExtras = rs.getInt("horas_extras");
                    folhaPagamento.ValorHorasExtras = rs.getDouble("valor_horas_extras");
                    folhaPagamento.ValorLiquido = rs.getDouble("valor_liquido");
                    folhaPagamento.DescontosTotais = rs.getDouble("descontos_totais");
                    folhaPagamento.VencimentosTotais = rs.getDouble("vencimentos_totais");
                    folhaPagamento.AliquotaInss = rs.getDouble("aliquota_inss");
                    folhaPagamento.AliquotaIrrf = rs.getDouble("aliquota_irrf");
                    folhaPagamento.DataCriacao = rs.getString("data_criacao");
                    folhaPagamento.Ativo = Boolean.parseBoolean(rs.getString("ativo"));

                    folhaPagamento.Colaborador = new Colaborador();
                    folhaPagamento.Colaborador.Id = rs.getInt("id_colaborador");
                    folhaPagamento.Colaborador.NomeCompleto = rs.getString("nome_completo");

                    folhaPagamento.Colaborador.Sexo = TipoSexo.ofCode(rs.getString("sexo").charAt(0));
                    folhaPagamento.Colaborador.Cargo = TipoCargo.values()[Integer.parseInt(rs.getString("cargo"))];

                    folhaPagamento.Colaborador.Salario = Double.parseDouble(rs.getString("salario"));

                    folhaPagamento.Colaborador.DataAdmissao = rs.getString("data_admissao");
                    folhaPagamento.Colaborador.Ativo = Boolean.parseBoolean(rs.getString("c_ativo"));

                    listaFolhaPagamento.add(folhaPagamento);
                }
            }
        }
        catch (Exception ex)
        {
            String el = ex.getMessage();
        }

        return listaFolhaPagamento;
    }
}

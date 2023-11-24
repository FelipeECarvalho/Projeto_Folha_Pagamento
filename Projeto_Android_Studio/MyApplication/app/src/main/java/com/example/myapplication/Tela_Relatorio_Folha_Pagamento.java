package com.example.myapplication;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.TableLayout;
import android.widget.TableRow;
import android.widget.TextView;

import com.example.myapplication.DAL.ColaboradorDAO;
import com.example.myapplication.DAL.FolhaPagamentoDAO;
import com.example.myapplication.modelo.Colaborador;
import com.example.myapplication.modelo.FolhaPagamento;
import com.google.android.material.internal.ForegroundLinearLayout;

import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;

public class Tela_Relatorio_Folha_Pagamento extends AppCompatActivity {

    TextView txvSetaVoltar;
    TextView txvLupa;
    Context context;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_tela_relatorio_folha_pagamento);

        configuracao();
        eventos();
    }

    public void configuracao()
    {
        txvSetaVoltar = findViewById(R.id.txvSetaVoltar);
        txvLupa = findViewById(R.id.txvLupa);

        ArrayList<FolhaPagamento> listaFolhaPagamento  = new FolhaPagamentoDAO().listarFolhaPagamento();

        TableLayout table = (TableLayout)findViewById(R.id.folhaPagamentoTable);

        for (FolhaPagamento folhaPagamento: listaFolhaPagamento) {
            TableRow row= new TableRow(this);

            TextView tv1= new TextView(this);
            tv1.setText(folhaPagamento.Id.toString());

            TextView tv2=new TextView(this);
            tv2.setText(folhaPagamento.Colaborador.NomeCompleto);

            TextView tv3=new TextView(this);

            // Vem do banco no formato datetime, aqui eu faço a separação para pegar apenas a data
            String[] datas = folhaPagamento.DataCriacao.toString().split("\\s+");
            tv3.setText(datas[0]);

            row.addView(tv1);
            row.addView(tv2);
            row.addView(tv3);

            table.addView(row);
        }
    }

    public void eventos()
    {
        txvSetaVoltar.setOnClickListener(new View.OnClickListener()
        {
            @Override
            public void onClick(View view)
            {
                Intent intent = new Intent(Tela_Relatorio_Folha_Pagamento.this, Tela_Menu.class);
                intent.putExtras(getIntent().getExtras());
                startActivity(intent);
            }
        });

        txvLupa.setOnClickListener(new View.OnClickListener()
        {
            @Override
            public void onClick(View view)
            {

            }
        });
    }
}
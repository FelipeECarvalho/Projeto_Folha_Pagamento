package com.example.myapplication;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.TextView;

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
    }

    public void eventos()
    {
        txvSetaVoltar.setOnClickListener(new View.OnClickListener()
        {
            @Override
            public void onClick(View view)
            {
                Intent intent = new Intent(Tela_Relatorio_Folha_Pagamento.this, Tela_Menu.class);
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
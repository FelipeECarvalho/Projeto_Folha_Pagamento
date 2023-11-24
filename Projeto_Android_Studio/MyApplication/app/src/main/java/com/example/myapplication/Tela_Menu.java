package com.example.myapplication;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.LinearLayout;
import android.widget.TextView;

public class Tela_Menu extends AppCompatActivity {

    Button btnLogOut;
    Context context;
    TextView txvUserName;
    LinearLayout lnlColaboradores;
    LinearLayout lnlEmpresas;
    LinearLayout lnlFolhaPagamento;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_tela_menu);

        configuracao();
        eventos();
    }

    public void configuracao()
    {
        btnLogOut = findViewById(R.id.btnLogout);
        lnlColaboradores = findViewById(R.id.lnlColaboradores);
        lnlEmpresas = findViewById(R.id.lnlEmpresas);
        lnlFolhaPagamento = findViewById(R.id.lnlFolhaPagamento);
        txvUserName = findViewById(R.id.txvUserName);

        Bundle extras = getIntent().getExtras();
        if (extras != null) {
            String nome = extras.getString("nome");
            txvUserName.setText(nome);

            String cargo = extras.getString("cargo");

            if (cargo.equals("AnalistaDP")) {
                lnlColaboradores.setVisibility(View.GONE);
            }

            if (cargo.equals("AnalistaRH") || cargo.equals("AnalistaDP")) {
                lnlEmpresas.setVisibility(View.GONE);
            }

            if (cargo.equals("AnalistaRH")) {
                lnlFolhaPagamento.setVisibility(View.GONE);
            }
        }
    }

    public void eventos()
    {
        btnLogOut.setOnClickListener(new View.OnClickListener()
        {
            @Override
            public void onClick(View view)
            {
                Intent intent = new Intent(Tela_Menu.this, MainActivity.class);
                startActivity(intent);
            }
        });

        lnlColaboradores.setOnClickListener(new View.OnClickListener()
        {
            @Override
            public void onClick(View view)
            {
                Intent intent = new Intent(Tela_Menu.this, Tela_Relatorios_Colaboradores.class);
                intent.putExtras(getIntent().getExtras());
                startActivity(intent);
            }
        });

        lnlEmpresas.setOnClickListener(new View.OnClickListener()
        {
            @Override
            public void onClick(View view)
            {
                Intent intent = new Intent(Tela_Menu.this, Tela_Relatorios_Empresas.class);
                intent.putExtras(getIntent().getExtras());
                startActivity(intent);
            }
        });

        lnlFolhaPagamento.setOnClickListener(new View.OnClickListener()
        {
            @Override
            public void onClick(View view)
            {
                Intent intent = new Intent(Tela_Menu.this, Tela_Relatorio_Folha_Pagamento.class);
                intent.putExtras(getIntent().getExtras());
                startActivity(intent);
            }
        });
    }
}

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
import com.example.myapplication.DAL.EmpresaDAO;
import com.example.myapplication.modelo.Colaborador;
import com.example.myapplication.modelo.Empresa;

import java.util.ArrayList;

public class Tela_Relatorios_Empresas extends AppCompatActivity {

    TextView txvSetaVoltar;
    TextView txvLupa;
    Context context;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_tela_relatorios_empresas);

        configuracao();
        eventos();
    }

    public void configuracao()
    {
        txvSetaVoltar = findViewById(R.id.txvSetaVoltar);
        txvLupa = findViewById(R.id.txvLupa);

        ArrayList<Empresa> listaEmpresa = new EmpresaDAO().listarEmpresa();

        TableLayout table = (TableLayout)findViewById(R.id.empresaTable);

        for (Empresa empresa: listaEmpresa) {
            TableRow row= new TableRow(this);

            TextView tv1= new TextView(this);
            tv1.setText(empresa.Id.toString());

            TextView tv2=new TextView(this);
            tv2.setText(empresa.NomeFantasia);

            TextView tv3=new TextView(this);
            tv3.setText(empresa.Cnpj);

            TextView tv4=new TextView(this);
            tv4.setText(empresa.RazaoSocial);

            row.addView(tv1);
            row.addView(tv2);
            row.addView(tv3);
            row.addView(tv4);

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
                Intent intent = new Intent(Tela_Relatorios_Empresas.this, Tela_Menu.class);
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
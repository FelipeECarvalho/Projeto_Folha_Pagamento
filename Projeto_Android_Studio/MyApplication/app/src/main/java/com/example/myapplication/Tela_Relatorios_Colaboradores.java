package com.example.myapplication;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.TableLayout;
import android.widget.TableRow;
import android.widget.TextView;
import android.widget.LinearLayout;

import com.example.myapplication.DAL.ColaboradorDAO;
import com.example.myapplication.modelo.Colaborador;

import java.util.ArrayList;

public class Tela_Relatorios_Colaboradores extends AppCompatActivity
{

    TextView txvSetaVoltar;
    TextView txvLupa;
    Context context;

    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_tela_relatorios_colaboradores);

        configuracao();
        eventos();
    }

    public void configuracao()
    {
        txvSetaVoltar = findViewById(R.id.txvSetaVoltar);
        txvLupa = findViewById(R.id.txvLupa);

        ArrayList<Colaborador> listaColaborador = new ColaboradorDAO().listarColaborador();

        TableLayout table = (TableLayout)findViewById(R.id.colaboradorTable);

        for (Colaborador colaborador: listaColaborador) {
            TableRow row= new TableRow(this);

            TextView tv1= new TextView(this);
            tv1.setText(colaborador.Id.toString());

            TextView tv2=new TextView(this);
            tv2.setText(colaborador.NomeCompleto);

            TextView tv3=new TextView(this);
            tv3.setText(colaborador.Empresa.NomeFantasia);

            TextView tv4=new TextView(this);
            tv4.setText(colaborador.Cargo.toString());

            TextView tv5=new TextView(this);
            tv5.setText(colaborador.Salario.toString());

            TextView tv6=new TextView(this);
            tv6.setText(colaborador.DataAdmissao.toString());

            row.addView(tv1);
            row.addView(tv2);
            row.addView(tv3);
            row.addView(tv4);
            row.addView(tv5);
            row.addView(tv6);

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
                Intent intent = new Intent(Tela_Relatorios_Colaboradores.this, Tela_Menu.class);
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
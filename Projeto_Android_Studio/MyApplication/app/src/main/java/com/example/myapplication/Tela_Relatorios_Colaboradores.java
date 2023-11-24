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

import java.text.NumberFormat;
import java.util.ArrayList;
import java.util.Locale;

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

            // Formatando o dinheiro
            Locale locale = new Locale("pt", "BR");
            NumberFormat formatter = NumberFormat.getCurrencyInstance(locale);
            String moneyString = formatter.format(colaborador.Salario);

            tv5.setText(moneyString);

            TextView tv6=new TextView(this);

            String[] datas = colaborador.DataAdmissao.toString().split("\\s+");
            tv6.setText(datas[0]);

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
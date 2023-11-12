package com.example.myapplication;

import static android.app.ProgressDialog.show;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import com.example.myapplication.controle.Controle;

public class MainActivity extends AppCompatActivity
{

    EditText edtLogin;
    EditText edtSenha;
    Button btnAcessar;
    Context context;


    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        configuracao();
        eventos();
    }

    public void configuracao()
    {
        edtLogin = findViewById(R.id.edtLogin);
        edtSenha = findViewById(R.id.edtSenha);
        btnAcessar = findViewById(R.id.btnLogout);
        context = this;
    }

    public void eventos()
    {
        btnAcessar.setOnClickListener(new View.OnClickListener()
        {
            @Override
            public void onClick(View view)
            {

                Controle controle = new Controle();
                controle.acessar(edtLogin.getText().toString(), edtSenha.getText().toString());

                if (controle.mensagem.isEmpty())
                {
                    Toast.makeText(getApplicationContext(), controle.mensagem, Toast.LENGTH_LONG).show();
                    Intent intent = new Intent(MainActivity.this, Tela_Menu.class);
                    startActivity(intent);
                }
                else
                {
                    Toast.makeText(getApplicationContext(), controle.mensagem, Toast.LENGTH_LONG).show();
                }
            }
        });
    }
}
package com.example.myapplication;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

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
                    Intent intent = new Intent(MainActivity.this, Tela_Menu.class);
                    startActivity(intent);
            }
        });
    }
}
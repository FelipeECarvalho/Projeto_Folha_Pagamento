package com.example.myapplication.controle;

import android.os.AsyncTask;

import com.example.myapplication.modelo.Acesso;

public class Validacao
{
    public String mensagem;

    public void validarAcesso(String login, String senha)
    {
        this.mensagem = "";

        if (login.isEmpty()) {
            this.mensagem += "Campo login é obrigatório \n";
        }

        if (senha.isEmpty()) {
            this.mensagem += "Campo senha é obrigatório";
        }
    }
}

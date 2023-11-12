package com.example.myapplication.controle;

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

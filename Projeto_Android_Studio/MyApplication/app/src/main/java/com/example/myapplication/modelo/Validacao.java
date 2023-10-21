package com.example.myapplication.modelo;

public class Validacao
{
    public String mensagem;

    public void validarLogin(String login, String senha)
    {
        this.mensagem = "";
        if(!login.equals("admin") || !senha.equals("admin"))
        {
            this.mensagem = "Login ou Senha inválidos";
        }
    }
}

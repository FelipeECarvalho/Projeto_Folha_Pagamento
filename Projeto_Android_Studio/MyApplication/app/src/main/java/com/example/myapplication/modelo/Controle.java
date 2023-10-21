package com.example.myapplication.modelo;

public class Controle
{
    public String mensagem = "";
    public String resultado;

    public void validarLogin(String login, String senha)
    {
        this.mensagem = "";
        Validacao validacao = new Validacao();
        validacao.validarLogin(login, senha);
        if (validacao.mensagem.equals(""))
        {
            this.mensagem = "Login bem-sucedido!";
        }
        else
        {
            this.mensagem = validacao.mensagem;
        }
    }
}

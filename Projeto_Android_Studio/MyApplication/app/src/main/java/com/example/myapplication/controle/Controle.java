package com.example.myapplication.controle;

public class Controle
{
    public String mensagem = "";
    public String resultado;

    public void acessar(String usuario, String senha) {
        Validacao validacao = new Validacao();
        validacao.validarAcesso(usuario, senha);

        if (validacao.mensagem.isEmpty()) {
            try
            {
                // TODO: CHAMAR API
            }
            catch (Exception ex)
            {
                mensagem = ex.getMessage();
            }
        } else {
            mensagem = validacao.mensagem;
        }
    }
}

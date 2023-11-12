package com.example.myapplication.controle;

import com.example.myapplication.modelo.Acesso;

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
                Servico servico = new Servico();
                Acesso acesso = servico.Acessar(usuario, senha);

                if (acesso == null) {
                    mensagem = servico.mensagem;
                }
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

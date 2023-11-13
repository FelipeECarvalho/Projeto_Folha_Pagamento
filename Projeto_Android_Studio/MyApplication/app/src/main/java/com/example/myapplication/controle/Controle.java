package com.example.myapplication.controle;

import com.example.myapplication.DAL.AcessoDAO;
import com.example.myapplication.modelo.Acesso;

import java.io.UnsupportedEncodingException;
import java.math.BigInteger;
import java.security.MessageDigest;
import java.security.NoSuchAlgorithmException;

public class Controle
{
    public String mensagem = "";
    public String resultado;

    public Acesso acessar(String usuario, String senha) throws UnsupportedEncodingException, NoSuchAlgorithmException {
        Validacao validacao = new Validacao();
        validacao.validarAcesso(usuario, senha);

        if (validacao.mensagem.isEmpty()) {
            AcessoDAO acessoDAO = new AcessoDAO();

            MessageDigest m = MessageDigest.getInstance("MD5");
            m.reset();
            m.update(senha.getBytes());
            byte[] digest = m.digest();
            BigInteger bigInt = new BigInteger(1,digest);
            String hashtext = bigInt.toString(16);

            while(hashtext.length() < 32 ){
                hashtext = "0"+hashtext;
            }

            Acesso acesso = acessoDAO.buscarAcesso(usuario, hashtext);

            return acesso;
        } else {
            mensagem = validacao.mensagem;
        }

        return null;
    }
}

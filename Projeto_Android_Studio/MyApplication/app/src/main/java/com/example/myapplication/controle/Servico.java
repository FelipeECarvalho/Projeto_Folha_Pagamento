package com.example.myapplication.controle;

import android.os.AsyncTask;

import com.example.myapplication.modelo.Acesso;

import java.io.BufferedInputStream;
import java.io.InputStream;
import java.net.HttpURLConnection;
import java.net.URL;
import com.google.gson.Gson;

// Classe responsável por realizar as operações com a API
public class Servico {
    public String mensagem = "";
    private final String urlBase = "http://10.0.2.2:7053/";

    public Acesso Acessar(String usuario, String senha) {
        Acesso acesso = null;
        HttpURLConnection urlConnection = null;

        try {

            URL url = new URL(urlBase + "acesso");

            // Abrindo a conexão
            urlConnection = (HttpURLConnection) url.openConnection();

            // Setando os headers
            urlConnection.setRequestMethod("GET");
            urlConnection.setRequestProperty("application/json", "charset=UTF-8");
            urlConnection.setRequestProperty("Content-Length", "100");
            urlConnection.setRequestProperty("usuario", usuario);
            urlConnection.setRequestProperty("senha", senha);

            // Lendo a resposta

            InputStream qw = urlConnection.getInputStream();
            InputStream in = new BufferedInputStream(qw);

            // Convertendo a resposta em uma string
            java.util.Scanner s = new java.util.Scanner(in).useDelimiter("\\A");
            String result = s.hasNext() ? s.next() : "";

            // Convertendo o json string em um objeto
            acesso = new Gson().fromJson(result, Acesso.class);

            return acesso;
        }
        catch (Exception e) {
            mensagem = e.getMessage();
        }
        finally {
            urlConnection.disconnect();
        }

        return acesso;
    }
}

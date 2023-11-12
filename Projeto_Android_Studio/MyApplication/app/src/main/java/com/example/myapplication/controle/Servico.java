package com.example.myapplication.controle;

import java.io.BufferedInputStream;
import java.io.InputStream;
import java.net.HttpURLConnection;
import java.net.URL;
import org.apache.commons.io.IOUtils;

// Classe responsável por realizar as operações com a API
public class Servico {
    private final String urlBase = "https://localhost:7053/";

    public void Acessar(String usuario, String senha) {
        HttpURLConnection urlConnection = null;

        try {
            URL url = new URL(urlBase + "acesso");

            urlConnection = (HttpURLConnection) url.openConnection();

            urlConnection.setRequestMethod("GET");
            urlConnection.setRequestProperty("usuario", usuario);
            urlConnection.setRequestProperty("senha", senha);

            InputStream in = new BufferedInputStream(urlConnection.getInputStream());
            String jsonResponse = IOUtils.toString(in, "UTF-8");
        }
        catch (Exception e) {
            e.printStackTrace();
        }
        finally {
            urlConnection.disconnect();
        }
    }
}

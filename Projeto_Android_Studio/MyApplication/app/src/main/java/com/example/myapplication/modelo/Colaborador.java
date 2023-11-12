package com.example.myapplication.modelo;

import com.example.myapplication.modelo.enums.TipoCargo;
import com.example.myapplication.modelo.enums.TipoSexo;
import java.util.Date;

public class Colaborador {
    public String NomeCompleto;
    public TipoSexo Sexo;
    public TipoCargo Cargo;
    public Double Salario;
    public Date DataAdmissao;
    public Empresa Empresa;
}

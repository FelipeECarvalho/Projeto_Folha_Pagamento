package com.example.myapplication.modelo.enums;

public enum TipoSexo {
    Masculino('M'),
    Feminino('F'),
    Outro('-');

    public char asChar() {
        return asChar;
    }

    public static TipoSexo ofCode(char code) {
        TipoSexo[] values = TipoSexo.values();
        for (TipoSexo value : values) {
            if(value.asChar == code){
                return value;
            }

        }
        throw new IllegalArgumentException("Code not found");
    }

    private final char asChar;

    TipoSexo(char asChar) {
        this.asChar = asChar;
    }
}

﻿using Projeto_WindowsForms.Modelo;

namespace Projeto_WindowsForms.Controle
{
    public class Validacao
    {
        // Atributos
        public string mensagem;
        public int indice;
        public int IndiceColaboradorEncontrado = -1;

        // Construtor

        //Métodos
        public int ValidarColaboradores(List<Colaborador> colaboradores, List<string> nomesColaboradores)
        {
            // Looping para validar a lista de coboradores com o valor inserido na TextBox
            for (int i = 0; i < colaboradores.Count; i++)
            {
                foreach (string nome in nomesColaboradores)
                {
                    // Se o valor for encontrado com o nome ou com o ID..
                    if (colaboradores[i].Nome.Equals(nome, StringComparison.OrdinalIgnoreCase))
                    {
                        this.mensagem = "Colaborador encontrado!";
                        this.indice = i;
                        return indice; // Retorna o índice do colaborador encontrado
                    }
                    else if (colaboradores[i].Id.ToString().Equals(nome, StringComparison.OrdinalIgnoreCase))
                    {
                        this.mensagem = "Colaborador encontrado!";
                        this.indice = i;
                        return indice; // Retorna o índice do colaborador encontrado
                    }
                }
            }

            // Se o valor não corresponder à nenhum colaborador da lista de colaboradores
            this.mensagem = "Colaborador não encontrado!";
            return -1; // Retorna -1 se o colaborador não for encontrado
        }

        public void ValidarCalculo(string horasExtrasText)
        {
            // Validação: Tenta converter o valor inserido em double
            if (double.TryParse(horasExtrasText, out double horasExtras))
            {
                this.mensagem = ""; // Se a conversão der certo, retorna mensagem vazia
            }
            else
            {
                this.mensagem = "Número inserido é inválido!"; // Se a conversão der errado, retorna "Número inserido é inválido!"
            }
        }
        
        public void validarDadosColaborador(List<string>listaDadosColaborador)
        {
            this.mensagem = "";
            if (listaDadosColaborador[0].Length == 0)
                this.mensagem += "Preencha o nome do colaborador\n";
            if (listaDadosColaborador[0].Length > 50)
                this.mensagem += "Nome do colaborador não deve ultrapassar de 50 caracteres\n";
            if (listaDadosColaborador[1].Length == 0)
                this.mensagem += "Prencha o cargo\n";
            if (listaDadosColaborador[2].Length == 0)
                this.mensagem += "Preencha a empresa\n";
            if (listaDadosColaborador[3].Length == 0)
                this.mensagem += "Preencha o salario\n";
            if (listaDadosColaborador[4].Length == 0)
                this.mensagem += "Preencha a data de admissão\n";

        }

        public void validarDadosEmpresa(List<string> listaDadosColaborador)
        {
            this.mensagem = "";
            string cnpj = listaDadosColaborador[0];
            string razaoSocial = listaDadosColaborador[1];
            string nomeFantasia = listaDadosColaborador[2];

            if (string.IsNullOrEmpty(cnpj) || string.IsNullOrEmpty(razaoSocial) || string.IsNullOrEmpty(nomeFantasia))
                this.mensagem = "Preencha todos os campos antes de cadastrar a empresa.";

            if (cnpj.Length != 14 || !cnpj.All(char.IsDigit))
                this.mensagem = "O CNPJ deve conter exatamente 14 digitos numéricos.";

            if (razaoSocial.Length > 50)
                this.mensagem = "A Razão Social não pode exceder 100 caracteres.";

            if (nomeFantasia.Length > 50)
                this.mensagem = "O Nome Fantasia não pode exceder 50 caracteres.";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tela_Gerar_Folha_de_Pagamento.Modelo
{
    public class Colaborador
    {
        // Atributos
        public string Nome;
        public int ID;
        public string NomeEmpresa;
        public string CNPJEmpresa;
        public string Funcao;
        public float Salario;

        // Construtor
        public Colaborador(string nome, int id, string nomeEmpresa, string cnpjEmpresa, string funcao, float salario)
        {
            Nome = nome;
            ID = id;
            NomeEmpresa = nomeEmpresa;
            CNPJEmpresa = cnpjEmpresa;
            Funcao = funcao;
            Salario = salario;
        }


        // Métodos
    }
}

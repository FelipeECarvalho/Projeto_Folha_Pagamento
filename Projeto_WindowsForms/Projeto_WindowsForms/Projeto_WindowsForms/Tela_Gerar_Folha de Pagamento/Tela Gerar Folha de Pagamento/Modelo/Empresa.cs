using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tela_Gerar_Folha_de_Pagamento.Modelo
{
    public class Empresa
    {
        // Atributos
        public string Nome;
        public string CNPJ;

        // Construtor
        public Empresa(string nome, string cnpj) 
        { 
            Nome = nome;
            CNPJ = cnpj;
        }

        // Métodos
    }
}

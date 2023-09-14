namespace Projeto_WindowsForms.Modelo
{
    public class Empresa
    {
        // Propriedades
        public string Nome { get; set; }
        public string CNPJ { get; set; }

        // Construtor
        public Empresa(string nome, string cnpj)
        {
            Nome = nome;
            CNPJ = cnpj;
        }

        // Métodos
    }
}
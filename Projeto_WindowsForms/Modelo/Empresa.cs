namespace Projeto_WindowsForms.Modelo
{
    public class Empresa
    {
        public string CNPJ { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }

        public Empresa(string cnpj, string razaoSocial, string nomeFantasia)
        {
            this.CNPJ = cnpj;
            this.RazaoSocial = razaoSocial;
            this.NomeFantasia = nomeFantasia;
        }
    }
}
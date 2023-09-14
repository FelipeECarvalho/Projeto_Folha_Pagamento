namespace Projeto_WindowsForms.Modelo
{
    public class Colaborador
    {
        // Atributos
        public string Nome { get; set; }
        public int ID { get; set; }
        public string NomeEmpresa { get; set; }
        public string CNPJEmpresa { get; set; }
        public string Funcao { get; set; }
        public float Salario { get; set; }

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
    }
}
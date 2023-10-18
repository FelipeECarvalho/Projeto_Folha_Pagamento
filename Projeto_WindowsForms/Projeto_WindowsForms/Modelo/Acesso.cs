namespace Projeto_WindowsForms.Modelo
{
    public  class Acesso
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public Colaborador Colaborador { get; set; }
    }
}
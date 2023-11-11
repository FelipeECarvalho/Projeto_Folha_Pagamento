namespace Modelo
{
    public class Acesso : ModeloBase
    {
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string SenhaOriginal { get; set; }
        public Colaborador Colaborador { get; set; }
    }
}
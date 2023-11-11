using Modelo;

namespace Projeto_Web.ViewModel
{
    public class RelatorioViewModel
    {
        public Colaborador Colaborador { get; set; }

        public IList<Colaborador> Colaboradores { get; set; }

        public IList<Empresa> Empresas { get; set; }

        public IList<FolhaPagamento> FolhasPagamento { get; set; }
    }
}

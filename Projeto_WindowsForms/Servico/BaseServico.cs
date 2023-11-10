using System.Configuration;

namespace Servico
{
    public abstract class BaseServico
    {
        protected readonly string _urlBase;

        public BaseServico()
        {
            _urlBase = ConfigurationManager.AppSettings["UrlBase"];
        }
    }
}

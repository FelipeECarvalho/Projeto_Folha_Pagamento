using Microsoft.AspNetCore.Mvc;
namespace Projeto_Api.Controllers
{
    public class BaseControle : ControllerBase
    {
        protected Validacao validacao;

        public BaseControle()
        {
            validacao = new Validacao();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Projeto_Api.Utils;

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

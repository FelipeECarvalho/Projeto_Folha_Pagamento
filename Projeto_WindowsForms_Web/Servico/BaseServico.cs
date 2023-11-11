using Modelo;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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

        /// <summary>
        /// Método responsável por ler e converter a resposta de uma requisição da api
        /// </summary>
        /// <param name="resposta"></param>
        /// <returns></returns>
        protected T GetData<T>(HttpResponseMessage resposta)
        {
            // Lendo o conteúdo que foi retornado da api
            var conteudo = new StreamReader(resposta.Content.ReadAsStream());

            // Convertendo o conteúdo que foi lido para um Json object
            var jsonObjeto = JObject.Parse(conteudo.ReadToEnd());

            // Convertendo o Json object na classe genérica que vai ser instanciada
            var objeto = JsonConvert.DeserializeObject<T>(jsonObjeto["data"].ToString());

            return objeto;
        }

        /// <summary>
        /// Método responsável por ler e converter os erros da requisição da api
        /// </summary>
        /// <param name="resposta"></param>
        /// <returns></returns>
        protected string GetError(HttpResponseMessage resposta)
        {
            // Lendo o conteúdo que foi retornado da api
            var conteudo = new StreamReader(resposta.Content.ReadAsStream());

            // Convertendo o conteúdo que foi lido para um Json object
            var jsonObjeto = JObject.Parse(conteudo.ReadToEnd());

            // Convertendo o Json object em uma lista de string
            var listaDeErros = JsonConvert.DeserializeObject<List<string>>(jsonObjeto["errors"].ToString());

            return string.Join(",", listaDeErros);
        }
    }
}

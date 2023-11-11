using Modelo;
using Newtonsoft.Json;
using System.Text;

namespace Servico
{
    public class FolhaPagamentoServico : BaseServico
    {
        /// <summary>
        /// Método responsável listar todas as folhas de pagamento.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public IList<FolhaPagamento> ListarFolhaPagamento()
        {
            var url = _urlBase + "folha-pagamento/listar";

            var request = new HttpRequestMessage(HttpMethod.Get, url);

            using var client = new HttpClient();
            using var response = client.Send(request);

            if (response.IsSuccessStatusCode)
            {
                return GetData<IList<FolhaPagamento>>(response);
            }
            else
            {
                throw new Exception(GetError(response));
            }
        }

        /// <summary>
        /// Método reponsável por cadastrar uma folha de pagameto por meio da api
        /// </summary>
        /// <param name="folhaPagamento"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public void CadastrarFolhaPagamento(FolhaPagamento folhaPagamento)
        {
            var url = _urlBase + "folha-pagamento";

            var json = JsonConvert.SerializeObject(folhaPagamento);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var request = new HttpRequestMessage(HttpMethod.Post, url)
            {
                Content = data
            };

            using var client = new HttpClient();
            using var response = client.Send(request);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(GetError(response));
            }
        }
    }
}

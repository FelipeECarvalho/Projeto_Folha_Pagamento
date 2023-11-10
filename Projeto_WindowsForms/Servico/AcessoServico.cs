using Modelo;
using Newtonsoft.Json;

namespace Servico
{
    public class AcessoServico : BaseServico
    {
        public Acesso BuscarAcesso(string usuario, string senha)
        {
            var url = _urlBase + "acesso";

            var request = new HttpRequestMessage(HttpMethod.Get, url);

            request.Headers.Add("usuario", usuario);
            request.Headers.Add("senha", senha);

            using var client = new HttpClient();
            using var response = client.Send(request);

            if (response.IsSuccessStatusCode)
            {
                var content = new StreamReader(response.Content.ReadAsStream());
                var jsonString = content.ReadToEnd();

                return JsonConvert.DeserializeObject<Acesso>(jsonString);
            }
            else
            {
                throw new Exception("Não foi possível obter o produto: " + response.StatusCode);
            }
        }

        public Acesso BuscarAcesso(int idColaborador)
        {
            var url = _urlBase + "acesso/" + idColaborador;

            var request = new HttpRequestMessage(HttpMethod.Get, url);

            using var client = new HttpClient();
            using var response = client.Send(request);

            if (response.IsSuccessStatusCode)
            {
                var content = new StreamReader(response.Content.ReadAsStream());
                var jsonString = content.ReadToEnd();

                return JsonConvert.DeserializeObject<Acesso>(jsonString);
            }
            else
            {
                throw new Exception("Não foi possível obter o produto: " + response.StatusCode);
            }
        }
    }
}
using Modelo;

namespace Servico
{
    public class AcessoServico : BaseServico
    {

        /// <summary>
        /// Método responsável buscar o acesso por um usuário e senha.
        /// </summary>
        /// <param name="usuario">usuario</param>
        /// <param name="senha">senha</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
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
                return GetData<Acesso>(response); ;
            }
            else
            {
                throw new Exception(GetError(response));
            }
        }

        /// <summary>
        /// Método responsável buscar o acesso pelo id do colaborador.
        /// </summary>
        /// <param name="idColaborador"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public Acesso BuscarAcesso(int idColaborador)
        {
            var url = _urlBase + "acesso/" + idColaborador;

            var request = new HttpRequestMessage(HttpMethod.Get, url);

            using var client = new HttpClient();
            using var response = client.Send(request);

            if (response.IsSuccessStatusCode)
            {
                return GetData<Acesso>(response); 
            }
            else
            {
                throw new Exception(GetError(response));
            }
        }
    }
}
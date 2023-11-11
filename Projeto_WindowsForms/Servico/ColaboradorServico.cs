using Modelo;
using Newtonsoft.Json;
using System.Text;

namespace Servico
{
    public  class ColaboradorServico : BaseServico
    {
        /// <summary>
        /// Método reponsável por cadastrar um colaborador por meio da api
        /// </summary>
        /// <param name="colaborador"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public Acesso CadastrarColaborador(Colaborador colaborador)
        {
            var url = _urlBase + "colaborador";

            var json = JsonConvert.SerializeObject(colaborador);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var request = new HttpRequestMessage(HttpMethod.Post, url) 
            {
                Content = data
            };

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

        /// <summary>
        /// Método responsável buscar o colaborador pelo id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public Colaborador BuscarColaborador(int id)
        {
            var url = _urlBase + "colaborador/" + id;

            var request = new HttpRequestMessage(HttpMethod.Get, url);

            using var client = new HttpClient();
            using var response = client.Send(request);

            if (response.IsSuccessStatusCode)
            {
                return GetData<Colaborador>(response);
            }
            else
            {
                throw new Exception(GetError(response));
            }
        }

        /// <summary>
        /// Método responsável buscar o colaborador pelo nome.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<Colaborador> BuscarColaborador(string nome)
        {
            var url = _urlBase + "colaborador";

            var request = new HttpRequestMessage(HttpMethod.Get, url);
            request.Headers.Add("nome", nome);

            using var client = new HttpClient();
            using var response = client.Send(request);

            if (response.IsSuccessStatusCode)
            {
                return GetData<List<Colaborador>>(response);
            }
            else
            {
                throw new Exception(GetError(response));
            }
        }

        /// <summary>
        /// Método responsável listar todos os colaboradores.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<Colaborador> ListarColaborador()
        {
            var url = _urlBase + "colaborador/listar";

            var request = new HttpRequestMessage(HttpMethod.Get, url);

            using var client = new HttpClient();
            using var response = client.Send(request);

            if (response.IsSuccessStatusCode)
            {
                return GetData<List<Colaborador>>(response);
            }
            else
            {
                throw new Exception(GetError(response));
            }
        }

        /// <summary>
        /// Método responsável por desativar um colaborador.
        /// </summary>
        /// <param name="id">id do colaborador</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public void DesativarColaborador(int id)
        {
            var url = _urlBase + "colaborador/" + id;

            var request = new HttpRequestMessage(HttpMethod.Delete, url);

            using var client = new HttpClient();
            using var response = client.Send(request);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(GetError(response));
            }
        }

        /// <summary>
        /// Método responsável por editar um colaborador.
        /// </summary>
        /// <param name="id">id do colaborador</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public void EditarColaborador(Colaborador colaborador, Acesso acesso)
        {
            var url = _urlBase + "colaborador/";

            // Necessário pois a edicao de usuário também edita o acesso dele.
            var usuarioEdit = new
            {
                Colaborador = colaborador,
                Acesso = acesso
            };

            var json = JsonConvert.SerializeObject(usuarioEdit);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var request = new HttpRequestMessage(HttpMethod.Put, url)
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

using Modelo;
using Newtonsoft.Json;
using System.Text;

namespace Servico
{
    public class EmpresaServico : BaseServico
    {
        /// <summary>
        /// Método reponsável por cadastrar um empresa por meio da api
        /// </summary>
        /// <param name="empresa"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public void CadastrarEmpresa(Empresa empresa)
        {
            var url = _urlBase + "empresa";

            var json = JsonConvert.SerializeObject(empresa);
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

        /// <summary>
        /// Método responsável buscar a empresa pelo id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public Empresa BuscarEmpresa(int id)
        {
            var url = _urlBase + "empresa/" + id;

            var request = new HttpRequestMessage(HttpMethod.Get, url);

            using var client = new HttpClient();
            using var response = client.Send(request);

            if (response.IsSuccessStatusCode)
            {
                return GetData<Empresa>(response);
            }
            else
            {
                throw new Exception(GetError(response));
            }
        }

        /// <summary>
        /// Método responsável listar todas as empresas.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public IList<Empresa> ListarEmpresa()
        {
            var url = _urlBase + "empresa/listar";

            var request = new HttpRequestMessage(HttpMethod.Get, url);

            using var client = new HttpClient();
            using var response = client.Send(request);

            if (response.IsSuccessStatusCode)
            {
                return GetData<IList<Empresa>>(response);
            }
            else
            {
                throw new Exception(GetError(response));
            }
        }

        /// <summary>
        /// Método responsável por desativar uma empresa.
        /// </summary>
        /// <param name="id">id da empresa</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public void DesativarEmpresa(int id)
        {
            var url = _urlBase + "empresa/" + id;

            var request = new HttpRequestMessage(HttpMethod.Delete, url);

            using var client = new HttpClient();
            using var response = client.Send(request);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(GetError(response));
            }
        }

        /// <summary>
        /// Método responsável por editar uma empresa.
        /// </summary>
        /// <param name="empresa">empresa</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public void EditarEmpresa(Empresa empresa)
        {
            var url = _urlBase + "empresa/";

            var json = JsonConvert.SerializeObject(empresa);
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

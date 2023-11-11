namespace Projeto_Api.ViewModels
{
    /// <summary>
    /// Classe responsável pelo retorno dos dados da api
    /// </summary>
    /// <typeparam name="T">Classe genérica</typeparam>
    public class ResultadoViewModel<T>
    {
        public T Data { get; set; }
        public List<string> Errors { get; set; } = new();

        public ResultadoViewModel(T data, List<string> errors)
        {
            Data = data;
            Errors = errors;
        }

        public ResultadoViewModel(T data)
        {
            Data = data;
        }

        public ResultadoViewModel(List<string> errors)
        {
            Errors = errors;
        }

        public ResultadoViewModel(string Error)
        {
            Errors.Add(Error);
        }
    }
}

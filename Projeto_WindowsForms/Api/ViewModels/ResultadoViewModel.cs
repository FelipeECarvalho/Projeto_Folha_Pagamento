namespace Projeto_Api.ViewModels
{
    public class ResultadoViewModel
    {
        /// <summary>
        /// Classe responsável pelo retorno dos dados da api
        /// </summary>
        /// <typeparam name="T">Classe genérica</typeparam>
        public class ResultViewModel<T>
        {
            public T Data { get; set; }

            public List<string> Errors { get; set; } = new();

            public ResultViewModel(T data, List<string> errors)
            {
                Data = data;
                Errors = errors;
            }

            public ResultViewModel(T data)
            {
                Data = data;
            }

            public ResultViewModel(List<string> errors)
            {
                Errors = errors;
            }

            public ResultViewModel(string Error)
            {
                Errors.Add(Error);
            }
        }
    }
}

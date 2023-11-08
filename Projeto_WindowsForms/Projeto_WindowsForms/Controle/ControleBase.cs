using System.Security.Cryptography;
using System.Text;

namespace Projeto_WindowsForms.Controle
{
    public class ControleBase
    {
        // Atributos
        public string mensagem = "";
        protected Validacao validacao = new();

        /// <summary>
        /// Método responsável por gerar uma nova senha númerica de seis digitos
        /// </summary>
        /// <returns></returns>
        protected static string GerarSenha()
        {
            var rnd = new Random();
            
            // Instanciação de um array de int
            var randomNumbers = new int[6];

            for (int i = 0; i < randomNumbers.Length; i++)
            {
                // É gerado aleatoriamente um número inteiro e inserido no array
                randomNumbers[i] = rnd.Next(0, 9);
            }

            // É convertido o array de inteiro em uma string
            var randomString = string.Join("", randomNumbers);

            return randomString;
        }

        /// <summary>
        /// Método responsável por criptografar determinado input
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        protected static string GerarHashMd5(string input)
        {
            var md5Hash = MD5.Create();

            // Converter a String para array de bytes, que é como a biblioteca trabalha.
            var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Cria-se um StringBuilder para recompôr a string.
            var sBuilder = new StringBuilder();

            // Loop para formatar cada byte como uma String em hexadecimal
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }
    }
}
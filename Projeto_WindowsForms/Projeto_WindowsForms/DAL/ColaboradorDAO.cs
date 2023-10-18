using Projeto_WindowsForms.Modelo;
using System.Data.SqlClient;

namespace Projeto_WindowsForms.DAL
{
    public class ColaboradorDAO
    {
        private Conexao conexao;
        private SqlDataReader dr;

        public ColaboradorDAO()
        {
            conexao = new Conexao();
        }

        public void cadastrarColaborador(Colaborador colaborador)
        {
            SqlCommand cmd = new()
            {
                CommandText = @"insert into colaborador (nome_completo, sexo, cargo, salario, data_admissao, id_empresa) 
                                values (@nome, @sexo, @cargo, @salario, @dataadmissao, @id_empresa)"
            };

            cmd.Parameters.AddWithValue("@nome", colaborador.NomeCompleto);
            cmd.Parameters.AddWithValue("@sexo", (char)colaborador.Sexo);
            cmd.Parameters.AddWithValue("@cargo", colaborador.Cargo);
            cmd.Parameters.AddWithValue("@salario", colaborador.Salario);
            cmd.Parameters.AddWithValue("@dataadmissao", colaborador.DataAdmissao);
            cmd.Parameters.AddWithValue("@id_empresa", colaborador.Empresa.Id);

            try
            {
                cmd.Connection = conexao.conectar();

                cmd.ExecuteNonQuery();

                conexao.desconectar();
            }
            catch (Exception)
            {
                throw;
            }
            finally 
            {
                conexao.desconectar();
            }
        }
    }
}

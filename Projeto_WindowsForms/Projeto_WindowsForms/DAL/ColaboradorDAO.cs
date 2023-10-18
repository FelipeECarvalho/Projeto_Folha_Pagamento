using Projeto_WindowsForms.Modelo;
using System.Data.SqlClient;

namespace Projeto_WindowsForms.DAL
{
    public class ColaboradorDAO
    {
        Conexao con = new Conexao();
        SqlDataReader dr;
        public string mensagem;

        public void cadastrarColaborador(Colaborador colaborador)
        {
            this.mensagem = "";

            SqlCommand cmd = new()
            {
                CommandText = @"insert into colaboradores (nome, cargo, empresa, salario, dataadmissao) 
                            values (@nome, @cargo, @empresa, @salario, @dataadmissao)"
            };

            cmd.Parameters.AddWithValue("@nome", colaborador.NomeCompleto);
            cmd.Parameters.AddWithValue("@cargo", colaborador.Cargo);
            cmd.Parameters.AddWithValue("@empresa", colaborador.Empresa);
            cmd.Parameters.AddWithValue("@salario", colaborador.Salario);
            cmd.Parameters.AddWithValue("@dataadmissao", colaborador.DataAdmissao);

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();
                this.mensagem = "Colaborador cadastrado!";
            }
            catch (Exception e)
            {
                this.mensagem = "Erro de Banco de Dados";
            }
        }

    }
}

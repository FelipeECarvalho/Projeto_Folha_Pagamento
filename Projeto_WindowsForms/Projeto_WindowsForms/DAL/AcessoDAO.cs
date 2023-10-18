using Projeto_WindowsForms.Controle;
using Projeto_WindowsForms.Modelo;
using Projeto_WindowsForms.Modelo.Enum;
using System.Data.SqlClient;

namespace Projeto_WindowsForms.DAL
{
    public class AcessoDAO
    {
        private readonly Conexao conexao;
        private SqlDataReader dr;

        public AcessoDAO()
        {
            conexao = new Conexao();
        }

        public Acesso buscarAcesso(string usuario, string senha)
        {
            Acesso acesso = null;

            SqlCommand cmd = new()
            {
                CommandText = @"SELECT a.id, a.usuario, a.senha, c.id as id_colaborador, c.nome_completo, c.sexo, c.cargo, c.salario, c.data_admissao, c.id_empresa
                                FROM acesso a 
                                INNER JOIN colaborador c 
                                ON a.id_colaborador = c.id 
                                WHERE a.usuario = @usuario AND a.senha = @senha"
            };

            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = conexao.conectar();

                dr = cmd.ExecuteReader();
                
                if (dr.Read())
                {
                    Enum.TryParse<TipoSexo>(dr["sexo"].ToString(), out var sexo);
                    Enum.TryParse<TipoCargo>(dr["cargo"].ToString(), out var cargo);

                    acesso = new Acesso
                    {
                        Id = int.Parse(dr["id"].ToString()),
                        Usuario = dr["usuario"].ToString(),
                        Senha = dr["senha"].ToString(),
                        Colaborador = new Colaborador
                        {
                            Id = int.Parse(dr["id_colaborador"].ToString()),
                            NomeCompleto = dr["nome_completo"].ToString(),
                            Sexo = sexo,
                            Cargo = cargo,
                            Salario = decimal.Parse(dr["salario"].ToString()),
                            DataAdmissao = DateTime.Parse(dr["data_admissao"].ToString()),
                            Empresa = new Empresa
                            {
                                Id = int.Parse(dr["id_empresa"].ToString())
                            }
                        }
                    };
                }

                dr.Close();

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

            return acesso;
        }
    }
}

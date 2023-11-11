using Modelo;
using Modelo.Enum;
using System.Data.SqlClient;

namespace DAL
{
    public class AcessoDAO : BaseDAO
    {
        public Acesso BuscarAcesso(string usuario, string senha)
        {
            Acesso acesso = null;

            SqlCommand cmd = new()
            {
                CommandText = @"SELECT a.id, a.usuario, a.senha, a.ativo, c.id as id_colaborador, c.nome_completo, c.sexo, c.cargo, c.salario, c.data_admissao, c.ativo as c_ativo, c.id_empresa
                                FROM acesso a 
                                    INNER JOIN colaborador c 
                                    ON a.id_colaborador = c.id 
                                WHERE
                                    a.ativo = 1 AND
                                    c.ativo = 1 AND
                                    a.usuario = @usuario AND 
                                    a.senha = @senha"
            };

            cmd.Parameters.AddWithValue("@usuario", usuario.ToLower());
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = conexao.Conectar();

                dr = cmd.ExecuteReader();
                
                if (dr.Read())
                {
                    Enum.TryParse<TipoSexo>(dr["sexo"].ToString(), out var sexo);
                    Enum.TryParse<TipoCargo>(dr["cargo"].ToString(), out var cargo);

                    acesso = new Acesso
                    {
                        Ativo = bool.Parse(dr["ativo"].ToString()),
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
                            Ativo = bool.Parse(dr["c_ativo"].ToString()),
                            Empresa = new Empresa
                            {
                                Id = int.Parse(dr["id_empresa"].ToString())
                            }
                        }
                    };
                }

                dr.Close();

                conexao.Desconectar();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexao.Desconectar();
            }

            return acesso;
        }

        public Acesso BuscarAcesso(int idColaborador)
        {
            Acesso acesso = null;

            SqlCommand cmd = new()
            {
                CommandText = @"SELECT a.id, a.usuario, a.senha, a.ativo, c.id as id_colaborador, c.nome_completo, c.sexo, c.cargo, c.salario, c.data_admissao, c.ativo as c_ativo, c.id_empresa
                                FROM acesso a 
                                    INNER JOIN colaborador c 
                                    ON a.id_colaborador = c.id 
                                WHERE
                                    a.ativo = 1 AND
                                    c.ativo = 1 AND
                                    a.id_colaborador = @idColaborador"
            };

            cmd.Parameters.AddWithValue("@idColaborador", idColaborador);

            try
            {
                cmd.Connection = conexao.Conectar();

                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    Enum.TryParse<TipoSexo>(dr["sexo"].ToString(), out var sexo);
                    Enum.TryParse<TipoCargo>(dr["cargo"].ToString(), out var cargo);

                    acesso = new Acesso
                    {
                        Ativo = bool.Parse(dr["ativo"].ToString()),
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
                            Ativo = bool.Parse(dr["c_ativo"].ToString()),
                            Empresa = new Empresa
                            {
                                Id = int.Parse(dr["id_empresa"].ToString())
                            }
                        }
                    };
                }

                dr.Close();

                conexao.Desconectar();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexao.Desconectar();
            }

            return acesso;
        }
    }
}

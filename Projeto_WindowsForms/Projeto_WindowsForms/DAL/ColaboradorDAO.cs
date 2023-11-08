using Projeto_WindowsForms.Modelo;
using Projeto_WindowsForms.Modelo.Enum;
using System.Data.SqlClient;

namespace Projeto_WindowsForms.DAL
{
    public class ColaboradorDAO
    {
        private readonly Conexao conexao;
        private SqlDataReader dr;

        public ColaboradorDAO()
        {
            conexao = new Conexao();
        }

        public void cadastrarColaborador(Colaborador colaborador, Acesso acesso)
        {
            SqlCommand cmd = new()
            {
                CommandText = @"insert into colaborador (nome_completo, sexo, cargo, salario, data_admissao, ativo, id_empresa) 
                                    values (@nome, @sexo, @cargo, @salario, @dataadmissao, @col_ativo, @id_empresa);
                                insert into acesso (usuario, senha, ativo, id_colaborador) 
                                    values (@usuario, @senha, @acesso_ativo, SCOPE_IDENTITY())"
            };

            cmd.Parameters.AddWithValue("@nome", colaborador.NomeCompleto);
            cmd.Parameters.AddWithValue("@sexo", (char)colaborador.Sexo);
            cmd.Parameters.AddWithValue("@cargo", colaborador.Cargo);
            cmd.Parameters.AddWithValue("@salario", colaborador.Salario);
            cmd.Parameters.AddWithValue("@dataadmissao", colaborador.DataAdmissao);
            cmd.Parameters.AddWithValue("@col_ativo", colaborador.Ativo);
            cmd.Parameters.AddWithValue("@id_empresa", colaborador.Empresa.Id);

            cmd.Parameters.AddWithValue("@acesso_ativo", acesso.Ativo);
            cmd.Parameters.AddWithValue("@usuario", acesso.Usuario);
            cmd.Parameters.AddWithValue("@senha", acesso.Senha);

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

        public Colaborador buscarColaborador(string idNome)
        {
            Colaborador colaborador = null;

            SqlCommand cmd = new()
            {
                CommandText = @"SELECT c.id, c.nome_completo, c.sexo, c.cargo, c.salario, c.data_admissao, c.ativo, e.id as id_empresa, e.cnpj, e.razao_social, e.nome_fantasia, e.ativo as e_ativo
                                FROM colaborador c 
                                    INNER JOIN empresa e 
                                    ON c.id_empresa = e.id 
                                WHERE 
                                    c.ativo = 1 AND 
                                    e.ativo = 1
                                    AND "
            };

            // Verifica se é número (id) ou string (Nome)
            if (int.TryParse(idNome, out _))
                cmd.CommandText += "c.id = @idNome";
            else
                cmd.CommandText += "c.nome_completo = @idNome";

            cmd.Parameters.AddWithValue("@idNome", idNome);

            try
            {
                cmd.Connection = conexao.conectar();

                dr = cmd.ExecuteReader();
                
                if (dr.Read())
                {
                    Enum.TryParse<TipoCargo>(dr["cargo"].ToString(), out var cargo);

                    colaborador = new Colaborador
                    {
                        Ativo = bool.Parse(dr["ativo"].ToString()),
                        Id = int.Parse(dr["id"].ToString()),
                        NomeCompleto = dr["nome_completo"].ToString(),
                        Sexo = (TipoSexo)char.Parse(dr["sexo"].ToString()),
                        Cargo = cargo,
                        Salario = decimal.Parse(dr["salario"].ToString()),
                        DataAdmissao = DateTime.Parse(dr["data_admissao"].ToString()),
                        Empresa = new Empresa
                        {
                            Id = int.Parse(dr["id_empresa"].ToString()),
                            Cnpj = dr["cnpj"].ToString(),
                            RazaoSocial = dr["razao_social"].ToString(),
                            NomeFantasia = dr["nome_fantasia"].ToString(),
                            Ativo = bool.Parse(dr["e_ativo"].ToString())
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

            return colaborador;
        }

        public List<Colaborador> listarColaborador()
        {
            var cmd = new SqlCommand
            {
                CommandText = @"SELECT c.id, c.nome_completo, c.sexo, c.cargo, c.salario, c.data_admissao, c.ativo, e.id as id_empresa, e.cnpj, e.razao_social, e.nome_fantasia, e.ativo as e_ativo
                                FROM colaborador c 
                                    INNER JOIN empresa e 
                                    ON c.id_empresa = e.id
                                WHERE 
                                    c.ativo = 1 AND
                                    e.ativo = 1"
            };

            var listaColaborador = new List<Colaborador>();

            try
            {
                cmd.Connection = conexao.conectar();

                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Enum.TryParse<TipoCargo>(dr["cargo"].ToString(), out var cargo);

                        var colaborador = new Colaborador
                        {
                            Ativo = bool.Parse(dr["ativo"].ToString()),
                            Id = int.Parse(dr["id"].ToString()),
                            NomeCompleto = dr["nome_completo"].ToString(),
                            Sexo = (TipoSexo)char.Parse(dr["sexo"].ToString()),
                            Cargo = cargo,
                            Salario = decimal.Parse(dr["salario"].ToString()),
                            DataAdmissao = DateTime.Parse(dr["data_admissao"].ToString()),
                            Empresa = new Empresa
                            {
                                Id = int.Parse(dr["id_empresa"].ToString()),
                                Cnpj = dr["cnpj"].ToString(),
                                RazaoSocial = dr["razao_social"].ToString(),
                                NomeFantasia = dr["nome_fantasia"].ToString(),
                                Ativo = bool.Parse(dr["e_ativo"].ToString())
                            }
                        };

                        listaColaborador.Add(colaborador);
                    }
                }
                dr.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexao.desconectar();
            }

            return listaColaborador;
        }

        public void desativarColaborador(int id)
        {
            var cmd = new SqlCommand
            {
                CommandText = @"update colaborador set ativo = 0 where id = @id"
            };

            cmd.Parameters.AddWithValue("@id", id);

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

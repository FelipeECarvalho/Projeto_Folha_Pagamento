using Modelo;
using Modelo.Enum;
using System.Data.SqlClient;

namespace DAL
{
    public class ColaboradorDAO : BaseDAO
    {
        public void CadastrarColaborador(Colaborador colaborador, Acesso acesso)
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
                cmd.Connection = conexao.Conectar();

                cmd.ExecuteNonQuery();

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
        }

        public void EditarColaborador(Colaborador colaborador, Acesso acesso)
        {
            SqlCommand cmd = new()
            {
                CommandText = @"UPDATE colaborador SET nome_completo = @nome, sexo = @sexo, cargo = @cargo, salario = @salario, data_admissao = @dataadmissao, id_empresa = @id_empresa
                                    WHERE id = @id
                                UPDATE acesso SET senha = @senha
                                    WHERE id = @idAcesso"
            };

            cmd.Parameters.AddWithValue("@nome", colaborador.NomeCompleto);
            cmd.Parameters.AddWithValue("@sexo", (char)colaborador.Sexo);
            cmd.Parameters.AddWithValue("@cargo", colaborador.Cargo);
            cmd.Parameters.AddWithValue("@salario", colaborador.Salario);
            cmd.Parameters.AddWithValue("@dataadmissao", colaborador.DataAdmissao);
            cmd.Parameters.AddWithValue("@id_empresa", colaborador.Empresa.Id);
            cmd.Parameters.AddWithValue("@id", colaborador.Id);

            cmd.Parameters.AddWithValue("@senha", acesso.Senha);
            cmd.Parameters.AddWithValue("@idAcesso", acesso.Id);

            try
            {
                cmd.Connection = conexao.Conectar();

                cmd.ExecuteNonQuery();

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
        }

        public List<Colaborador> BuscarColaborador(string nome)
        {
            SqlCommand cmd = new()
            {
                CommandText = @"SELECT c.id, c.nome_completo, c.sexo, c.cargo, c.salario, c.data_admissao, c.ativo, e.id as id_empresa, e.cnpj, e.razao_social, e.nome_fantasia, e.ativo as e_ativo
                                FROM colaborador c 
                                    INNER JOIN empresa e 
                                    ON c.id_empresa = e.id 
                                WHERE 
                                    c.ativo = 1 AND 
                                    e.ativo = 1 AND
                                    c.nome_completo LIKE @nome"
            };

            cmd.Parameters.AddWithValue("@nome", string.Format("%{0}%", nome));

            var listaColaborador = new List<Colaborador>();

            try
            {
                cmd.Connection = conexao.Conectar();

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

            return listaColaborador;
        }

        public Colaborador BuscarColaborador(int id)
        {
            SqlCommand cmd = new()
            {
                CommandText = @"SELECT c.id, c.nome_completo, c.sexo, c.cargo, c.salario, c.data_admissao, c.ativo, e.id as id_empresa, e.cnpj, e.razao_social, e.nome_fantasia, e.ativo as e_ativo
                                FROM colaborador c 
                                    INNER JOIN empresa e 
                                    ON c.id_empresa = e.id 
                                WHERE 
                                    c.ativo = 1 AND 
                                    e.ativo = 1 AND
                                    c.id = @id"
            };

            cmd.Parameters.AddWithValue("@id", id);

            Colaborador colaborador = null;

            try
            {
                cmd.Connection = conexao.Conectar();

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

            return colaborador;
        }

        public List<Colaborador> ListarColaborador()
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
                cmd.Connection = conexao.Conectar();

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
                conexao.Desconectar();
            }

            return listaColaborador;
        }

        public void DesativarColaborador(int id)
        {
            var cmd = new SqlCommand
            {
                CommandText = @"update colaborador set ativo = 0 where id = @id"
            };

            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                cmd.Connection = conexao.Conectar();

                cmd.ExecuteNonQuery();

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
        }
    }
}

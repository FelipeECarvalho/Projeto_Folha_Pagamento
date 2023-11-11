using Modelo;
using System.Data.SqlClient;

namespace DAL
{
    public class EmpresaDAO : BaseDAO
    {
        public void CadastrarEmpresa(Empresa empresa)
        {
            var cmd = new SqlCommand
            {
                CommandText = @"insert into empresa (cnpj, razao_social, nome_fantasia, ativo) values (@cnpj, @razaosocial, @nomefantasia, @ativo)"
            };

            cmd.Parameters.AddWithValue("@cnpj", empresa.Cnpj);
            cmd.Parameters.AddWithValue("@razaosocial", empresa.RazaoSocial);
            cmd.Parameters.AddWithValue("@nomefantasia", empresa.NomeFantasia);
            cmd.Parameters.AddWithValue("@ativo", empresa.Ativo);

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

        public void EditarEmpresa(Empresa empresa)
        {
            var cmd = new SqlCommand
            {
                CommandText = @"UPDATE empresa SET cnpj = @cnpj, razao_social = @razaosocial, nome_fantasia = @nomefantasia WHERE id = @id"
            };

            cmd.Parameters.AddWithValue("@id", empresa.Id);
            cmd.Parameters.AddWithValue("@cnpj", empresa.Cnpj);
            cmd.Parameters.AddWithValue("@razaosocial", empresa.RazaoSocial);
            cmd.Parameters.AddWithValue("@nomefantasia", empresa.NomeFantasia);

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

        public List<Empresa> ListarEmpresa()
        {
            var cmd = new SqlCommand
            {
                CommandText = @"SELECT id, cnpj, nome_fantasia, razao_social, ativo FROM empresa WHERE ativo = 1"
            };

            var listaEmpresa = new List<Empresa>();

            try
            {
                cmd.Connection = conexao.Conectar();

                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        var empresa = new Empresa
                        {
                            Id = int.Parse(dr["id"].ToString()),
                            Cnpj = dr["cnpj"].ToString(),
                            NomeFantasia = dr["nome_fantasia"].ToString(),
                            RazaoSocial = dr["razao_social"].ToString(),
                            Ativo = bool.Parse(dr["ativo"].ToString())
                        };

                        listaEmpresa.Add(empresa);
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

            return listaEmpresa;
        }

        public void DesativarEmpresa(int id)
        {
            var cmd = new SqlCommand
            {
                CommandText = @"update empresa set ativo = 0 where id = @id"
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

        public Empresa BuscarEmpresa(int id)
        {
            var cmd = new SqlCommand
            {
                CommandText = @"SELECT id, cnpj, nome_fantasia, razao_social, ativo FROM empresa WHERE ativo = 1 AND id = @id"
            };

            cmd.Parameters.AddWithValue("@id", id);

            Empresa empresa = null;

            try
            {
                cmd.Connection = conexao.Conectar();

                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    empresa = new Empresa
                    {
                        Id = int.Parse(dr["id"].ToString()),
                        Cnpj = dr["cnpj"].ToString(),
                        NomeFantasia = dr["nome_fantasia"].ToString(),
                        RazaoSocial = dr["razao_social"].ToString(),
                        Ativo = bool.Parse(dr["ativo"].ToString())
                    };
                }

                dr.Close();

                return empresa;
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

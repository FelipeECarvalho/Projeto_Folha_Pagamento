using System.Data.SqlClient;
using Projeto_WindowsForms.Modelo;

namespace Projeto_WindowsForms.DAL
{
    public class EmpresaDAO
    {
        private SqlDataReader dr;
        private readonly Conexao conexao;

        public EmpresaDAO()
        {
            conexao = new Conexao();
        }

        public void cadastrarEmpresa(Empresa empresa)
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
        public List<Empresa> listarEmpresa()
        {
            var cmd = new SqlCommand
            {
                CommandText = @"SELECT id, cnpj, nome_fantasia, razao_social, ativo FROM empresa WHERE ativo = 1"
            };

            var listaEmpresa = new List<Empresa>();

            try
            {
                cmd.Connection = conexao.conectar();

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
                conexao.desconectar();
            }

            return listaEmpresa;
        }
    }
}

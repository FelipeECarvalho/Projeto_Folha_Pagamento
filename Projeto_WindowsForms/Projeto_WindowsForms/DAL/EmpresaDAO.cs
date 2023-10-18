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
                CommandText = @"insert into empresa (cnpj, razao_social, nome_fantasia) values (@cnpj, @razaosocial, @nomefantasia)"
            };

            cmd.Parameters.AddWithValue("@cnpj", empresa.Cnpj);
            cmd.Parameters.AddWithValue("@razaosocial", empresa.RazaoSocial);
            cmd.Parameters.AddWithValue("@nomefantasia", empresa.NomeFantasia);

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
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select * from empresas";
            List<Empresa> listaEmpresa = new List<Empresa>();

            try
            {
                cmd.Connection = conexao.conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {

                    while (dr.Read())
                    {
                        var empresa = new Empresa();
                        empresa.Cnpj = dr["cnpj"].ToString();
                        empresa.RazaoSocial = dr["razaosocial"].ToString();
                        empresa.NomeFantasia = dr["nomefantasia"].ToString();

                        listaEmpresa.Add(empresa);
                    }
                    dr.Close();
                }
                else
                {
                }


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

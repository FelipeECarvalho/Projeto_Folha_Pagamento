using MySql.Data.MySqlClient;
using Projeto_WindowsForms.Modelo;

namespace Projeto_WindowsForms.DAL
{
    public class EmpresaDAO
    {
        Conexao con = new Conexao();
        MySqlDataReader dr;
        public string mensagem;

        public void cadastrarEmpresa(Empresa empresa)
        {
            this.mensagem = "";
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = @"insert into empresas (cnpj, razaosocial, nomefantasia) 
                            values (@cnpj, @razaosocial, @nomefantasia)";
            cmd.Parameters.AddWithValue("@cnpj", empresa.CNPJ);
            cmd.Parameters.AddWithValue("@razaosocial", empresa.RazaoSocial);
            cmd.Parameters.AddWithValue("@nomefantasia", empresa.NomeFantasia);
            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();
                this.mensagem = "Empresa cadastrada!";
            }
            catch (Exception e)
            {
                this.mensagem = "Erro de Banco de Dados";
            }

        }
        public List<Empresa> listarEmpresa()
        {
            this.mensagem = "";
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader dr;
            cmd.CommandText = @"select * from empresas";
            List<Empresa> listaEmpresa = new List<Empresa>();

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {

                    while (dr.Read())
                    {
                        var empresa = new Empresa();
                        empresa.CNPJ = dr["cnpj"].ToString();
                        empresa.RazaoSocial = dr["razaosocial"].ToString();
                        empresa.NomeFantasia = dr["nomefantasia"].ToString();

                        listaEmpresa.Add(empresa);
                    }
                    dr.Close();
                }
                else
                {
                    this.mensagem = "Não existe este ID";
                }


            }
            catch (Exception e)
            {
                this.mensagem = "Erro de BD";
            }
            finally
            {
                con.desconectar();
            }
            return listaEmpresa;
        }


    }
}

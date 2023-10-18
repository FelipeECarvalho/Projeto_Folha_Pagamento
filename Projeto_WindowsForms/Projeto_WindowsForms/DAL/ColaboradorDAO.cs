using Projeto_WindowsForms.Modelo;
using Projeto_WindowsForms.Modelo.Enum;
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

        public void cadastrarColaborador(Colaborador colaborador, Acesso acesso)
        {
            SqlCommand cmd = new()
            {
                CommandText = @"insert into colaborador (nome_completo, sexo, cargo, salario, data_admissao, id_empresa) 
                                    values (@nome, @sexo, @cargo, @salario, @dataadmissao, @id_empresa);
                                insert into acesso (usuario, senha, id_colaborador) 
                                    values (@usuario, @senha, SCOPE_IDENTITY())"
            };

            cmd.Parameters.AddWithValue("@nome", colaborador.NomeCompleto);
            cmd.Parameters.AddWithValue("@sexo", (char)colaborador.Sexo);
            cmd.Parameters.AddWithValue("@cargo", colaborador.Cargo);
            cmd.Parameters.AddWithValue("@salario", colaborador.Salario);
            cmd.Parameters.AddWithValue("@dataadmissao", colaborador.DataAdmissao);
            cmd.Parameters.AddWithValue("@id_empresa", colaborador.Empresa.Id);

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
                CommandText = @"SELECT c.id, c.nome_completo, c.sexo, c.cargo, c.salario, c.data_admissao, e.id as id_empresa, e.cnpj, e.razao_social, e.nome_fantasia
                                FROM colaborador c 
                                INNER JOIN empresa e 
                                ON c.id_empresa = e.id WHERE "
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
                    Enum.TryParse<TipoSexo>(dr["sexo"].ToString(), out var sexo);
                    Enum.TryParse<TipoCargo>(dr["cargo"].ToString(), out var cargo);

                    colaborador = new Colaborador
                    {
                        Id = int.Parse(dr["id"].ToString()),
                        NomeCompleto = dr["nome_completo"].ToString(),
                        Sexo = sexo,
                        Cargo = cargo,
                        Salario = decimal.Parse(dr["salario"].ToString()),
                        DataAdmissao = DateTime.Parse(dr["data_admissao"].ToString()),
                        Empresa = new Empresa
                        {
                            Id = int.Parse(dr["id_empresa"].ToString()),
                            Cnpj = dr["cnpj"].ToString(),
                            RazaoSocial = dr["razao_social"].ToString(),
                            NomeFantasia = dr["nome_fantasia"].ToString()
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
    }
}

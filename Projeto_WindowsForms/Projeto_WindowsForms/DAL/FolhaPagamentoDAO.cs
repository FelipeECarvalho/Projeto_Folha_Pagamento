using System.Data.SqlClient;
using Projeto_WindowsForms.Modelo;
using Projeto_WindowsForms.Modelo.Enum;

namespace Projeto_WindowsForms.DAL
{
    public class FolhaPagamentoDAO
    {
        private SqlDataReader dr;
        private readonly Conexao conexao;

        public FolhaPagamentoDAO()
        {
            conexao = new Conexao();
        }

        public void cadastrarFolhaPagamento(FolhaPagamento folhaPagamento)
        {
            var cmd = new SqlCommand
            {
                CommandText = @"insert into folha_pagamento (inss, irrf, horas_extras, valor_horas_extras, valor_liquido, descontos_totais, vencimentos_totais, aliquota_inss, aliquota_irrf, id_colaborador)
                                values (@inss, @irrf, @horas_extras, @valor_horas_extras, @valor_liquido, @descontos_totais, @vencimentos_totais, @aliquota_inss, @aliquota_irrf, @id_colaborador)"
            };

            cmd.Parameters.AddWithValue("@inss", folhaPagamento.Inss);
            cmd.Parameters.AddWithValue("@irrf", folhaPagamento.Irrf);
            cmd.Parameters.AddWithValue("@horas_extras", folhaPagamento.HorasExtras);
            cmd.Parameters.AddWithValue("@valor_horas_extras", folhaPagamento.ValorHorasExtras);
            cmd.Parameters.AddWithValue("@valor_liquido", folhaPagamento.ValorLiquido);
            cmd.Parameters.AddWithValue("@descontos_totais", folhaPagamento.DescontosTotais);
            cmd.Parameters.AddWithValue("@vencimentos_totais", folhaPagamento.VencimentosTotais);
            cmd.Parameters.AddWithValue("@aliquota_inss", folhaPagamento.AliquotaInss);
            cmd.Parameters.AddWithValue("@aliquota_irrf", folhaPagamento.AliquotaIrrf);
            cmd.Parameters.AddWithValue("@id_colaborador", folhaPagamento.Colaborador.Id);

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
        public List<FolhaPagamento> listarFolhaPagamento()
        {
            var cmd = new SqlCommand
            {
                CommandText = @"SELECT f.id, f.inss, f.irrf, f.horas_extras, f.valor_horas_extras, f.valor_liquido, f.descontos_totais, f.vencimentos_totais, f.aliquota_inss, f.aliquota_irrf, c.id as id_colaborador, c.nome_completo, c.sexo, c.cargo, c.salario, c.data_admissao, c.id_empresa
                                FROM folha_pagamento f
                                INNER JOIN colaborador c
                                ON f.id_colaborador = c.id"
            };

            var listaFolhaPagamento = new List<FolhaPagamento>();

            try
            {
                cmd.Connection = conexao.conectar();

                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Enum.TryParse<TipoCargo>(dr["cargo"].ToString(), out var cargo);

                        var folhaPagamento = new FolhaPagamento
                        {
                            Id = int.Parse(dr["id"].ToString()),
                            Inss = decimal.Parse(dr["inss"].ToString()),
                            Irrf = decimal.Parse(dr["irrf"].ToString()),
                            HorasExtras = int.Parse(dr["horas_extras"].ToString()),
                            ValorHorasExtras = decimal.Parse(dr["valor_horas_extras"].ToString()),
                            ValorLiquido = decimal.Parse(dr["valor_liquido"].ToString()),
                            DescontosTotais = decimal.Parse(dr["descontos_totais"].ToString()),
                            VencimentosTotais = decimal.Parse(dr["vencimentos_totais"].ToString()),
                            AliquotaInss = decimal.Parse(dr["aliquota_inss"].ToString()),
                            AliquotaIrrf = decimal.Parse(dr["aliquota_irrf"].ToString()),
                            Colaborador = new Colaborador
                            {
                                Id = int.Parse(dr["id_colaborador"].ToString()),
                                NomeCompleto = dr["nome_completo"].ToString(),
                                Sexo = (TipoSexo)char.Parse(dr["sexo"].ToString()),
                                Cargo = cargo,
                                Salario = decimal.Parse(dr["salario"].ToString()),
                                DataAdmissao = DateTime.Parse(dr["data_admissao"].ToString()),
                                Empresa = new Empresa
                                {
                                    Id = int.Parse(dr["id_empresa"].ToString()),
                                }
                            }
                        };

                        listaFolhaPagamento.Add(folhaPagamento);
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

            return listaFolhaPagamento;
        }
    }
}

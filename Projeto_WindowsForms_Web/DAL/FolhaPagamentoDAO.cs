using Modelo;
using Modelo.Enum;
using System.Data.SqlClient;

namespace DAL
{
    public class FolhaPagamentoDAO : BaseDAO
    {
        public void CadastrarFolhaPagamento(FolhaPagamento folhaPagamento)
        {
            var cmd = new SqlCommand
            {
                CommandText = @"insert into folha_pagamento (inss, irrf, horas_extras, valor_horas_extras, valor_liquido, descontos_totais, vencimentos_totais, aliquota_inss, aliquota_irrf, data_criacao, ativo, id_colaborador)
                                values (@inss, @irrf, @horas_extras, @valor_horas_extras, @valor_liquido, @descontos_totais, @vencimentos_totais, @aliquota_inss, @aliquota_irrf, @data_criacao, @ativo, @id_colaborador)"
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
            cmd.Parameters.AddWithValue("@data_criacao", folhaPagamento.DataCriacao);
            cmd.Parameters.AddWithValue("@ativo", folhaPagamento.Ativo);
            cmd.Parameters.AddWithValue("@id_colaborador", folhaPagamento.Colaborador.Id);

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

        public List<FolhaPagamento> ListarFolhaPagamento()
        {
            var cmd = new SqlCommand
            {
                CommandText = @"SELECT f.id, f.inss, f.irrf, f.horas_extras, f.valor_horas_extras, f.valor_liquido, f.descontos_totais, f.vencimentos_totais, f.aliquota_inss, f.aliquota_irrf, f.data_criacao, f.ativo, c.id as id_colaborador, c.nome_completo, c.sexo, c.cargo, c.salario, c.data_admissao, c.ativo as c_ativo, c.id_empresa
                                FROM folha_pagamento f
                                    INNER JOIN colaborador c
                                    ON f.id_colaborador = c.id
                                WHERE
                                    f.ativo = 1 AND
                                    c.ativo = 1"
            };

            var listaFolhaPagamento = new List<FolhaPagamento>();

            try
            {
                cmd.Connection = conexao.Conectar();

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
                            DataCriacao = DateTime.Parse(dr["data_criacao"].ToString()),
                            Ativo = bool.Parse(dr["ativo"].ToString()),
                            Colaborador = new Colaborador
                            {
                                Id = int.Parse(dr["id_colaborador"].ToString()),
                                NomeCompleto = dr["nome_completo"].ToString(),
                                Sexo = (TipoSexo)char.Parse(dr["sexo"].ToString()),
                                Cargo = cargo,
                                Salario = decimal.Parse(dr["salario"].ToString()),
                                DataAdmissao = DateTime.Parse(dr["data_admissao"].ToString()),
                                Ativo = bool.Parse(dr["c_ativo"].ToString()),
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
                conexao.Desconectar();
            }

            return listaFolhaPagamento;
        }

        public FolhaPagamento BuscarPorColaborador(Colaborador colaborador)
        {
            var cmd = new SqlCommand
            {
                CommandText = @"SELECT f.id, f.inss, f.irrf, f.horas_extras, f.valor_horas_extras, f.valor_liquido, f.descontos_totais, f.vencimentos_totais, f.aliquota_inss, f.aliquota_irrf, f.data_criacao, f.ativo, c.id as id_colaborador, c.nome_completo, c.sexo, c.cargo, c.salario, c.data_admissao, c.ativo as c_ativo, c.id_empresa
                                FROM folha_pagamento f
                                    INNER JOIN colaborador c
                                    ON f.id_colaborador = c.id
                                WHERE
                                    f.ativo = 1 AND
                                    c.ativo = 1 AND
                                    c.id = @id_colaborador AND  
                                    YEAR(f.data_criacao) = @ano AND MONTH(f.data_criacao) = @mes"
            };

            cmd.Parameters.AddWithValue("@id_colaborador", colaborador.Id);
            cmd.Parameters.AddWithValue("@ano", DateTime.Now.Year);
            cmd.Parameters.AddWithValue("@mes", DateTime.Now.Month);

            try
            {
                cmd.Connection = conexao.Conectar();

                dr = cmd.ExecuteReader();

                if (dr.Read())
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
                        DataCriacao = DateTime.Parse(dr["data_criacao"].ToString()),
                        Ativo = bool.Parse(dr["ativo"].ToString()),
                        Colaborador = new Colaborador
                        {
                            Id = int.Parse(dr["id_colaborador"].ToString()),
                            NomeCompleto = dr["nome_completo"].ToString(),
                            Sexo = (TipoSexo)char.Parse(dr["sexo"].ToString()),
                            Cargo = cargo,
                            Salario = decimal.Parse(dr["salario"].ToString()),
                            DataAdmissao = DateTime.Parse(dr["data_admissao"].ToString()),
                            Ativo = bool.Parse(dr["c_ativo"].ToString()),
                            Empresa = new Empresa
                            {
                                Id = int.Parse(dr["id_empresa"].ToString()),
                            }
                        }
                    };

                    return folhaPagamento;
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

            return null;
        }
    }
}

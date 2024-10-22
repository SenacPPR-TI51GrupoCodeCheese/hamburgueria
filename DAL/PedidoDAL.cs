using MOD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PedidoDAL
    {
        public void Excluir(int id)
        {
            //Objeto de conexao com o banco de dados
            AcessoDados consulta = new AcessoDados();

            try
            {
                consulta.LimparParametros();

                string SQL = " DELETE FROM Pedido " +
                                " WHERE Id = @Id ";

                //Passagem dos valores para os parametros
                consulta.AdicionarParametro("@Id", SqlDbType.Int, id);

                consulta.ExecutaAtualizacao(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro banco de dados: " + ex.Message);
            }
        }

        public int Inserir(PedidoMOD objDados)
        {
            //Objeto de conexao com o banco de dados
            AcessoDados consulta = new AcessoDados();

            try
            {
                consulta.LimparParametros();

                string SQL = " INSERT INTO " +
                                " Pedido (CpfUsuario, MetPag, Total) " +
                             " VALUES " +
                                " (@CpfUsuario, @MetPag, @Total) " +
                             " DECLARE @IdPedido INT = SCOPE_IDENTITY() " +
                             " SELECT Id FROM Pedido WHERE Id = @IdPedido ";

                //Passagem dos valores para os parametros
                consulta.AdicionarParametro("@CpfUsuario", SqlDbType.VarChar, objDados.CpfUsuario);
                consulta.AdicionarParametro("@MetPag", SqlDbType.Char, objDados.MetPag);
                consulta.AdicionarParametro("@Total", SqlDbType.Decimal, objDados.Total);

                DataTable registros = consulta.ExecutaConsulta(SQL);

                var lista = new List<PedidoMOD>();
                PedidoMOD pedido = new PedidoMOD();

                foreach (DataRow linha in registros.Rows)
                {
                    pedido.Id = Convert.ToInt32(linha["id"]);
                    lista.Add(pedido);
                }

                return pedido.Id;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro banco de dados: " + ex.Message);
            }
        }

        public List<PedidoMOD> BuscaPorStatus(char status)
        {
            AcessoDados consulta = new AcessoDados();

            try
            {
                consulta.LimparParametros();
                string SQL = " SELECT Id, CpfUsuario, MetPag, Status, Total, DataPedido" +
                             " FROM Pedido " +
                                " WHERE Status " +
                                " LIKE @Status " +
                                    " ORDER BY DataPedido ";

                consulta.AdicionarParametro("@Status", SqlDbType.Char, status);

                DataTable registros = consulta.ExecutaConsulta(SQL);

                var lista = new List<PedidoMOD>();
                foreach (DataRow linha in registros.Rows)
                {
                    lista.Add(new PedidoMOD
                    {
                        Id = Convert.ToInt32(linha["Id"]),
                        CpfUsuario = Convert.ToString(linha["CpfUsuario"]),
                        MetPag = Convert.ToChar(linha["MetPag"]),
                        Status = Convert.ToChar(linha["Status"]),
                        Total = Convert.ToDouble(linha["Total"]),
                        DataPedido = Convert.ToDateTime(linha["DataPedido"])
                    });
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro do banco: " + ex.Message);
            }
        }

        public void Alterar(PedidoMOD objDados)
        {
            //Objeto de conexao com o banco de dados
            AcessoDados consulta = new AcessoDados();

            try
            {
                consulta.LimparParametros();

                string SQL = " UPDATE Pedido " +
                                " SET Nome = @Nome, Preco = @Preco, Descricao = @Descricao, StatusPedido = @StatusPedido," +
                                    " WHERE Id = @Id ";

                //Passagem dos valores para os parametros
                //consulta.AdicionarParametro("@Nome", SqlDbType.VarChar, objDados.Nome);
                //consulta.AdicionarParametro("@Preco", SqlDbType.VarChar, objDados.Preco);
                //consulta.AdicionarParametro("@Descricao", SqlDbType.VarChar, objDados.Descricao);
                //consulta.AdicionarParametro("@StatusPedido", SqlDbType.VarChar, objDados.SituacaoPedido);      

                consulta.ExecutaAtualizacao(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro banco de dados: " + ex.Message);
            }
        }
    }
}

using MOD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SacolaDAL
    {
        public int Inserir(PedidoMOD objDados)
        {
            //Objeto de conexao com o banco de dados
            AcessoDados consulta = new AcessoDados();

            try
            {
                consulta.LimparParametros();

                string SQL = " INSERT INTO " +
                                " Sacola (CpfUsuario, MetPag, Total) " +
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
    }
}

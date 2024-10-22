using MOD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ItensSacolaDAL
    {
        public void Inserir(ItensSacolaMOD objDados)
        {
            //Objeto de conexao com o banco de dados
            AcessoDados consulta = new AcessoDados();

            try
            {
                consulta.LimparParametros();

                string SQL = " INSERT INTO " +
                                " Itens (Id, IdSacola, IdProduto)" +
                             " VALUES " +
                                " (@Id, @IdSacola, @IdProduto) ";

                //Passagem dos valores para os parametros
                consulta.AdicionarParametro("@Id", SqlDbType.VarChar, objDados.Id);
                consulta.AdicionarParametro("@IdSacola", SqlDbType.Decimal, objDados.IdSacola);
                consulta.AdicionarParametro("@IdProduto", SqlDbType.VarChar, objDados.IdProduto);

                consulta.ExecutaAtualizacao(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro banco de dados: " + ex.Message);
            }
        }

        public void Excluir(int id)
        {
            //Objeto de conexao com o banco de dados
            AcessoDados consulta = new AcessoDados();

            try
            {
                consulta.LimparParametros();

                string SQL = " DELETE FROM Itens " +
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

        public List<ItensSacolaMOD> BuscarPorId(string id)
        {
            AcessoDados consulta = new AcessoDados();

            try
            {
                consulta.LimparParametros();
                string SQL = " SELECT Id, IdSacola, IdProduto " +
                             " FROM Itens LEFT OUTER JOIN Sacola" +
                             " ON Itens.IdSacola = Sacola.Id " +
                                " WHERE Itens.IdSacola = @IdSacola ";

                consulta.AdicionarParametro("@IdSacola", SqlDbType.VarChar, id);

                DataTable registros = consulta.ExecutaConsulta(SQL);

                var lista = new List<ItensSacolaMOD>();
                foreach (DataRow linha in registros.Rows)
                {
                    lista.Add(new ItensSacolaMOD
                    {
                        Id = Convert.ToInt32(linha["Id"]),
                        IdSacola = Convert.ToInt32(linha["IdSacola"]),
                        IdProduto = Convert.ToInt32(linha["IdProduto"]),
                    });
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro do banco: " + ex.Message);
            }
        }

        public List<ItensSacolaMOD> BuscarPorIdSacola(string idSacola)
        {
            AcessoDados consulta = new AcessoDados();

            try
            {
                consulta.LimparParametros();
                string SQL = " SELECT Id, IdSacola, IdProduto " +
                             " FROM Itens LEFT OUTER JOIN Sacola" +
                             " ON Itens.IdSacola = Sacola.Id " +
                                " WHERE Itens.IdSacola = @IdSacola ";

                consulta.AdicionarParametro("@IdSacola", SqlDbType.VarChar, idSacola);

                DataTable registros = consulta.ExecutaConsulta(SQL);

                var lista = new List<ItensSacolaMOD>();
                foreach (DataRow linha in registros.Rows)
                {
                    lista.Add(new ItensSacolaMOD
                    {
                        Id = Convert.ToInt32(linha["Id"]),
                        IdSacola = Convert.ToInt32(linha["IdSacola"]),
                        IdProduto = Convert.ToInt32(linha["IdProduto"]),
                    });
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro do banco: " + ex.Message);
            }
        }
    }
}

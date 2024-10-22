using MOD;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProdutoDAL
    {
        public void Inserir(ProdutoMOD objDados)
        {
            //Objeto de conexao com o banco de dados
            AcessoDados consulta = new AcessoDados();

            try
            {
                consulta.LimparParametros();

                string SQL = " INSERT INTO " +
                                " Produto (Nome, Preco, Descricao, Ingredientes, Foto, Tipo)" +
                             " VALUES " +
                                " (@Nome, @Preco, @Descricao, @Ingredientes, @Foto, @Tipo) ";

                //Passagem dos valores para os parametros
                consulta.AdicionarParametro("@Nome", SqlDbType.VarChar, objDados.Nome);
                consulta.AdicionarParametro("@Preco", SqlDbType.Decimal, objDados.Preco);
                consulta.AdicionarParametro("@Descricao", SqlDbType.VarChar, objDados.Descricao);
                consulta.AdicionarParametro("@Ingredientes", SqlDbType.VarChar, objDados.Ingredientes);

                if (objDados.Foto != null)
                {
                    consulta.AdicionarParametro("@Foto", SqlDbType.Image, objDados.Foto);
                }
                else
                {
                    consulta.AdicionarParametro("@Foto", SqlDbType.Image, DBNull.Value);
                }

                consulta.AdicionarParametro("@Tipo", SqlDbType.Char, objDados.Tipo);

                consulta.ExecutaAtualizacao(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro banco de dados: " + ex.Message);
            }
        }

        public byte[] CarregaFoto(int Codigo)
        {
            AcessoDados consulta = new AcessoDados();

            try
            {
                consulta.LimparParametros();
                string SQL = " SELECT Foto " +
                             " FROM Produto WHERE ID = @ID";

                consulta.AdicionarParametro("@ID", SqlDbType.Int, Codigo);

                DataTable registros = consulta.ExecutaConsulta(SQL);

                byte[] vetorImagem = null;

                var listaProduto = new List<ProdutoMOD>();
                foreach (DataRow linha in registros.Rows)
                {
                    if (linha["Foto"] != DBNull.Value)
                    {
                        vetorImagem = (byte[])(linha["Foto"]);
                    }
                }
                return (vetorImagem);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro do banco: " + ex.Message);
            }
        }

        public void Alterar(ProdutoMOD objDados)
        {
            //Objeto de conexao com o banco de dados
            AcessoDados consulta = new AcessoDados();

            try
            {
                consulta.LimparParametros();
                string SQLImg = objDados.Foto != null ? ", Foto = @Foto, " : ", ";
                string SQL = " UPDATE Produto" +
                                " SET Nome = @Nome, Preco = @Preco, Descricao = @Descricao, Ingredientes = @Ingredientes" + SQLImg + "Tipo = @Tipo" +
                                    " WHERE Id = @Id"; 

                //Passagem dos valores para os parametros
                consulta.AdicionarParametro("@Id", SqlDbType.Int, objDados.Id);
                consulta.AdicionarParametro("@Nome", SqlDbType.VarChar, objDados.Nome);
                consulta.AdicionarParametro("@Preco", SqlDbType.Decimal, objDados.Preco);
                consulta.AdicionarParametro("@Descricao", SqlDbType.VarChar, objDados.Descricao);
                consulta.AdicionarParametro("@Ingredientes", SqlDbType.VarChar, objDados.Ingredientes);
                consulta.AdicionarParametro("@Tipo", SqlDbType.VarChar, objDados.Tipo);

                if (objDados.Foto != null)
                {
                    consulta.AdicionarParametro("@Foto", SqlDbType.Image, objDados.Foto);
                }

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

                string SQL = " DELETE FROM Produto " +
                                " WHERE ID = @ID ";

                //Passagem dos valores para os parametros
                consulta.AdicionarParametro("@ID", SqlDbType.Int, id);

                consulta.ExecutaAtualizacao(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro banco de dados: " + ex.Message);
            }
        }

        public List<ProdutoMOD> BuscarPorNome(string nome)
        {
            AcessoDados consulta = new AcessoDados();

            try
            {
                consulta.LimparParametros();
                string SQL = " SELECT Id, Nome, Preco, Descricao, Ingredientes, Foto, Tipo" +
                             " FROM Produto " +
                                " WHERE Nome " +
                                " LIKE @Nome " +
                                    " ORDER BY Nome ";

                consulta.AdicionarParametro("@Nome", SqlDbType.VarChar, nome + "%");

                DataTable registros = consulta.ExecutaConsulta(SQL);

                var lista = new List<ProdutoMOD>();
                foreach (DataRow linha in registros.Rows)
                {
                    lista.Add(new ProdutoMOD
                    {
                        Id = Convert.ToInt32(linha["Id"]),
                        Nome = Convert.ToString(linha["Nome"]),
                        Preco = Convert.ToDouble(linha["Preco"]),
                        Descricao = Convert.ToString(linha["Descricao"]),
                        Ingredientes = Convert.ToString(linha["Ingredientes"]),
                        Foto = CarregaFoto(Convert.ToInt32(linha["Id"])),
                        Tipo = Convert.ToChar(linha["Tipo"])
                    });
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro do banco: " + ex.Message);
            }
        }
        public List<ProdutoMOD> BuscarPorTipo(string tipo)
        {
            AcessoDados consulta = new AcessoDados();

            try
            {
                consulta.LimparParametros();
                string SQL = " SELECT Id, Nome, Preco, Descricao, Ingredientes, Foto, Tipo" +
                             " FROM Produto " +
                                " WHERE Tipo " +
                                " LIKE @Tipo " +
                                    " ORDER BY Nome ";

                consulta.AdicionarParametro("@Tipo", SqlDbType.VarChar, tipo);

                DataTable registros = consulta.ExecutaConsulta(SQL);

                var lista = new List<ProdutoMOD>();
                foreach (DataRow linha in registros.Rows)
                {
                    lista.Add(new ProdutoMOD
                    {
                        Id = Convert.ToInt32(linha["Id"]),
                        Nome = Convert.ToString(linha["Nome"]),
                        Preco = Convert.ToDouble(linha["Preco"]),
                        Descricao = Convert.ToString(linha["Descricao"]),
                        Ingredientes = Convert.ToString(linha["Ingredientes"]),
                        Foto = CarregaFoto(Convert.ToInt32(linha["Id"])),
                        Tipo = Convert.ToChar(linha["Tipo"])
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

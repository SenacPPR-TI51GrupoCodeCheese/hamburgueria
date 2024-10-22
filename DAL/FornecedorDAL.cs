using MOD;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FornecedorDAL
    {
        public List<FornecedorMOD> BuscaPorNome(string nome)
        {
            AcessoDados consulta = new AcessoDados();

            try
            {
                consulta.LimparParametros();
                string SQL = " SELECT Id, Empresa, NomeFantasia, cnpj, telefone, endereco " +
                             " FROM Fornecedor " +
                                " WHERE Empresa " +
                                " LIKE @Empresa " +
                                    " ORDER BY Empresa ";

                consulta.AdicionarParametro("@Empresa", SqlDbType.VarChar, nome + "%");

                DataTable registros = consulta.ExecutaConsulta(SQL);

                var lista = new List<FornecedorMOD>();
                foreach (DataRow linha in registros.Rows)
                {
                    lista.Add(new FornecedorMOD
                    {
                        Id = Convert.ToInt32(linha["Id"]),
                        Empresa = Convert.ToString(linha["Empresa"]),
                        NomeFantasia = Convert.ToString(linha["NomeFantasia"]),
                        Cnpj = Convert.ToString(linha["Cnpj"]),
                        Telefone = Convert.ToString(linha["Telefone"]),
                        Endereco = Convert.ToString(linha["Endereco"]),
                    });
                }
                return lista;

            }
            catch (Exception ex)
            {
                throw new Exception("Erro do banco: " + ex.Message);
            }

        }
        public void Excluir(int id)
        {
            AcessoDados consulta = new AcessoDados();
            try
            {
                consulta.LimparParametros();

                string SQL = " DELETE FROM Fornecedor WHERE Id = @Id ";

                consulta.AdicionarParametro("@Id", SqlDbType.Int, id);

                consulta.ExecutaAtualizacao(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro banco de dados: " + ex.Message);
            }
        }
        public void Inserir(FornecedorMOD objDados)
        {
            //Objeto de conexao com o banco de dados
            AcessoDados consulta = new AcessoDados();

            try
            {
                consulta.LimparParametros();

                string SQL = " INSERT INTO " +
                                " Fornecedor (Empresa, NomeFantasia, cnpj, telefone, endereco) " +
                             " VALUES " +
                                " (@Empresa, @NomeFantasia, @cnpj, @telefone, @Endereco) ";

                //Passagem dos valores para os parametros
                consulta.AdicionarParametro("@Empresa", SqlDbType.VarChar, objDados.Empresa);
                consulta.AdicionarParametro("@NomeFantasia", SqlDbType.VarChar, objDados.NomeFantasia);
                consulta.AdicionarParametro("@cnpj", SqlDbType.VarChar, objDados.Cnpj);
                consulta.AdicionarParametro("@telefone", SqlDbType.VarChar, objDados.Telefone);
                consulta.AdicionarParametro("@endereco", SqlDbType.VarChar, objDados.Endereco);


                consulta.ExecutaAtualizacao(SQL);

            }
            catch (Exception ex)
            {
                throw new Exception("Erro banco de dados: " + ex.Message);
            }

        }
        public void Alterar(FornecedorMOD objDados)
        {
            //Objeto de conexao com o banco de dados
            AcessoDados consulta = new AcessoDados();

            try
            {
                consulta.LimparParametros();

                string SQL = " UPDATE Fornecedor " +
                                " SET Empresa = @Empresa, NomeFantasia = @NomeFantasia, cnpj = @cnpj, telefone = @telefone, emdereco = @endereco " +
                                    " WHERE Id = @Id ";

                //Passagem dos valores para os parametros
                consulta.AdicionarParametro("@Empresa", SqlDbType.VarChar, objDados.Empresa);
                consulta.AdicionarParametro("@NomeFantasia", SqlDbType.VarChar, objDados.NomeFantasia);
                consulta.AdicionarParametro("@cnpj", SqlDbType.VarChar, objDados.Cnpj);
                consulta.AdicionarParametro("@telefone", SqlDbType.VarChar, objDados.Telefone);
                consulta.AdicionarParametro("@endereco", SqlDbType.VarChar, objDados.Endereco);

                consulta.ExecutaAtualizacao(SQL);

            }
            catch (Exception ex)
            {
                throw new Exception("Erro banco de dados: " + ex.Message);
            }
        }
    }
}

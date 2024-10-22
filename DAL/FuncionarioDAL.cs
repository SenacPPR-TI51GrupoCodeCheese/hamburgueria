using MOD;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FuncionarioDAL
    {
        public List<FuncionarioMOD> BuscaPorNome(string nome)
        {
            AcessoDados consulta = new AcessoDados();

            try
            {
                consulta.LimparParametros();
                string SQL = " SELECT Nome, Cpf, Cargo, Endereco, Sexo, DataNascimento " +
                             " FROM Funcionario " +
                                " WHERE Nome " +
                                " LIKE @Nome " +
                                    " ORDER BY Nome ";

                consulta.AdicionarParametro("@Nome", SqlDbType.VarChar, nome + "%");

                DataTable registros = consulta.ExecutaConsulta(SQL);

                var lista = new List<FuncionarioMOD>();
                foreach (DataRow linha in registros.Rows)
                {
                    lista.Add(new FuncionarioMOD
                    {
                        Nome = Convert.ToString(linha["Nome"]),
                        CPF = Convert.ToString(linha["CPF"]),
                        Endereco = Convert.ToString(linha["Endereco"]),
                        DataNascimento = Convert.ToDateTime(linha["DataNascimento"]),
                        Sexo = Convert.ToString(linha["Sexo"]),
                        Cargo = Convert.ToString(linha["Cargo"]),
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

                string SQL = " DELETE FROM Funcionario WHERE Id = @Id ";

                consulta.AdicionarParametro("@Id", SqlDbType.Int, id);

                consulta.ExecutaAtualizacao(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro banco de dados: " + ex.Message);
            }
        }
        public void Inserir(FuncionarioMOD objDados)
        {
            //Objeto de conexao com o banco de dados
            AcessoDados consulta = new AcessoDados();

            try
            {
                consulta.LimparParametros();

                string SQL = " INSERT INTO " +
                                " Funcionario (Nome, Cpf, Cargo, Endereco, Sexo, DataNascimento) " +
                             " VALUES " +
                                " (@Nome, @Cpf, @Cargo, @Endereco, @Sexo, @DataNascimento) ";

                //Passagem dos valores para os parametros
                consulta.AdicionarParametro("@Nome", SqlDbType.VarChar, objDados.Nome);
                consulta.AdicionarParametro("@Cpf", SqlDbType.VarChar, objDados.CPF);
                consulta.AdicionarParametro("@Cargo", SqlDbType.VarChar, objDados.Cargo);
                consulta.AdicionarParametro("@Endereco", SqlDbType.VarChar, objDados.Endereco);
                consulta.AdicionarParametro("@Sexo", SqlDbType.VarChar, objDados.Sexo);
                consulta.AdicionarParametro("@DataNascimento", SqlDbType.DateTime, objDados.DataNascimento);

                consulta.ExecutaAtualizacao(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro banco de dados: " + ex.Message);
            }
        }
        public void Alterar(FuncionarioMOD objDados)
        {
            //Objeto de conexao com o banco de dados
            AcessoDados consulta = new AcessoDados();

            try
            {
                consulta.LimparParametros();

                string SQL = " UPDATE Funcionario " +
                                " SET Nome = @Nome, CPF = @CPF, Cargo = @Cargo, Endereco = @Endereco, Sexo = @Sexo, DataNascimento = @DataNascimento " +
                                    " WHERE Id = @Id ";

                //Passagem dos valores para os parametros
                consulta.AdicionarParametro("@Id", SqlDbType.VarChar, objDados.ID);
                consulta.AdicionarParametro("@Nome", SqlDbType.VarChar, objDados.Nome);
                consulta.AdicionarParametro("@CPF", SqlDbType.VarChar, objDados.CPF);
                consulta.AdicionarParametro("@Cargo", SqlDbType.VarChar, objDados.Cargo);
                consulta.AdicionarParametro("@Endereco", SqlDbType.VarChar, objDados.Endereco);
                consulta.AdicionarParametro("@Sexo", SqlDbType.VarChar, objDados.Sexo);
                consulta.AdicionarParametro("@DataNascimento", SqlDbType.DateTime, objDados.DataNascimento);

                consulta.ExecutaAtualizacao(SQL);

            }
            catch (Exception ex)
            {
                throw new Exception("Erro banco de dados: " + ex.Message);
            }
        }
    }
}

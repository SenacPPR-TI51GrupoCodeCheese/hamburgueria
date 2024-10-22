using MOD;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AdministradorDAL
    {
        public List<AdministradorMOD> BuscaPorLogin(string login)
        {
            AcessoDados consulta = new AcessoDados();

            try
            {
                consulta.LimparParametros();
                string SQL = " SELECT Id, Nome, Cpf, Login " +
                             " FROM Administrador " +
                                " WHERE Login " +
                                " LIKE @Login " +
                                    " ORDER BY Login ";

                consulta.AdicionarParametro("@Login", SqlDbType.VarChar, login + "%");

                DataTable registros = consulta.ExecutaConsulta(SQL);

                var lista = new List<AdministradorMOD>();
                foreach (DataRow linha in registros.Rows)
                {
                    lista.Add(new AdministradorMOD
                    {
                        Id = Convert.ToInt32(linha["Id"]),
                        NomeCompleto = Convert.ToString(linha["Nome"]),
                        Cpf = Convert.ToString(linha["Cpf"]),
                        Login = Convert.ToString(linha["Login"]),
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

                string SQL = " DELETE FROM Administrador WHERE Id = @Id ";

                consulta.AdicionarParametro("@Id", SqlDbType.Int, id);

                consulta.ExecutaAtualizacao(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro banco de dados: " + ex.Message);
            }
        }
        public void Inserir(AdministradorMOD objDados)
        {
            //Objeto de conexao com o banco de dados
            AcessoDados consulta = new AcessoDados();

            try
            {
                consulta.LimparParametros();

                string SQL = " INSERT INTO " +
                                " Administrador (nome, cpf, login, senha) " +
                             " VALUES " +
                                " (@nome, @cpf, @login, @senha) ";

                //Passagem dos valores para os parametros
                consulta.AdicionarParametro("@cpf", SqlDbType.VarChar, objDados.Cpf);
                consulta.AdicionarParametro("@nome", SqlDbType.VarChar, objDados.NomeCompleto);
                consulta.AdicionarParametro("@login", SqlDbType.VarChar, objDados.Login);
                consulta.AdicionarParametro("@senha", SqlDbType.VarChar, objDados.Senha);


                consulta.ExecutaAtualizacao(SQL);

            }
            catch (Exception ex)
            {
                throw new Exception("Erro banco de dados: " + ex.Message);
            }

        }
        public void Alterar(AdministradorMOD objDados)
        {
            //Objeto de conexao com o banco de dados
            AcessoDados consulta = new AcessoDados();

            try
            {
                consulta.LimparParametros();

                string SQL = " UPDATE Administrador " +
                                " SET Nome = @Nome, Cpf = @Cpf, Senha = @Senha" +
                                    " WHERE Id = @Id ";

                //Passagem dos valores para os parametros               
                consulta.AdicionarParametro("@Nome", SqlDbType.VarChar, objDados.NomeCompleto);
                consulta.AdicionarParametro("@cpf", SqlDbType.VarChar, objDados.Cpf);          
                consulta.AdicionarParametro("@senha", SqlDbType.VarChar, objDados.Senha);

                consulta.ExecutaAtualizacao(SQL);

            }
            catch (Exception ex)
            {
                throw new Exception("Erro banco de dados: " + ex.Message);
            }
        }
        public int Login(string login, string senha)
        {
            AcessoDados consulta = new AcessoDados();

            try
            {
                consulta.LimparParametros();
                string SQL = " SELECT Id " +
                             " FROM Administrador " +
                                " WHERE Login = @Login" +
                                    " AND Senha = @Senha ";

                consulta.AdicionarParametro("@Login", SqlDbType.VarChar, login);
                consulta.AdicionarParametro("@Senha", SqlDbType.VarChar, senha);

                DataTable registros = consulta.ExecutaConsulta(SQL);

                int id = 0;
                foreach (DataRow linha in registros.Rows)
                {
                    id = Convert.ToInt32(linha["Id"]);
                }
                return id;

            }
            catch (Exception ex)
            {
                throw new Exception("Erro do banco: " + ex.Message);
            }
        }
    }
}

using MOD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UsuarioDAL
    {
        public void ExcluirPorId(int id)
        {
            //Objeto de conexao com o banco de dados
            AcessoDados consulta = new AcessoDados();

            try
            {
                consulta.LimparParametros();

                string SQL = "DELETE FROM Usuario " +
                                "WHERE Id = @Id";

                //Passagem dos valores para os parametros
                consulta.AdicionarParametro("@Id", SqlDbType.Int, id);

                consulta.ExecutaAtualizacao(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro banco de dados: " + ex.Message);
            }
        }

        public void ExcluirConvidado()
        {
            //Objeto de conexao com o banco de dados
            AcessoDados consulta = new AcessoDados();

            try
            {
                consulta.LimparParametros();

                string SQL = " DELETE FROM Usuario" +
                                " WHERE NomeHost = host_name() AND Convidado = (1)";

                consulta.ExecutaAtualizacao(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro banco de dados: " + ex.Message);
            }
        }

        public void Inserir(UsuarioMOD mod)
        {
            //Objeto de conexao com o banco de dados
            AcessoDados consulta = new AcessoDados();

            try
            {
                consulta.LimparParametros();

                string SQL = " INSERT INTO " +
                                " Usuario (NomeCompleto, NomeUsuario, Email, Cpf, Telefone, Nascimento, Genero, Endereco, Pontos, Senha, Convidado) " +
                             " VALUES " +
                                " (@NomeCompleto, @NomeUsuario, @Email, @Cpf, @Telefone, @Nascimento, @Genero, @Endereco, @Pontos, @Senha, @Convidado) ";

                //Passagem dos valores para os parametros
                consulta.AdicionarParametro("@NomeCompleto", SqlDbType.VarChar, mod.NomeCompleto);
                consulta.AdicionarParametro("@NomeUsuario", SqlDbType.VarChar, mod.NomeUsuario);
                consulta.AdicionarParametro("@Email", SqlDbType.VarChar, mod.Email);
                consulta.AdicionarParametro("@Cpf", SqlDbType.VarChar, mod.Cpf);
                consulta.AdicionarParametro("@Telefone", SqlDbType.VarChar, mod.Telefone);
                consulta.AdicionarParametro("@Nascimento", SqlDbType.DateTime, mod.Nascimento);
                consulta.AdicionarParametro("@Genero", SqlDbType.Char, mod.Genero);
                consulta.AdicionarParametro("@Endereco", SqlDbType.VarChar, mod.Endereco);
                consulta.AdicionarParametro("@Pontos", SqlDbType.Int, mod.Pontos);
                consulta.AdicionarParametro("@Senha", SqlDbType.VarChar, mod.Senha);
                consulta.AdicionarParametro("@Convidado", SqlDbType.Bit, mod.Convidado);

                consulta.ExecutaAtualizacao(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro banco de dados: " + ex.Message);
            }
        }

        public List<UsuarioMOD> BuscaPorNome(string nome)
        {
            AcessoDados consulta = new AcessoDados();

            try
            {
                consulta.LimparParametros();
                string SQL = " SELECT Id, NomeCompleto, NomeUsuario, Email, Cpf, Telefone, Nascimento, Genero, Endereco, Pontos, Senha, Convidado " +
                             " FROM Usuario " +
                                " WHERE Nome " +
                                " LIKE @Nome " +
                                    " ORDER BY Nome ";

                consulta.AdicionarParametro("@Nome", SqlDbType.VarChar, nome + "%");

                DataTable registros = consulta.ExecutaConsulta(SQL);

                var lista = new List<UsuarioMOD>();
                foreach (DataRow linha in registros.Rows)
                {
                    lista.Add(new UsuarioMOD
                    {
                        Id = Convert.ToInt32(linha["Id"]),
                        NomeCompleto = Convert.ToString(linha["NomeCompleto"]),
                        NomeUsuario = Convert.ToString(linha["NomeUsuario"]),
                        Email = Convert.ToString(linha["Email"]),
                        Cpf = Convert.ToString(linha["Cpf"]),
                        Telefone = Convert.ToString(linha["Telefone"]),
                        Nascimento = Convert.ToDateTime(linha["Nascimento"]),
                        Genero = Convert.ToChar(linha["Genero"]),
                        Endereco = Convert.ToString(linha["Endereco"]),
                        Pontos = Convert.ToInt16(linha["Pontos"]),
                        Senha = Convert.ToString(linha["Senha"]),
                        Convidado = Convert.ToBoolean(linha["Convidado"])
                    });
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro do banco: " + ex.Message);
            }

        }

        public int Login(string login, string senha)
        {
            AcessoDados consulta = new AcessoDados();

            try
            {
                consulta.LimparParametros();
                string SQL = " SELECT Id " +
                             " FROM Usuario " +
                                " WHERE NomeUsuario = @NomeUsuario " +
                                    " AND Senha = @Senha ";

                consulta.AdicionarParametro("@NomeUsuario", SqlDbType.VarChar, login);
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
        public int LoginTotem(string cpf)
        {
            AcessoDados consulta = new AcessoDados();

            try
            {
                consulta.LimparParametros();
                string SQL = " SELECT Id " +
                             " FROM Usuario " +
                                " WHERE Cpf = @Cpf ";

                consulta.AdicionarParametro("@Cpf", SqlDbType.VarChar, cpf);

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

        public void Alterar(UsuarioMOD mod)
        {
            //Objeto de conexao com o banco de dados
            AcessoDados consulta = new AcessoDados();

            try
            {
                consulta.LimparParametros();

                string SQL = " UPDATE Usuario " +
                                " SET NomeCompleto = @NomeCompleto," +
                                    " NomeUsuario = @NomeUsuario," +
                                    " Email = @Email," +
                                    " Cpf = @Cpf," +
                                    " Telefone = @Telefone," +
                                    " Nascimento = @Nascimento," +
                                    " Genero = @Genero," +
                                    " Endereco = @Endereco," +
                                    " Pontos = @Pontos," +
                                    " Senha = @Senha" +
                                    " Convidado = @Convidado" +
                                        " WHERE Id = @Id ";

                //Passagem dos valores para os parametros
                consulta.AdicionarParametro("@NomeCompleto", SqlDbType.VarChar, mod.NomeCompleto);
                consulta.AdicionarParametro("@NomeUsuario", SqlDbType.VarChar, mod.NomeUsuario);
                consulta.AdicionarParametro("@Email", SqlDbType.VarChar, mod.Email);
                consulta.AdicionarParametro("@Cpf", SqlDbType.VarChar, mod.Cpf);
                consulta.AdicionarParametro("@Telefone", SqlDbType.VarChar, mod.Telefone);
                consulta.AdicionarParametro("@Nascimento", SqlDbType.DateTime, mod.Nascimento);
                consulta.AdicionarParametro("@Genero", SqlDbType.Char, mod.Genero);
                consulta.AdicionarParametro("@Endereco", SqlDbType.VarChar, mod.Endereco);
                consulta.AdicionarParametro("@Pontos", SqlDbType.Int, mod.Pontos);
                consulta.AdicionarParametro("@Senha", SqlDbType.VarChar, mod.Senha);
                consulta.AdicionarParametro("@Convidado", SqlDbType.Bit, mod.Convidado);


                consulta.ExecutaAtualizacao(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro banco de dados: " + ex.Message);
            }
        }
    }
}

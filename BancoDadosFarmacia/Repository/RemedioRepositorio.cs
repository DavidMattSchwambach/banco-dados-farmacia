using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Repository
{
     public class RemedioRepositorio
    {
        string CadeiaConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\65972\Documents\ExeploBancoDados02.mdf;Integrated Security=True;Connect Timeout=30";

        public DataTable DataTable { get; private set; }

        public void Inserir(Remedio remedio)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "INSERT INTO remedios(generico, nome, categoria, solido, contra_indicacoes, bula, faixa, precisa_receita)" +
            "VALUES (@GENERICO, @NOME, @CATEGORIA, @SOLIDO, @CONTRA_INDICACOES, @BULA, @FAIXA, @PRECISA_RECEITA)";
            comando.Parameters.AddWithValue("@GENERICO", remedio.Generico);
            comando.Parameters.AddWithValue("@NOME", remedio.Nome);
            comando.Parameters.AddWithValue("@CATEGORIA", remedio.Categoria);
            comando.Parameters.AddWithValue("@SOLIDO", remedio.Solido);
            comando.Parameters.AddWithValue("@CONTRA_INDICACOES", remedio.ContraIndicacoes);
            comando.Parameters.AddWithValue("@BULA", remedio.Bula);
            comando.Parameters.AddWithValue("@FAIXA", remedio.Faixa);
            comando.Parameters.AddWithValue("@PRECISA_RECEITA", remedio.PrecisaReceita);
            comando.ExecuteNonQuery();
            conexao.Close();

        }

        public List<Remedio> ObterTodos()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "SELECT * FROM remedios";

            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());

            List<Remedio> remedios = new List<Remedio>();
            for (int i = 0; i < tabela.Rows.Count; i++)
            {
                DataRow linha = tabela.Rows[i];
                Remedio remedio = new Remedio();

                remedio.Id = Convert.ToInt32(linha["id"]);
                remedio.Generico = Convert.ToBoolean(linha["generico"]);
                remedio.Nome = linha["nome"].ToString();
                remedio.Categoria = linha["categoria"].ToString();
                remedio.Solido = Convert.ToBoolean(linha["solido"]);
                remedio.ContraIndicacoes = linha["contra_indicacoes"].ToString();
                remedio.Bula = linha["bula"].ToString();
                remedio.Faixa = linha["faixa"].ToString();
                remedio.PrecisaReceita = Convert.ToBoolean(linha["precisa_receita"]);
                remedios.Add(remedio);
            }
            conexao.Close();
            return remedios;

        }

        public Remedio ObterPeloId(int id)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "SELECT * FROM remedios WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", id);

            DataTable = new DataTable();
            DataTable.Load(comando.ExecuteReader());
            conexao.Close();

            if (DataTable.Rows.Count == 1)
            {
                DataRow Linha = DataTable.Rows[0];
                Remedio remedio = new Remedio();


                remedio.Id = Convert.ToInt32(Linha["id"]);
                remedio.Generico = Convert.ToBoolean(Linha["generico"]);
                remedio.Nome = Linha["nome"].ToString();
                remedio.Categoria = Linha["categoria"].ToString();
                remedio.Solido = Convert.ToBoolean(Linha["solido"]);
                remedio.ContraIndicacoes = Linha["contra_indicacoes"].ToString();
                remedio.Bula = Linha["bula"].ToString();
                remedio.Faixa = Linha["faixa"].ToString();
                remedio.PrecisaReceita = Convert.ToBoolean(Linha["precisa_receita"]);
                return remedio;

            }
            return null;
        }

        public void Apagar (int id)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "DELETE FROM remedios WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);
            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public void Atualizar(Remedio remedio)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "UPDATE remedios SET generico = @GENERICO, nome = @NOME, categoria = @CATEGORIA, solido = @SOLIDO, contra_indicacoes = @CONTRA_INDICACOES, bula = @BULA, faixa = @FAIXA, precisa_receita = @PRECISA_RECEITA";

            comando.Parameters.AddWithValue("@GENERICO", remedio.Generico);
            comando.Parameters.AddWithValue("@NOME", remedio.Nome);
            comando.Parameters.AddWithValue("@CATEGORIA", remedio.Categoria);
            comando.Parameters.AddWithValue("@SOLIDO", remedio.Solido);
            comando.Parameters.AddWithValue("@CONTRA_INDICACOES", remedio.ContraIndicacoes);
            comando.Parameters.AddWithValue("@BULA", remedio.Bula);
            comando.Parameters.AddWithValue("@FAIXA", remedio.Faixa);
            comando.Parameters.AddWithValue("@PRECISA_RECEITA", remedio.PrecisaReceita);
            comando.Parameters.AddWithValue("@ID", remedio.Id);
            comando.ExecuteNonQuery();
            conexao.Close();

        }
    }
}

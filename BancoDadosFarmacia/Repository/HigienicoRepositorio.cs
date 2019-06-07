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
    public class HigienicoRepositorio
    {
        string CadeiaConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\65972\Documents\ExeploBancoDados02.mdf;Integrated Security=True;Connect Timeout=30";

        public DataTable DataTable { get; private set; }

        public void Inserir(Higienico higienico)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "INSERT INTO higienicos(nome, categoria, preco) VALUES (@NOME, @CATEGORIA, @PRECO)";
            comando.Parameters.AddWithValue("@NOME", higienico.Nome);
            comando.Parameters.AddWithValue("@CATEGORIA", higienico.Categoria);
            comando.Parameters.AddWithValue("@PRECO", higienico.Preco);
            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public List<Higienico> ObterTodos()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "SELECT * FROM higienicos";

            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());

            List<Higienico> higienicos = new List<Higienico>();
            for (int i = 0; i < tabela.Rows.Count; i++)
            {
                DataRow linha = tabela.Rows[i];
                Higienico higienico = new Higienico();

                higienico.Id = Convert.ToInt32(linha["id"]);
                higienico.Nome = linha["nome"].ToString();
                higienico.Categoria = linha["categoria"].ToString();
                higienico.Preco = Convert.ToDouble(linha["preco"]);
                higienicos.Add(higienico);
            }
            conexao.Close();
            return higienicos;
        }

        public Higienico ObterPeloId(int id)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "SELECT * FROM higienicos WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            DataTable = new DataTable();
            DataTable.Load(comando.ExecuteReader());
            conexao.Close();

            if (DataTable.Rows.Count == 1)
            {
                DataRow Linha = DataTable.Rows[0];
                Higienico higienico = new Higienico();

                higienico.Id = Convert.ToInt32(Linha["id"]);
                higienico.Nome = Linha["nome"].ToString();
                higienico.Categoria = Linha["categoria"].ToString();
                higienico.Preco = Convert.ToDouble(Linha["preco"]);
                return higienico;
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
            comando.CommandText = "DELETE FROM higienicos WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);
            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public void Atualizar(Higienico higienico)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "UPDATE higienicos SET nome = @NOME, categoria = @CATEGORIA, preco = @PRECO  WHERE id = @ID";
            comando.Parameters.AddWithValue("@NOME", higienico.Nome);
            comando.Parameters.AddWithValue("@CATEGORIA", higienico.Categoria);
            comando.Parameters.AddWithValue("@PRECO", higienico.Preco);
            comando.Parameters.AddWithValue("@ID", higienico.Id);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
    }
}

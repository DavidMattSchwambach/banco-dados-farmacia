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

    public class ComestivelRepositorio
    {
        string CadeiaConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\65972\Documents\ExeploBancoDados02.mdf;Integrated Security=True;Connect Timeout=30";
        public DataTable DataTable { get; private set; }

        public void Inserir(Comestivel comestivel)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "INSERT INTO comestiveis(nome, valor, data_vencimento, quantidade, marca)" +
               "VALUES (@NOME, @VALOR, @DATA_VENCIMENTO, @QUANTIDADE, @MARCA)";
            comando.Parameters.AddWithValue("@NOME", comestivel.Nome);
            comando.Parameters.AddWithValue("@VALOR", comestivel.Valor);
            comando.Parameters.AddWithValue("@DATA_VENCIMENTO", comestivel.DataVencimento);
            comando.Parameters.AddWithValue("@QUANTIDADE", comestivel.Quantidade);
            comando.Parameters.AddWithValue("@MARCA", comestivel.Marca);
            comando.ExecuteNonQuery();

        }

        public List<Comestivel> ObterTodos()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "SELECT * FROM comestiveis";

            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());

            List<Comestivel> comestiveis = new List<Comestivel>();
            for (int i = 0; i < tabela.Rows.Count; i++)
            {
                DataRow linha = tabela.Rows[i];

                Comestivel comestivel = new Comestivel();

                comestivel.Id = Convert.ToInt32(linha["id"]);
                comestivel.Nome = linha["nome"].ToString();

                comestivel.Valor = Convert.ToDouble(linha["valor"]);
                comestivel.DataVencimento = Convert.ToDateTime(linha["data_vencimento"]);
                comestivel.Quantidade = Convert.ToInt32(linha["quantidade"]);
                comestivel.Marca = linha["marca"].ToString();
                comestiveis.Add(comestivel);
            }
            conexao.Close();
            return comestiveis;
        }

        public Comestivel ObterPeloId(int id)

        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "Select * FROM comestiveis WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", id);

            DataTable = new DataTable();
            DataTable.Load(comando.ExecuteReader());
            conexao.Close();
            if (DataTable.Rows.Count == 1)
            {
                DataRow linha = DataTable.Rows[0];
                Comestivel comestivel = new Comestivel();
                comestivel.Id = Convert.ToInt32(linha["id"]);
                comestivel.Nome = linha["nome"].ToString();
                comestivel.Valor = Convert.ToDouble(linha["valor"]);
                comestivel.DataVencimento = Convert.ToDateTime(linha["data_vencimento"]);
                comestivel.Quantidade = Convert.ToInt32(linha["quantidade"]);
                comestivel.Marca = linha["marca"].ToString();
                return comestivel;
            }
            return null;

        }

        public void Apagar(int id)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "DELETE FROM comestiveis WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);
            comando.ExecuteNonQuery();
            conexao.Close();

        }

        public void Atualizar(Comestivel comestivel)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "UPDATE comestiveis SET nome = @nome, valor = @VALOR, data_vencimento = @DATA_VENCIMENTO, quantidade = @QUANTIDADE";

            comando.Parameters.AddWithValue("@NOME", comestivel.Nome);
            comando.Parameters.AddWithValue("@VALOR", comestivel.Valor);
            comando.Parameters.AddWithValue("@DATA_VENCIMENTO", comestivel.DataVencimento);
            comando.Parameters.AddWithValue("@QUANTIDADE", comestivel.Quantidade);
            comando.Parameters.AddWithValue("@MARCA", comestivel.Marca);
            comando.Parameters.AddWithValue("@ID", comestivel.Id);
            comando.ExecuteNonQuery();
            conexao.Close();


        }
    }
}

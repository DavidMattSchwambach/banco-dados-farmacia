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

    class ComestivelRepositorio
    {
        string CadeiaConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\65972\Documents\ExemploBancoDados02.mdf;Integrated Security=True;Connect Timeout=30"


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
                comestivel.DataVencimento = Convert.ToDateTime(linha["data_vencimesto"]);
                comestivel.Quantidade = Convert.ToInt32(linha["quantidade"]);
                comestivel.Marca = linha["marca"].ToString();
                comestiveis.Add(comestivel);
            }
            conexao.Close();
            return comestiveis;
        }
    }
}

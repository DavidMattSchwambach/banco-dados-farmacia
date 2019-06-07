using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class ComestivelLista : Form
    {
        public ComestivelLista()
        {
            InitializeComponent();
        }

        public void AtualizarTabela()
        {
            ComestivelRepositorio repositorio = new ComestivelRepositorio();
            List<Comestivel> comestiveis = repositorio.ObterTodos();
            dataGridView1.Rows.Clear();
            for (int i = 0; i < comestiveis.Count; i++)
            {
                Comestivel comestivel = comestiveis[i];
                string valorTexto = $"R$ {comestivel.Valor}";
                dataGridView1.Rows.Add(
                    new object[]
                    {
                        comestivel.Id, comestivel.Nome, valorTexto, comestivel.DataVencimento, comestivel.Quantidade, comestivel.Marca
                    }
                );
            }
        }

        public void btnApagar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma linha para apagar");
                return;
            }
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                ComestivelRepositorio repositorio = new ComestivelRepositorio();
                repositorio.Apagar(id);

                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
            }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastroComestiveis cadastro = new CadastroComestiveis();
            cadastro.ShowDialog();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            ComestivelRepositorio repositorio = new ComestivelRepositorio();
            Comestivel comestivel = repositorio.ObterPeloId(id);

            EditarComestiveis comestivelEditar = new EditarComestiveis(comestivel);
            comestivelEditar.ShowDialog();
        }

        private void ComestivelLista_Activated(object sender, EventArgs e)
        {
            AtualizarTabela();
        }
    }
}

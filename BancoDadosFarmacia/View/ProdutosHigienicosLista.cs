using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Repository;

namespace View
{
    public partial class ProdutosHigienicosLista : Form
    {
        public ProdutosHigienicosLista()
        {
            InitializeComponent();
        }

        public void AtualizarTabela()
        {
            HigienicoRepositorio repositorio = new HigienicoRepositorio();
            List<Higienico> higienicos = repositorio.ObterTodos();
            dataGridView1.Rows.Clear();
            for (int i = 0; i < higienicos.Count; i++)
            {
                Higienico higienico = higienicos[i];
                dataGridView1.Rows.Add(
                    new object[]
                    {
                        higienico.Id, higienico.Nome, higienico.Categoria, higienico.Preco
                    }
                );
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            HigienicoRepositorio repositorio = new HigienicoRepositorio();
            repositorio.Apagar(id);

            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastroProdutosHigienicos cadastro = new CadastroProdutosHigienicos();
            cadastro.ShowDialog();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            HigienicoRepositorio repositorio = new HigienicoRepositorio();
            Higienico higienico = repositorio.ObterPeloId(id);

            EditarProdutosHigienicos higienicoEditar = new EditarProdutosHigienicos(higienico);
            higienicoEditar.ShowDialog();
        }

        private void ProdutosHigienicosLista_Activated(object sender, EventArgs e)
        {
            AtualizarTabela();
        }
    }
}

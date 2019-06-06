using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repository;
using Model;

namespace View
{
    public partial class RemedioLista : Form
    {
        public RemedioLista()
        {
            InitializeComponent();
        }

        public void AtualixzarTabela()
        {
            RemedioRepositorio repositorio = new RemedioRepositorio();

            List<Remedio> remedios = repositorio.ObterTodos();
            dataGridView1.Rows.Clear();
            for (int i = 0; i < remedios.Count; i++)
            {
                Remedio remedio = remedios[i];
                dataGridView1.Rows.Add(
                    new object[]
                    {
                        remedio.Id, remedio.Generico, remedio.Nome, remedio.Categoria, remedio.Solido, remedio.ContraIndicacoes, remedio.Bula, remedio.Faixa, remedio.PrecisaReceita
                    }
                );
            }
        }

        public void btnApagar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            RemedioRepositorio repositorio = new RemedioRepositorio();
            repositorio.Apagar(id);

            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
        }

        public void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastroRemedios cadastro = new CadastroRemedios();
            cadastro.ShowDialog();
        }

        public void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            RemedioRepositorio repositorio = new RemedioRepositorio();
            Remedio remedio = repositorio.ObterPeloId(id);

            EditarRemedios remedioEditar = new EditarRemedios(remedio);
            remedioEditar.ShowDialog();
        }

        private void RemedioLista_Activated(object sender, EventArgs e)
        {
            AtualixzarTabela();
        }
    }
}

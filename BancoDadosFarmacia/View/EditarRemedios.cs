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
    public partial class EditarRemedios : Form
    {
        public EditarRemedios()
        {
            InitializeComponent();
        }

        public EditarRemedios(Remedio remedio)
        {
            InitializeComponent();

            lblId.Text = remedio.Id.ToString();
            cbGenerico.Checked = remedio.Generico;
            txtNome.Text = remedio.Nome;
            cbxCategoria.Text = remedio.Categoria;
            cbSolido.Checked = remedio.Solido;
            txtContraIndicacoes.Text = remedio.ContraIndicacoes;
            txtBula.Text = remedio.Bula;
            cbxFaixa.Text = remedio.Faixa;
            cbPrecisaReceita.Checked = remedio.PrecisaReceita;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Remedio remedio = new Remedio();
            remedio.Id = Convert.ToInt32(lblId.Text);
            remedio.Generico = cbGenerico.Checked;
            if (txtNome.Text.Length == 0)
            {
                MessageBox.Show("Digite no minimo 1 caracter no campo Nome");
                txtNome.Focus();
                return;
            }
            remedio.Nome = txtNome.Text;
            if (cbxCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Escolha uma Categoria");
                cbxCategoria.DroppedDown = true;
                return;
            }
            remedio.Categoria = cbxCategoria.Text;

            remedio.Solido = cbSolido.Checked;
            remedio.ContraIndicacoes = txtContraIndicacoes.Text;
            remedio.Bula = txtBula.Text;
            if (cbxFaixa.SelectedIndex == -1)
            {
                MessageBox.Show("Escolha uma Faixa");
                cbxFaixa.DroppedDown = true;
                return;
            }
            remedio.Faixa = cbxFaixa.Text;
            remedio.PrecisaReceita = cbPrecisaReceita.Checked;

            RemedioRepositorio repositorio = new RemedioRepositorio();
            repositorio.Atualizar(remedio);

            MessageBox.Show("Editado com sucesso");
            Close();
        }
    }
}

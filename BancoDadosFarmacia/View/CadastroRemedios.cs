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
    public partial class CadastroRemedios : Form
    {
        public CadastroRemedios()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Remedio remedio = new Remedio();
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
            repositorio.Inserir(remedio);
            Close();
        }
    }
}

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
    public partial class CadastroProdutosHigienicos : Form
    {
        public CadastroProdutosHigienicos()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Higienico higienico = new Higienico();
            higienico.Nome = txtNome.Text;
            if (txtNome.Text.Length == 0)
            {
                MessageBox.Show("Digite no minimo 1 caracter no campo Nome");
                txtNome.Focus();
                return;
            }

            higienico.Categoria = cbxCategoria.Text;
            if (cbxCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Escolha uma Categoria");
                cbxCategoria.DroppedDown = true;
                return;
            }

            try
            {
                higienico.Preco = Convert.ToDouble(txtPreco.Text);
            }
            catch
            {
                MessageBox.Show("Digite apenas números no campo Preco");
                txtPreco.Focus();
                return;
            }
            
                HigienicoRepositorio repositorio = new HigienicoRepositorio();
                repositorio.Inserir(higienico);
                Close();
        }
    }
}

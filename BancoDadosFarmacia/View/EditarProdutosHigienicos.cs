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
using Model;
using Repository;

namespace View
{
    public partial class EditarProdutosHigienicos : Form
    {
        public EditarProdutosHigienicos()
        {
            InitializeComponent();
        }

        public EditarProdutosHigienicos(Higienico higienico)
        {
            InitializeComponent();

            lblId.Text = higienico.Id.ToString();
            txtNome.Text = higienico.Nome.ToString();
            cbxCategoria.Text = higienico.Categoria;
            txtPreco.Text = Convert.ToInt32(higienico.Preco).ToString();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Higienico higienico = new Higienico();
            higienico.Id = Convert.ToInt32(lblId.Text);
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
            repositorio.Atualizar(higienico);

            MessageBox.Show("Editado com sucesso");
            Close();
        }

        
    }
}

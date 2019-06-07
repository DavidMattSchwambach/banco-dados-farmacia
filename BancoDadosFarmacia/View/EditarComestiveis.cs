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
    public partial class EditarComestiveis : Form
    {
        public EditarComestiveis()
        {
            InitializeComponent();
        }

        public EditarComestiveis(Comestivel comestivel)
        {
            InitializeComponent();

            txtNome.Text = comestivel.Nome;
            txtValor.Text = comestivel.Valor.ToString();
            dtpDataVencimento.Text = comestivel.DataVencimento.ToString();
            txtQuantidade.Text = comestivel.Quantidade.ToString();
            txtMarca.Text = comestivel.Marca.ToString();
            lblId.Text = comestivel.Id.ToString();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Comestivel comestivel = new Comestivel();
            comestivel.Id = Convert.ToInt32(lblId.Text);
            if (txtNome.Text.Length == 0)
            {
                MessageBox.Show("Digite no minimo 1 caracter no campo Nome");
                txtNome.Focus();
                return;
            }
            comestivel.Nome = txtNome.Text;
            try
            {
                comestivel.Valor = Convert.ToDouble(txtValor.Text);
                if (comestivel.Valor < 0)
                {
                    MessageBox.Show("Valor nao aceita número menor que 0");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Digite Apenas números no campo Valor");
                txtValor.Focus();
                return;
            }
            comestivel.DataVencimento = Convert.ToDateTime(dtpDataVencimento.Text);
            try
            {
                comestivel.Quantidade = Convert.ToInt32(txtQuantidade.Text);
            }
            catch
            {
                MessageBox.Show("Digite apenas números inteiros no campo Quantidade");

            }
            if (txtMarca.Text.Length == 0)
            {
                MessageBox.Show("Digite no minimo 1 caracter no campo Marca");
                txtMarca.Focus();
                return;
            }
            comestivel.Marca = txtMarca.Text;

            ComestivelRepositorio repositorio = new ComestivelRepositorio();
            repositorio.Atualizar(comestivel);

            MessageBox.Show("Editado com sucesso");
            Close();

        }
    }
}

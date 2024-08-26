using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace TrabalhoFinalPOO
{
    public partial class CadastroCarro : Form
    {
        private GerenciadorDeCarros gerenciadorDeCarros;

        public CadastroCarro()
        {
            InitializeComponent();
            gerenciadorDeCarros = new GerenciadorDeCarros();
            txtbPreço.Leave += new EventHandler(txtbPreço_Leave);
            txtbPreço.KeyPress += new KeyPressEventHandler(txtbPreço_KeyPress);
        }

        private void txtbPreço_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(txtbPreço.Text, out double preço))
            {
                txtbPreço.Text = $"R$ {preço:F2}";
            }
        }

        private void txtbPreço_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.' || e.KeyChar == ',') && (txtbPreço.Text.Contains('.') || txtbPreço.Text.Contains(',')))
            {
                e.Handled = true;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Carro carro = new Carro
            {
                Placa = txtbPlaca.Text.ToUpper(),
                Marca = txtbMarca.Text,
                Modelo = txtbModelo.Text,
                Ano = txtbAno.Text,
                Preço = txtbPreço.Text,
                Chassi = txtbChassi.Text,
                Km = txtbKm.Text,
                Categoria = txtbCategoria.Text,
                ObservaçõesAdicionais = txtbObersevações.Text,
                DataCadastro = DateTime.Now
            };

            if (gerenciadorDeCarros.ValidarCampos(carro, out string mensagemErro))
            {
                try
                {
                    gerenciadorDeCarros.AdicionarCarro(carro);
                    MessageBox.Show("Carro cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(mensagemErro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparCampos()
        {
            txtbPlaca.Text = "";
            txtbMarca.Text = "";
            txtbModelo.Text = "";
            txtbAno.Text = "";
            txtbPreço.Text = "";
            txtbChassi.Text = "";
            txtbKm.Text = "";
            txtbCategoria.Text = "";
            txtbObersevações.Text = "";
        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

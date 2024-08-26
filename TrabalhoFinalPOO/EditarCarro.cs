using System;
using System.Linq;
using System.Windows.Forms;

namespace TrabalhoFinalPOO
{
    public partial class EditarCarro : Form
    {
        private GerenciadorDeCarros gerenciadorDeCarros;

        public EditarCarro()
        {
            InitializeComponent();
            gerenciadorDeCarros = new GerenciadorDeCarros();
            txtbPreço.Leave += new EventHandler(txtbPreço_Leave);
            txtbPreço.KeyPress += new KeyPressEventHandler(txtbPreço_KeyPress);
        }

        private void btnSalvarAlteração_Click(object sender, EventArgs e)
        {
            string placa = txtbPlaca.Text.ToUpper();
            Carro carro = gerenciadorDeCarros.ProcurarCarroPorPlaca(placa);

            if (carro != null)
            {
                if (ValidarCampos())
                {
                    AtualizarCarro(carro);
                    gerenciadorDeCarros.SalvarCarrosEmXML();
                    MessageBox.Show("Alterações salvas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                }
            }
            else
            {
                MessageBox.Show("Carro não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtbPreço_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(txtbPreço.Text.Replace("R$", "").Trim(), out double preço))
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


        private void PreencherCampos(Carro carro)
        {
            txtbPlaca.Text = carro.Placa;
            txtbMarca.Text = carro.Marca;
            txtbModelo.Text = carro.Modelo;
            txtbAno.Text = carro.Ano;
            txtbPreço.Text = carro.Preço;
            txtbChassi.Text = carro.Chassi;
            txtbKm.Text = carro.Km;
            txtbCategoria.Text = carro.Categoria;
            txtbObersevações.Text = carro.ObservaçõesAdicionais;
        }

        private void AtualizarCarro(Carro carro)
        {
            carro.Marca = txtbMarca.Text;
            carro.Modelo = txtbModelo.Text;
            carro.Ano = txtbAno.Text;
            carro.Preço = txtbPreço.Text;
            carro.Chassi = txtbChassi.Text;
            carro.Km = txtbKm.Text;
            carro.Categoria = txtbCategoria.Text;
            carro.ObservaçõesAdicionais = txtbObersevações.Text;
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtbPlaca.Text))
            {
                MessageBox.Show("A placa é obrigatória.", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtbMarca.Text))
            {
                MessageBox.Show("A marca é obrigatória.", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtbModelo.Text))
            {
                MessageBox.Show("O modelo é obrigatório.", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtbAno.Text))
            {
                MessageBox.Show("O ano é obrigatório.", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtbPreço.Text))
            {
                MessageBox.Show("O preço é obrigatório.", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtbChassi.Text))
            {
                MessageBox.Show("O chassi é obrigatório.", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtbKm.Text))
            {
                MessageBox.Show("A quilometragem é obrigatória.", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtbCategoria.Text))
            {
                MessageBox.Show("A categoria é obrigatória.", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
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

       

        private void btnlupa_Click(object sender, EventArgs e)
        {
            string placa = txtPlaca.Text.ToUpper();

            Carro carro = gerenciadorDeCarros.ProcurarCarroPorPlaca(placa);

            if (carro != null)
            {
                PreencherCampos(carro);
            }
            else
            {
                MessageBox.Show("Carro não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

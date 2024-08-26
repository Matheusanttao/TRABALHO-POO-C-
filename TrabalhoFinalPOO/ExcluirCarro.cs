using System;
using System.Windows.Forms;

namespace TrabalhoFinalPOO
{
    public partial class ExcluirCarro : Form
    {
        private GerenciadorDeCarros gerenciadorDeCarros;

        public ExcluirCarro()
        {
            InitializeComponent();
            gerenciadorDeCarros = new GerenciadorDeCarros();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExibirDadosCarros(Carro carro)
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string placa = txtPlaca.Text.ToUpper();
            Carro carro = gerenciadorDeCarros.ProcurarCarroPorPlaca(placa);

            if (carro != null)
            {
                var confirmResult = MessageBox.Show("Você tem certeza que deseja excluir este carro?",
                                                    "Confirmar Exclusão",
                                                    MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    gerenciadorDeCarros.RemoverCarro(placa);
                    gerenciadorDeCarros.SalvarCarrosEmXML();
                    MessageBox.Show("Carro excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                }
            }
            else
            {
                MessageBox.Show("Carro não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparCampos()
        {
            txtPlaca.Text = "";
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

        private void btnlupa_Click_1(object sender, EventArgs e)
        {
            string placa = txtPlaca.Text.ToUpper();
            Carro carro = gerenciadorDeCarros.ProcurarCarroPorPlaca(placa);

            if (carro != null)
            {
                ExibirDadosCarros(carro);
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

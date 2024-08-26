using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoFinalPOO
{
    public partial class DesfazerCompraDeCarro : Form
    {
        private GerenciadorDeCarros gerenciadorDeCarros;
        private GerenciadorEstoqueDeCarros gerenciadorEstoqueDeCarros;

        public DesfazerCompraDeCarro()
        {
            InitializeComponent();
            gerenciadorDeCarros = new GerenciadorDeCarros();
            gerenciadorEstoqueDeCarros = new GerenciadorEstoqueDeCarros();

        }

        private void btnDesfazer_Click(object sender, EventArgs e)
        {
            string placa = txtPlaca.Text.ToUpper();
            Carro carro = gerenciadorEstoqueDeCarros.ProcurarCarroCompradoPorPlaca(placa);

            if (carro != null)
            {
                try
                {
                    gerenciadorEstoqueDeCarros.RemoverCarroComprado(placa);
                    gerenciadorEstoqueDeCarros.SalvarEstoque();

                   
                    gerenciadorDeCarros.AdicionarCarro(carro);
                    gerenciadorDeCarros.SalvarCarrosEmXML();

                    MessageBox.Show("Compra desfeita com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao desfazer a compra: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Carro não encontrado na lista de carros comprados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnlupa_Click(object sender, EventArgs e)
        {

            string placa = txtPlaca.Text.ToUpper();
            Carro carro = gerenciadorEstoqueDeCarros.ProcurarCarroCompradoPorPlaca(placa);

            if (carro != null)
            {
                ExibirDadosCarros(carro);
            }
            else
            {
                MessageBox.Show("Carro não encontrado na lista de carros comprados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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

    }
}

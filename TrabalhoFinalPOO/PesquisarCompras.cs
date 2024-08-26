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
    public partial class PesquisarCompras : Form
    {
        private GerenciadorDeCarros gerenciadorDeCarros;
        private GerenciadorEstoqueDeCarros gerenciadorEstoqueDeCarros;

        public PesquisarCompras()
        {
            InitializeComponent();
            gerenciadorDeCarros = new GerenciadorDeCarros();
            gerenciadorEstoqueDeCarros = new GerenciadorEstoqueDeCarros();

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

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

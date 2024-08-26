using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace TrabalhoFinalPOO
{
    public partial class PesquisarCarro : Form
    {
        private GerenciadorDeCarros gerenciadorDeCarros;

        public PesquisarCarro()
        {
            InitializeComponent();
            gerenciadorDeCarros = new GerenciadorDeCarros();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlupa_Click(object sender, EventArgs e)
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

        
    }

}

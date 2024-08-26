using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TrabalhoFinalPOO
{
    public partial class ComprarCarro : Form
    {
        private GerenciadorDeCarros gerenciadorDeCarros;
        private GerenciadorEstoqueDeCarros gerenciadorEstoqueDeCarros;


        public ComprarCarro()
        {
            InitializeComponent();
            gerenciadorDeCarros = new GerenciadorDeCarros();
            gerenciadorEstoqueDeCarros = new GerenciadorEstoqueDeCarros(); 
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

        private void btnComprar_Click(object sender, EventArgs e)
        {
            string placa = txtPlaca.Text.ToUpper();
            Carro carro = gerenciadorDeCarros.ProcurarCarroPorPlaca(placa);

            if (carro != null)
            {
            
                gerenciadorEstoqueDeCarros.AdicionarCarroComprado(carro);
                gerenciadorEstoqueDeCarros.SalvarEstoque();

                gerenciadorDeCarros.RemoverCarro(carro.Placa);
                gerenciadorDeCarros.SalvarCarrosEmXML();  
                MessageBox.Show("Carro comprado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Carro não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        
    }
}

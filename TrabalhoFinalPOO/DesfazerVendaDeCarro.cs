using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoFinalPOO
{
    public partial class DesfazerVendaDeCarro : Form
    {
        private GerenciadorEstoqueDeCarros gerenciadorEstoqueDeCarros;
        private GerenciadorDeTransações gerenciadorDeTransações;

        public DesfazerVendaDeCarro()
        {
            InitializeComponent();
            gerenciadorEstoqueDeCarros = new GerenciadorEstoqueDeCarros();
            gerenciadorDeTransações = new GerenciadorDeTransações();
        }

        private void btnlupaId_Click(object sender, EventArgs e)
        {
            string id = txtbIdTransação.Text;

            Transação transação = gerenciadorDeTransações.BuscarTransaçãoPorId(id);

            if (transação != null)
            {
                ExibirDadosTransação(transação);
            }
            else
            {
                MessageBox.Show("Não existe esse id de transação.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExibirDadosTransação(Transação transação)
        {
            txtbId.Text = transação.IdVenda;
            txtbNome.Text = transação.Vendedor;
            txtBCpfcnpj.Text = transação.Cliente.CPFCNPJ;
            txtbPlaca.Text = transação.Carro.Placa;
            txtbModelo.Text = transação.Carro.Modelo;
            txtbPreço.Text = transação.PreçoT;
            txtbKm.Text = transação.Carro.Km;
            txtbObersevações.Text = transação.ObservaçõesAdicionaisT;
            txbVendedor.Text = transação.Vendedor;
            txtbPreçoTransação.Text = transação.PreçoT;
            txtbPagamento.Text = transação.Pagamento;
            txtbObservaçãoTransação.Text = transação.ObservaçõesAdicionaisT;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimparCampos()
        {
            txtbIdTransação.Text = string.Empty;
            txtbId.Text = string.Empty;
            txtbNome.Text = string.Empty;
            txtBCpfcnpj.Text = string.Empty;
            txtbPlaca.Text = string.Empty;
            txtbModelo.Text = string.Empty;
            txtbPreço.Text = string.Empty;
            txtbKm.Text = string.Empty;
            txtbObersevações.Text = string.Empty;
            txbVendedor.Text = string.Empty;
            txtbPreçoTransação.Text = string.Empty;
            txtbPagamento.Text = string.Empty;
            txtbObservaçãoTransação.Text = string.Empty;
        }

        private void btnDefazer_Click(object sender, EventArgs e)
        {
            string id = txtbId.Text; 

            Transação transação = gerenciadorDeTransações.BuscarTransaçãoPorId(id);

            if (transação != null)
            {
                try
                {
                  
                    gerenciadorEstoqueDeCarros.AdicionarCarro(transação.Carro);

                
                    gerenciadorDeTransações.RemoverTransação(transação);

                  
                    gerenciadorEstoqueDeCarros.SalvarEstoque();
                    gerenciadorDeTransações.SalvarTransações();

                    MessageBox.Show("Venda cancelada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimparCampos(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao cancelar a venda: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Não existe essa transação para cancelar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

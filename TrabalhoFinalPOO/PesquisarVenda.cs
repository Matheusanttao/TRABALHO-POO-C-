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
    public partial class PesquisarVenda : Form
    {
        private GerenciadorEstoqueDeCarros gerenciadorEstoqueDeCarros;
        private GerenciadorDeTransações gerenciadorDeTransações;

        public PesquisarVenda()
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
    }
}

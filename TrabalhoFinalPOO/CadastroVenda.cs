using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace TrabalhoFinalPOO
{
    public partial class CadastroVenda : Form
    {
        private GerenciadorDeClientes gerenciadorDeClientes;
        private GerenciadorEstoqueDeCarros gerenciadorEstoqueDeCarros;
        private GerenciadorDeTransações gerenciadorDeTransações;
        private List<string> idsDeVendaUtilizados; 

        public CadastroVenda()
        {
            InitializeComponent();
            gerenciadorDeClientes = new GerenciadorDeClientes();
            gerenciadorEstoqueDeCarros = new GerenciadorEstoqueDeCarros();
            gerenciadorDeTransações = new GerenciadorDeTransações();
            idsDeVendaUtilizados = new List<string>(); 
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtbId.Text, out int clienteId) &&
                !string.IsNullOrWhiteSpace(txtbPlaca.Text) &&
                !string.IsNullOrWhiteSpace(txtbIdVenda.Text)) 
            {
                
                if (idsDeVendaUtilizados.Contains(txtbIdVenda.Text))
                {
                    MessageBox.Show("O ID de venda já foi utilizado. Informe um ID único.", "ID de Venda Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; 
                }

                Cliente cliente = gerenciadorDeClientes.ProcurarClientePorId(clienteId);
                Carro carro = gerenciadorEstoqueDeCarros.ProcurarCarroCompradoPorPlaca(txtbPlaca.Text.ToUpper());

                if (cliente != null && carro != null)
                {
            
                    if (carro != null)
                    {
                        Transação transação = new Transação
                        {
                            IdVenda = txtbIdVenda.Text,
                            Vendedor = txbVendedor.Text,
                            PreçoT = txtbPreçoTransação.Text,
                            Pagamento = cbbPagamento.SelectedItem?.ToString(),
                            ObservaçõesAdicionaisT = txtbObservaçãoTransação.Text,
                            DataCadastro = DateTime.Now,
                            Cliente = cliente,
                            Carro = carro
                        };

                        if (gerenciadorDeTransações.VerificarCamposPreenchidos(transação))
                        {
                            gerenciadorDeTransações.AdicionarTransação(transação);
                            gerenciadorEstoqueDeCarros.RemoverCarroComprado(carro.Placa);
                            gerenciadorEstoqueDeCarros.SalvarEstoque();

               
                            idsDeVendaUtilizados.Add(txtbIdVenda.Text);

                            MessageBox.Show("Transação registrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimparCaixasDeTexto();
                        }
                        else
                        {
                            MessageBox.Show("Todos os campos devem ser preenchidos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Carro não disponível para venda.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Cliente ou carro não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Dados inválidos. Verifique os campos e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnlupaId_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtbId.Text, out int id))
            {
                Cliente cliente = gerenciadorDeClientes.ProcurarClientePorId(id);

                if (cliente != null)
                {
                    ExibirDadosCliente(cliente);
                }
                else
                {
                    MessageBox.Show("Cliente não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("O ID deve ser um número válido.", "ID Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ExibirDadosCliente(Cliente cliente)
        {
            txtbId.Text = cliente.Id.ToString();
            txtbNome.Text = cliente.Nome;
            txtBCpfcnpj.Text = cliente.CPFCNPJ;
        }

        private void btnlupaPlaca_Click(object sender, EventArgs e)
        {
            string placa = txtbPlaca.Text.ToUpper(); 
            Console.WriteLine($"Buscando carro com placa: {placa}");

            Carro carro = gerenciadorEstoqueDeCarros.ProcurarCarroCompradoPorPlaca(placa);

            if (carro != null)
            {
                ExibirDadosCarro(carro);
            }
            else
            {
                MessageBox.Show("Carro não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExibirDadosCarro(Carro carro)
        {
            txtbPlaca.Text = carro.Placa;
            txtbModelo.Text = carro.Modelo;
            txtbPreço.Text = carro.Preço;
            txtbKm.Text = carro.Km;
            txtbObersevações.Text = carro.ObservaçõesAdicionais;
            txtbPreçoTransação.Text = carro.Preço;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimparCaixasDeTexto()
        {
            txtbIdVenda.Text = "";
            txtbId.Text = "";
            txtbNome.Text = "";
            txtBCpfcnpj.Text = "";
            txtbPlaca.Text = "";
            txtbModelo.Text = "";
            txtbPreço.Text = "";
            txtbKm.Text = "";
            txtbObersevações.Text = "";
            txtbPreçoTransação.Text = "";
            txbVendedor.Text = "";
            txtbObservaçãoTransação.Text = "";
            cbbPagamento.SelectedIndex = -1;
        }

        private void txtbIdVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
        
                e.Handled = true;
            }
        }
    }
}

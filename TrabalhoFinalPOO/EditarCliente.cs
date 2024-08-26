using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace TrabalhoFinalPOO
{ 

    public partial class EditarCliente : Form
    {
        private GerenciadorDeClientes gerenciadorClientes;

        public EditarCliente()
        {
            InitializeComponent();
            gerenciadorClientes = new GerenciadorDeClientes();
        }

        private void btnlupa_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtIdPesquisar.Text, out int id))
            {
                Cliente cliente = gerenciadorClientes.ProcurarClientePorId(id);

                if (cliente != null)
                {
                    PreencherCampos(cliente);
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtbId.Text, out int id))
            {
                Cliente cliente = gerenciadorClientes.ProcurarClientePorId(id);

                if (cliente != null)
                {
                    if (ValidarCampos())
                    {
                        AtualizarCliente(cliente);
                        gerenciadorClientes.SalvarClientesEmXML();
                        MessageBox.Show("Alterações salvas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimparCampos();
                    }
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

        private void PreencherCampos(Cliente cliente)
        {
            txtbId.Text = cliente.Id.ToString();
            txtbNome.Text = cliente.Nome;
            txtbTelefone.Text = cliente.Telefone;
            txtBCpfcnpj.Text = cliente.CPFCNPJ;
            txtBRua.Text = cliente.Endereço.Rua;
            txtbn.Text = cliente.Endereço.Numero;
            txtbBairro.Text = cliente.Endereço.Bairro;
            txtbCidade.Text = cliente.Endereço.Cidade;
            txtbUf.Text = cliente.Endereço.UF;
            txtbcep.Text = cliente.Endereço.CEP;
        }

        private void AtualizarCliente(Cliente cliente)
        {
            cliente.Nome = txtbNome.Text;
            cliente.Telefone = txtbTelefone.Text;
            cliente.CPFCNPJ = txtBCpfcnpj.Text;
            cliente.Endereço.Rua = txtBRua.Text;
            cliente.Endereço.Numero = txtbn.Text;
            cliente.Endereço.Bairro = txtbBairro.Text;
            cliente.Endereço.Cidade = txtbCidade.Text;
            cliente.Endereço.UF = txtbUf.Text;
            cliente.Endereço.CEP = txtbcep.Text;
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtbNome.Text))
            {
                MessageBox.Show("O nome do cliente é obrigatório.", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtbTelefone.Text))
            {
                MessageBox.Show("O telefone do cliente é obrigatório.", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtBCpfcnpj.Text))
            {
                MessageBox.Show("O CPF/CNPJ do cliente é obrigatório.", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtBRua.Text))
            {
                MessageBox.Show("A rua do endereço é obrigatória.", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtbn.Text))
            {
                MessageBox.Show("O número do endereço é obrigatório.", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtbBairro.Text))
            {
                MessageBox.Show("O bairro do endereço é obrigatório.", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtbUf.Text))
            {
                MessageBox.Show("O UF do endereço é obrigatório.", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtbCidade.Text))
            {
                MessageBox.Show("A cidade do endereço é obrigatória.", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtbcep.Text))
            {
                MessageBox.Show("O CEP do endereço é obrigatório.", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void LimparCampos()
        {
            txtIdPesquisar.Text = "";
            txtbId.Text = "";
            txtbNome.Text = "";
            txtbTelefone.Text = "";
            txtBCpfcnpj.Text = "";
            txtBRua.Text = "";
            txtbn.Text = "";
            txtbBairro.Text = "";
            txtbCidade.Text = "";
            txtbUf.Text = "";
            txtbcep.Text = "";
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
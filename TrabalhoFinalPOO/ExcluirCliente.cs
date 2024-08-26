using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace TrabalhoFinalPOO
{
    public partial class ExcluirCliente : Form
    {
        private GerenciadorDeClientes gerenciadorClientes;

        public ExcluirCliente()
        {
            InitializeComponent();
            gerenciadorClientes = new GerenciadorDeClientes();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    LimparCampos();
                    MessageBox.Show("Cliente não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("O ID deve ser um número válido.", "ID Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtbId.Text, out int id))
            {
                Cliente cliente = gerenciadorClientes.ProcurarClientePorId(id);

                if (cliente != null)
                {
                    DialogResult dialogResult = MessageBox.Show("Tem certeza que deseja excluir este cliente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        gerenciadorClientes.RemoverCliente(cliente);
                        MessageBox.Show("Cliente excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace TrabalhoFinalPOO
{
    public partial class PesquisarCliente : Form
    {
        private GerenciadorDeClientes gerenciadorDeClientes;

        public PesquisarCliente()
        {
            InitializeComponent();
            gerenciadorDeClientes = new GerenciadorDeClientes();
        }

        private void btnlupa_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(txtIdPesquisar.Text, out int id))
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
            txtbTelefone.Text = cliente.Telefone;
            txtBCpfcnpj.Text = cliente.CPFCNPJ;
            txtBRua.Text = cliente.Endereço.Rua;
            txtbn.Text = cliente.Endereço.Numero;
            txtbBairro.Text = cliente.Endereço.Bairro;
            txtbCidade.Text = cliente.Endereço.Cidade;
            txtbUf.Text = cliente.Endereço.UF;
            txtbcep.Text = cliente.Endereço.CEP;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}

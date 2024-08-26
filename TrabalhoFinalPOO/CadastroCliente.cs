using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace TrabalhoFinalPOO
{
    public partial class CadastroCliente : Form
    {
        private GerenciadorDeClientes gerenciadorDeClientes;

        public CadastroCliente()
        {
            InitializeComponent();
            gerenciadorDeClientes = new GerenciadorDeClientes();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtbId.Text, out int id))
            {
                Cliente cliente = new Cliente
                {
                    Id = id,
                    Nome = txtbNome.Text,
                    Telefone = txtbTelefone.Text,
                    CPFCNPJ = txtBCpfcnpj.Text,
                    Endereço = new Endereço
                    {
                        Rua = txtBRua.Text,
                        Numero = txtbn.Text,
                        Bairro = txtbBairro.Text,
                        Cidade = txtbCidade.Text,
                        UF = txtbUf.Text,
                        CEP = txtbcep.Text
                    },
                    DataCadastro = DateTime.Now
                };

                if (gerenciadorDeClientes.ValidarCliente(cliente, out string mensagemErro))
                {
                    gerenciadorDeClientes.AdicionarCliente(cliente);
                    MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                }
                else
                {
                    MessageBox.Show(mensagemErro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("O ID deve ser um número válido.", "ID Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LimparCampos()
        {
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
    }
}

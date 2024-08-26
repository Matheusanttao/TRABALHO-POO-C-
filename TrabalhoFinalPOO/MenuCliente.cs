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
    public partial class MenuCliente : Form
    {
        public MenuCliente()
        {
            InitializeComponent();
        }

        private void btnCadastroCliente_Click(object sender, EventArgs e)
        {
            CadastroCliente cadastroCliente = new CadastroCliente();
            cadastroCliente.ShowDialog();

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            PesquisarCliente pesquisarCliente = new PesquisarCliente();
            pesquisarCliente.ShowDialog();

        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            EditarCliente editarCliente = new EditarCliente();
            editarCliente.ShowDialog();
        }

        private void btnExcluirCliente_Click(object sender, EventArgs e)
        {
            ExcluirCliente excluirCliente = new ExcluirCliente();
            excluirCliente.ShowDialog();

        }

        private void btnListarClientes_Click(object sender, EventArgs e)
        {
            ListarClientes listarClientes = new ListarClientes();
            listarClientes.ShowDialog();

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

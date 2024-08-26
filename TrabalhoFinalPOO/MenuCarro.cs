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
    public partial class MenuCarro : Form
    {
        public MenuCarro()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarCarro_Click(object sender, EventArgs e)
        {
            PesquisarCarro pesquisarCarro = new PesquisarCarro();
            pesquisarCarro.ShowDialog();
        }

        private void btnEditarCarro_Click(object sender, EventArgs e)
        {
            EditarCarro editarCarro = new EditarCarro();
            editarCarro.ShowDialog();
        }

        private void btnExcluirCarro_Click(object sender, EventArgs e)
        {
            ExcluirCarro excluirCarro = new ExcluirCarro();
            excluirCarro.ShowDialog();
        }

        private void btnListarCarro_Click(object sender, EventArgs e)
        {
            ListarCarros listarCarros = new ListarCarros();
            listarCarros.ShowDialog();
        }

        private void btnCadastroCarro_Click(object sender, EventArgs e)
        {
            CadastroCarro cadastroCarro = new CadastroCarro();
            cadastroCarro.ShowDialog();
        }
    }
}

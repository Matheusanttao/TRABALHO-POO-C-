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
    public partial class MenuComprar : Form
    {
        public MenuComprar()
        {
            InitializeComponent();
        }

        private void btnbAcionarTransação_Click(object sender, EventArgs e)
        {
            ComprarCarro cadastroCompra = new ComprarCarro();
            cadastroCompra.ShowDialog();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarTransação_Click(object sender, EventArgs e)
        {
            DesfazerCompraDeCarro desfazerCompraDeCarro = new DesfazerCompraDeCarro();
            desfazerCompraDeCarro.ShowDialog();
        }

        private void btnListarCarro_Click(object sender, EventArgs e)
        {
           ListarEstoqueCarros listarEstoqueCarros = new ListarEstoqueCarros();
            listarEstoqueCarros.ShowDialog();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisarCompras pesquisarCompras = new PesquisarCompras();
           pesquisarCompras.ShowDialog();
        }
    }
}

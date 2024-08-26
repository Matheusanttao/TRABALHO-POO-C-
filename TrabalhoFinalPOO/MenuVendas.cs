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
    public partial class MenuVendas : Form
    {
        public MenuVendas()
        {
            InitializeComponent();
        }

        private void btnbAcionarTransação_Click(object sender, EventArgs e)
        {
            CadastroVenda cadastroVenda = new CadastroVenda();
            cadastroVenda.ShowDialog();
        }

        private void btnDesfazer_Click(object sender, EventArgs e)
        {
           DesfazerVendaDeCarro desfazerVendaDeCarro = new DesfazerVendaDeCarro();
            desfazerVendaDeCarro.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PesquisarVenda pesquisarVenda = new PesquisarVenda();
            pesquisarVenda.ShowDialog();
        }

        private void btnRelatórioVenda_Click(object sender, EventArgs e)
        {
           ListandoVendas listandoVendas = new ListandoVendas();
           listandoVendas.ShowDialog();
        }
    }
}

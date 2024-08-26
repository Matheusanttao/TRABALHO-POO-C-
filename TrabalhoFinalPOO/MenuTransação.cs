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
    public partial class MenuTransação : Form
    {
        public MenuTransação()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
           MenuVendas menuVender = new MenuVendas();
           menuVender.ShowDialog();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            MenuComprar menuComprar = new MenuComprar();
            menuComprar.ShowDialog();
        }
    }
}

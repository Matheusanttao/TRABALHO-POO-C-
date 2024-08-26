using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace TrabalhoFinalPOO
{
    public partial class ListandoVendas : Form
    {
        private List<Transação> vendas;

        public ListandoVendas()
        {
            InitializeComponent();
            vendas = new List<Transação>();
            CarregarVendasDeXML();
            PreencherDataGridView();
            ConfigurarFontes();
            ConfigurarDataGridView();
        }

        private void CarregarVendasDeXML()
        {
            try
            {
                string caminhoArquivo = @"C:\arquivoxml\Transações.xml";

                if (File.Exists(caminhoArquivo))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Transação>));
                    using (TextReader reader = new StreamReader(caminhoArquivo))
                    {
                        vendas = (List<Transação>)serializer.Deserialize(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar as vendas: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                vendas = new List<Transação>();
            }
        }

        private void PreencherDataGridView()
        {
            dgvVendas.DataSource = null;
            dgvVendas.DataSource = vendas.Select(v => new
            {
                v.IdVenda,
                Cliente = v.Cliente.Nome, 
                CPFCNPJ = v.Cliente.CPFCNPJ,
                v.Carro,
                v.PreçoT,
                DataVenda = v.DataCadastro.ToShortDateString(),
                v.ObservaçõesAdicionaisT
            }).ToList();

            dgvVendas.ClearSelection();
        }

        private void ConfigurarFontes()
        {
            dgvVendas.DefaultCellStyle.Font = new Font("Arial", 12);
            dgvVendas.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14, FontStyle.Bold);
        }

        private void ConfigurarDataGridView()
        {
            dgvVendas.RowHeadersVisible = false;

            dgvVendas.Columns["IdVenda"].HeaderText = "ID";
            dgvVendas.Columns["Cliente"].HeaderText = "Nome";
            dgvVendas.Columns["CPFCNPJ"].HeaderText = "CPF/CNPJ";
            dgvVendas.Columns["Carro"].HeaderText = "Carro";
            dgvVendas.Columns["PreçoT"].HeaderText = "Preço";
            dgvVendas.Columns["DataVenda"].HeaderText = "Data";
            dgvVendas.Columns["ObservaçõesAdicionaisT"].HeaderText = "Observações";

            dgvVendas.Columns["IdVenda"].Width = 100;
            dgvVendas.Columns["Cliente"].Width = 200;
            dgvVendas.Columns["CPFCNPJ"].Width = 150;
            dgvVendas.Columns["Carro"].Width = 200;
            dgvVendas.Columns["PreçoT"].Width = 150;
            dgvVendas.Columns["DataVenda"].Width = 120;
            dgvVendas.Columns["ObservaçõesAdicionaisT"].Width = 300;

            dgvVendas.DefaultCellStyle.Font = new Font("Arial", 12);
            dgvVendas.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14, FontStyle.Bold);
        }
    

        private void txtbPesquisar_TextChanged(object sender, EventArgs e)
        {
            string pesquisa = txtbPesquisar.Text.ToLower();

            dgvVendas.ClearSelection();

            if (!string.IsNullOrEmpty(pesquisa))
            {
                int rowIndex = -1;

                for (int i = 0; i < dgvVendas.Rows.Count; i++)
                {
                    DataGridViewRow row = dgvVendas.Rows[i];

                    if (row.Cells["IdVenda"].Value.ToString().ToLower().Contains(pesquisa) ||
                        row.Cells["Cliente"].Value.ToString().ToLower().Contains(pesquisa) ||
                        row.Cells["CPFCNPJ"].Value.ToString().ToLower().Contains(pesquisa) ||
                        row.Cells["Carro"].Value.ToString().ToLower().Contains(pesquisa) ||
                        row.Cells["ObservaçõesAdicionaisT"].Value.ToString().ToLower().Contains(pesquisa) ||
                        row.Cells["PreçoT"].Value.ToString().ToLower().Contains(pesquisa))
                    {
                        rowIndex = i;
                        break;
                    }
                }

                if (rowIndex >= 0)
                {
                    dgvVendas.Rows[rowIndex].Selected = true;
                    dgvVendas.FirstDisplayedScrollingRowIndex = rowIndex;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
    }
}

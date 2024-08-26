using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace TrabalhoFinalPOO
{
    public partial class ListarClientes : Form
    {
        private List<Cliente> clientes;

        public ListarClientes()
        {
            InitializeComponent();
            clientes = new List<Cliente>();
            CarregarClientesDeXML();
            PreencherDataGridView();
            CarregarGrid();
            ConfigurarFontes();
            ConfigurarDataGridView();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CarregarClientesDeXML()
        {
            try
            {
                string CaminhoArquivo = @"C:\arquivoxml\clientes.xml";

                if (File.Exists(CaminhoArquivo))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Cliente>));
                    using (TextReader reader = new StreamReader(CaminhoArquivo))
                    {
                        clientes = (List<Cliente>)serializer.Deserialize(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar os clientes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clientes = new List<Cliente>();
            }
        }

        private void PreencherDataGridView()
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = clientes.Select(c => new
            {
                c.Id,
                c.Nome,
                c.Telefone,
                c.CPFCNPJ,
                c.DataCadastro
            }).ToList();

            dgvClientes.ClearSelection();
        }

        private void ConfigurarFontes()
        {
            dgvClientes.DefaultCellStyle.Font = new Font("Arial", 12);
            dgvClientes.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14, FontStyle.Bold);
        }

        private void CarregarGrid()
        {
            if (dgvClientes.Columns.Count > 0)
            {
                dgvClientes.Columns[0].Width = 50;
                dgvClientes.Columns[1].Width = 400;
                dgvClientes.Columns[2].Width = 200;
                dgvClientes.Columns[3].Width = 200;
                dgvClientes.Columns[4].Width = 180;
            }
        }

        private void ConfigurarDataGridView()
        {
            dgvClientes.RowHeadersVisible = false;
        }

        private void txtbPesquisar_TextChanged(object sender, EventArgs e)
        {
            string pesquisa = txtbPesquisar.Text.ToLower();

            if (!string.IsNullOrEmpty(pesquisa))
            {
                var filtroCliente = clientes.Where(c =>
                    c.Nome.ToLower().Contains(pesquisa) ||
                    c.Id.ToString().Contains(pesquisa) ||
                    c.CPFCNPJ.ToString().Contains(pesquisa) ||
                    c.Telefone.Contains(pesquisa) 
                ).ToList();

                if (filtroCliente.Any())
                {
                    int rowIndex = dgvClientes.Rows
                        .Cast<DataGridViewRow>()
                        .FirstOrDefault(r =>
                            r.Cells["Nome"].Value.ToString().ToLower().Contains(pesquisa) ||
                            r.Cells["Id"].Value.ToString().Contains(pesquisa) ||
                            r.Cells["CPFCNPJ"].Value.ToString().Contains(pesquisa) ||
                            r.Cells["Telefone"].Value.ToString().Contains(pesquisa) 
                        )?.Index ?? -1;

                    if (rowIndex >= 0)
                    {
                        dgvClientes.ClearSelection();
                        dgvClientes.Rows[rowIndex].Selected = true;
                        dgvClientes.FirstDisplayedScrollingRowIndex = rowIndex;
                    }
                }
                else
                {
                    dgvClientes.ClearSelection();
                }
            }
            else
            {
                dgvClientes.ClearSelection();
            }
        }
      
    }
}
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace TrabalhoFinalPOO
{
    public partial class ListarEstoqueCarros : Form
    {
       
            private List<Carro> carros;

            public ListarEstoqueCarros()
            {
                InitializeComponent();
                carros = new List<Carro>();
                CarregarCarrosDeXML();
                PreencherDataGridView();
                CarregarGrid();
                ConfigurarFontes();
                ConfigurarDataGridView();
            }

            private void btnVoltar_Click(object sender, EventArgs e)
            {
                this.Close();
            }

            private void CarregarCarrosDeXML()
            {
                try
                {
                    string CaminhoArquivo = @"C:\arquivoxml\EstoqueCarros.xml";

                    if (File.Exists(CaminhoArquivo))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(List<Carro>));
                        using (TextReader reader = new StreamReader(CaminhoArquivo))
                        {
                            carros = (List<Carro>)serializer.Deserialize(reader);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao carregar os carros: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    carros = new List<Carro>();
                }
            }

            private void PreencherDataGridView()
            {
                dgvCarros.DataSource = null;
                dgvCarros.DataSource = carros.Select(c => new
                {
                    c.Placa,
                    c.Marca,
                    c.Modelo,
                    c.Ano,
                    c.Preço,
                    c.Chassi,
                    c.Km,
                    c.Categoria,
                    c.ObservaçõesAdicionais
                }).ToList();

                dgvCarros.ClearSelection();
            }

            private void ConfigurarFontes()
            {
                dgvCarros.DefaultCellStyle.Font = new Font("Arial", 12);
                dgvCarros.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14, FontStyle.Bold);
            }

            private void CarregarGrid()
            {
                if (dgvCarros.Columns.Count > 0)
                {
                    dgvCarros.Columns[0].Width = 150;
                    dgvCarros.Columns[1].Width = 200;
                    dgvCarros.Columns[2].Width = 200;
                    dgvCarros.Columns[3].Width = 100;
                    dgvCarros.Columns[4].Width = 200;
                    dgvCarros.Columns[5].Width = 200;
                    dgvCarros.Columns[6].Width = 100;
                    dgvCarros.Columns[7].Width = 180;
                    dgvCarros.Columns[8].Width = 300;
                }
            }

            private void ConfigurarDataGridView()
            {
                dgvCarros.RowHeadersVisible = false;
            }

            private void txtbPesquisar_TextChanged(object sender, EventArgs e)
            {
                string pesquisa = txtbPesquisar.Text.ToLower();

                dgvCarros.ClearSelection();

                if (!string.IsNullOrEmpty(pesquisa))
                {
                    int rowIndex = -1;

                    for (int i = 0; i < dgvCarros.Rows.Count; i++)
                    {
                        DataGridViewRow row = dgvCarros.Rows[i];

                        if (row.Cells["Placa"].Value.ToString().ToLower().Contains(pesquisa) ||
                            row.Cells["Marca"].Value.ToString().ToLower().Contains(pesquisa) ||
                            row.Cells["Modelo"].Value.ToString().ToLower().Contains(pesquisa) ||
                            row.Cells["Ano"].Value.ToString().ToLower().Contains(pesquisa) ||
                            row.Cells["Preço"].Value.ToString().ToLower().Contains(pesquisa) ||
                            row.Cells["Chassi"].Value.ToString().ToLower().Contains(pesquisa) ||
                            row.Cells["Km"].Value.ToString().ToLower().Contains(pesquisa) ||
                            row.Cells["Categoria"].Value.ToString().ToLower().Contains(pesquisa) ||
                            row.Cells["ObservaçõesAdicionais"].Value.ToString().ToLower().Contains(pesquisa))
                        {
                            rowIndex = i;
                            break;
                        }
                    }

                    if (rowIndex >= 0)
                    {
                        dgvCarros.Rows[rowIndex].Selected = true;
                        dgvCarros.FirstDisplayedScrollingRowIndex = rowIndex;
                    }
                }
            }


            private void button1_Click(object sender, EventArgs e)
            {
                this.Close();
            }

        
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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

namespace TrabalhoFinalPOO
{
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            MenuCliente menuCliente = new MenuCliente();
            menuCliente.ShowDialog();
        }

        private void btmCarro_Click(object sender, EventArgs e)
        {
            MenuCarro menuCarro = new MenuCarro();
            menuCarro.ShowDialog();
        }

        private void btnTransação_Click(object sender, EventArgs e)
        {
            MenuTransação menuTransação = new MenuTransação();
            menuTransação.ShowDialog();
        }

        private void MENU_Load(object sender, EventArgs e)
        {
            string mensagem = "Bem-vindo ao sistema de compra e venda de veículos!\n\n";
            mensagem += "Este sistema foi desenvolvido para gerenciar a compra e venda de veículos, ";
            mensagem += "permitindo o cadastro de clientes, veículos e transações financeiras.\n\n";
            mensagem += "Tema: Compra e Venda de Veículos\n";
            mensagem += "Trabalho do 3º período de Programação Orientada a Objetos.\n";
            mensagem += "Aproveite o uso do sistema!\n";

            MessageBox.Show(mensagem, "Bem-vindo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja sair realmente do programa?", "Confirmação de Saída", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                
                Application.Exit();
            }
          
        }

        private void btnExportarArquivoXml_Click(object sender, EventArgs e)
        {
            
                try
                {
                   
                    FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                    folderBrowserDialog.Description = "Selecione a pasta 'arquivosxml' que deseja copiar.";
                    DialogResult result = folderBrowserDialog.ShowDialog();

                  
                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                    {
                        string diretorioOrigem = folderBrowserDialog.SelectedPath;
                        string diretorioDestino = @"C:\arquivoxml"; 

                        
                        if (!Directory.Exists(diretorioDestino))
                        {
                            Directory.CreateDirectory(diretorioDestino); 
                        }

                  
                        CopiaDiretorio(diretorioOrigem, diretorioDestino);

                        MessageBox.Show("Pasta 'arquivoxml' copiada com sucesso para '" + diretorioDestino + "'.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao copiar a pasta 'arquivoxml': " + ex.Message);
                }
            
        }
        private void CopiaDiretorio(string sourceDir, string targetDir)
        {
           
            string[] subDirs = Directory.GetDirectories(sourceDir);

       
            foreach (string file in Directory.GetFiles(sourceDir))
            {
                string dest = Path.Combine(targetDir, Path.GetFileName(file));
                File.Copy(file, dest, true);
            }

            
            foreach (string subDir in subDirs)
            {
                string destSubDir = Path.Combine(targetDir, Path.GetFileName(subDir));
                CopiaDiretorio(subDir, destSubDir);
            }
        }


    }
}

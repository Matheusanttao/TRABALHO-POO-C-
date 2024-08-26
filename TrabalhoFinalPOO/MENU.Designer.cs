
namespace TrabalhoFinalPOO
{
    partial class MENU
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MENU));
            this.btnCliente = new System.Windows.Forms.Button();
            this.btmCarro = new System.Windows.Forms.Button();
            this.btnTransação = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExportarArquivoXml = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCliente
            // 
            this.btnCliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.Location = new System.Drawing.Point(200, 96);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(351, 86);
            this.btnCliente.TabIndex = 0;
            this.btnCliente.Text = "CLIENTE";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btmCarro
            // 
            this.btmCarro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F);
            this.btmCarro.Location = new System.Drawing.Point(200, 205);
            this.btmCarro.Name = "btmCarro";
            this.btmCarro.Size = new System.Drawing.Size(351, 86);
            this.btmCarro.TabIndex = 1;
            this.btmCarro.Text = "CARRO";
            this.btmCarro.UseVisualStyleBackColor = true;
            this.btmCarro.Click += new System.EventHandler(this.btmCarro_Click);
            // 
            // btnTransação
            // 
            this.btnTransação.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F);
            this.btnTransação.Location = new System.Drawing.Point(200, 324);
            this.btnTransação.Name = "btnTransação";
            this.btnTransação.Size = new System.Drawing.Size(351, 86);
            this.btnTransação.TabIndex = 2;
            this.btnTransação.Text = "TRANSAÇÃO";
            this.btnTransação.UseVisualStyleBackColor = true;
            this.btnTransação.Click += new System.EventHandler(this.btnTransação_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "SEJA BEM VINDO!";
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnSair.Location = new System.Drawing.Point(265, 540);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(194, 49);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExportarArquivoXml
            // 
            this.btnExportarArquivoXml.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F);
            this.btnExportarArquivoXml.Location = new System.Drawing.Point(200, 432);
            this.btnExportarArquivoXml.Name = "btnExportarArquivoXml";
            this.btnExportarArquivoXml.Size = new System.Drawing.Size(351, 86);
            this.btnExportarArquivoXml.TabIndex = 8;
            this.btnExportarArquivoXml.Text = "EXPORTAR ARQUIVO XML";
            this.btnExportarArquivoXml.UseVisualStyleBackColor = true;
            this.btnExportarArquivoXml.Click += new System.EventHandler(this.btnExportarArquivoXml_Click);
            // 
            // MENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 601);
            this.Controls.Add(this.btnExportarArquivoXml);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTransação);
            this.Controls.Add(this.btmCarro);
            this.Controls.Add(this.btnCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MENU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU PRINCIPAL";
            this.Load += new System.EventHandler(this.MENU_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btmCarro;
        private System.Windows.Forms.Button btnTransação;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExportarArquivoXml;
    }
}


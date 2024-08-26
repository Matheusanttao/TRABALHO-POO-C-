
namespace TrabalhoFinalPOO
{
    partial class ListarEstoqueCarros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarEstoqueCarros));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbPesquisar = new System.Windows.Forms.TextBox();
            this.dgvCarros = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarros)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(580, 33);
            this.label1.TabIndex = 45;
            this.label1.Text = "ESTOQUE DE CARROS PARA VENDER\r\n";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 25);
            this.label2.TabIndex = 49;
            this.label2.Text = "DIGITE PARA PESQUISAR:\r\n";
            // 
            // txtbPesquisar
            // 
            this.txtbPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtbPesquisar.Location = new System.Drawing.Point(325, 58);
            this.txtbPesquisar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbPesquisar.Name = "txtbPesquisar";
            this.txtbPesquisar.Size = new System.Drawing.Size(315, 28);
            this.txtbPesquisar.TabIndex = 48;
            this.txtbPesquisar.TextChanged += new System.EventHandler(this.txtbPesquisar_TextChanged);
            // 
            // dgvCarros
            // 
            this.dgvCarros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarros.Location = new System.Drawing.Point(34, 97);
            this.dgvCarros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCarros.Name = "dgvCarros";
            this.dgvCarros.RowHeadersWidth = 51;
            this.dgvCarros.RowTemplate.Height = 24;
            this.dgvCarros.Size = new System.Drawing.Size(1033, 535);
            this.dgvCarros.TabIndex = 47;
           
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(419, 657);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 49);
            this.button1.TabIndex = 46;
            this.button1.Text = "VOLTAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ListarEstoqueCarros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 735);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbPesquisar);
            this.Controls.Add(this.dgvCarros);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ListarEstoqueCarros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LISTAR ESTOQUE DE CARROS";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbPesquisar;
        private System.Windows.Forms.DataGridView dgvCarros;
        private System.Windows.Forms.Button button1;
    }
}
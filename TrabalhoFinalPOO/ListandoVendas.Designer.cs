
namespace TrabalhoFinalPOO
{
    partial class ListandoVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListandoVendas));
            this.label2 = new System.Windows.Forms.Label();
            this.txtbPesquisar = new System.Windows.Forms.TextBox();
            this.dgvVendas = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 25);
            this.label2.TabIndex = 54;
            this.label2.Text = "DIGITE PARA PESQUISAR:\r\n";
            // 
            // txtbPesquisar
            // 
            this.txtbPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtbPesquisar.Location = new System.Drawing.Point(305, 87);
            this.txtbPesquisar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbPesquisar.Name = "txtbPesquisar";
            this.txtbPesquisar.Size = new System.Drawing.Size(315, 28);
            this.txtbPesquisar.TabIndex = 53;
            this.txtbPesquisar.TextChanged += new System.EventHandler(this.txtbPesquisar_TextChanged);
            // 
            // dgvVendas
            // 
            this.dgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendas.Location = new System.Drawing.Point(14, 126);
            this.dgvVendas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvVendas.Name = "dgvVendas";
            this.dgvVendas.RowHeadersWidth = 51;
            this.dgvVendas.RowTemplate.Height = 24;
            this.dgvVendas.Size = new System.Drawing.Size(1056, 535);
            this.dgvVendas.TabIndex = 52;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(400, 686);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 49);
            this.button1.TabIndex = 51;
            this.button1.Text = "VOLTAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 33);
            this.label1.TabIndex = 50;
            this.label1.Text = "LISTANDO TODAS AS VENDAS";
            // 
            // ListandoVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 772);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbPesquisar);
            this.Controls.Add(this.dgvVendas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ListandoVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LISTANDO TODAS AS VENDAS";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbPesquisar;
        private System.Windows.Forms.DataGridView dgvVendas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}
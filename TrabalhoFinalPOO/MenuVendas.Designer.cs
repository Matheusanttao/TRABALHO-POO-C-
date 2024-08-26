
namespace TrabalhoFinalPOO
{
    partial class MenuVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuVendas));
            this.btnbVender = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnRelatórioVenda = new System.Windows.Forms.Button();
            this.btnDesfazer = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnbVender
            // 
            this.btnbVender.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbVender.Location = new System.Drawing.Point(116, 108);
            this.btnbVender.Name = "btnbVender";
            this.btnbVender.Size = new System.Drawing.Size(461, 66);
            this.btnbVender.TabIndex = 21;
            this.btnbVender.Text = "VENDER CARRO";
            this.btnbVender.UseVisualStyleBackColor = true;
            this.btnbVender.Click += new System.EventHandler(this.btnbAcionarTransação_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 32);
            this.label1.TabIndex = 35;
            this.label1.Text = "MENU TRANSAÇÃO DE VENDAS";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.btnVoltar.Location = new System.Drawing.Point(256, 455);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(172, 49);
            this.btnVoltar.TabIndex = 38;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRelatórioVenda
            // 
            this.btnRelatórioVenda.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnRelatórioVenda.Location = new System.Drawing.Point(116, 365);
            this.btnRelatórioVenda.Name = "btnRelatórioVenda";
            this.btnRelatórioVenda.Size = new System.Drawing.Size(461, 66);
            this.btnRelatórioVenda.TabIndex = 37;
            this.btnRelatórioVenda.Text = "RELATÓRIO DE VENDAS";
            this.btnRelatórioVenda.UseVisualStyleBackColor = true;
            this.btnRelatórioVenda.Click += new System.EventHandler(this.btnRelatórioVenda_Click);
            // 
            // btnDesfazer
            // 
            this.btnDesfazer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnDesfazer.Location = new System.Drawing.Point(116, 281);
            this.btnDesfazer.Name = "btnDesfazer";
            this.btnDesfazer.Size = new System.Drawing.Size(461, 66);
            this.btnDesfazer.TabIndex = 36;
            this.btnDesfazer.Text = "DESFAZER VENDA";
            this.btnDesfazer.UseVisualStyleBackColor = true;
            this.btnDesfazer.Click += new System.EventHandler(this.btnDesfazer_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnPesquisar.Location = new System.Drawing.Point(116, 194);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(461, 66);
            this.btnPesquisar.TabIndex = 39;
            this.btnPesquisar.Text = "PESQUISAR VENDA";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.button2_Click);
            // 
            // MenuVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 543);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnRelatórioVenda);
            this.Controls.Add(this.btnDesfazer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnbVender);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MenuVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU VENDER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnbVender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnRelatórioVenda;
        private System.Windows.Forms.Button btnDesfazer;
        private System.Windows.Forms.Button btnPesquisar;
    }
}
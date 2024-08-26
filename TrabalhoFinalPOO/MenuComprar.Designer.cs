
namespace TrabalhoFinalPOO
{
    partial class MenuComprar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuComprar));
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnEstoqueCarro = new System.Windows.Forms.Button();
            this.btnDesfazerCompra = new System.Windows.Forms.Button();
            this.btnbComprar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 32);
            this.label1.TabIndex = 34;
            this.label1.Text = "MENU TRANSAÇÃO DE COMPRAS";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.btnVoltar.Location = new System.Drawing.Point(251, 441);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(172, 49);
            this.btnVoltar.TabIndex = 33;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnEstoqueCarro
            // 
            this.btnEstoqueCarro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnEstoqueCarro.Location = new System.Drawing.Point(112, 355);
            this.btnEstoqueCarro.Name = "btnEstoqueCarro";
            this.btnEstoqueCarro.Size = new System.Drawing.Size(461, 66);
            this.btnEstoqueCarro.TabIndex = 32;
            this.btnEstoqueCarro.Text = "ESTOQUE DE CARROS";
            this.btnEstoqueCarro.UseVisualStyleBackColor = true;
            this.btnEstoqueCarro.Click += new System.EventHandler(this.btnListarCarro_Click);
            // 
            // btnDesfazerCompra
            // 
            this.btnDesfazerCompra.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnDesfazerCompra.Location = new System.Drawing.Point(112, 271);
            this.btnDesfazerCompra.Name = "btnDesfazerCompra";
            this.btnDesfazerCompra.Size = new System.Drawing.Size(461, 66);
            this.btnDesfazerCompra.TabIndex = 29;
            this.btnDesfazerCompra.Text = "DESFAZER COMPRA";
            this.btnDesfazerCompra.UseVisualStyleBackColor = true;
            this.btnDesfazerCompra.Click += new System.EventHandler(this.btnBuscarTransação_Click);
            // 
            // btnbComprar
            // 
            this.btnbComprar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbComprar.Location = new System.Drawing.Point(112, 101);
            this.btnbComprar.Name = "btnbComprar";
            this.btnbComprar.Size = new System.Drawing.Size(461, 66);
            this.btnbComprar.TabIndex = 28;
            this.btnbComprar.Text = "COMPRAR CARRO";
            this.btnbComprar.UseVisualStyleBackColor = true;
            this.btnbComprar.Click += new System.EventHandler(this.btnbAcionarTransação_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnPesquisar.Location = new System.Drawing.Point(112, 185);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(461, 66);
            this.btnPesquisar.TabIndex = 35;
            this.btnPesquisar.Text = "PESQUISAR COMPRA";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // MenuComprar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 523);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnEstoqueCarro);
            this.Controls.Add(this.btnDesfazerCompra);
            this.Controls.Add(this.btnbComprar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MenuComprar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU COMPRAR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnEstoqueCarro;
        private System.Windows.Forms.Button btnDesfazerCompra;
        private System.Windows.Forms.Button btnbComprar;
        private System.Windows.Forms.Button btnPesquisar;
    }
}
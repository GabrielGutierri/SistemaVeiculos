namespace SistemaVeiculos.Formularios.frmPedagio
{
    partial class frmCadastraPedagio
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
            this.txtIdentificacao = new System.Windows.Forms.TextBox();
            this.txtLocalizacao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastraPedagio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIdentificacao
            // 
            this.txtIdentificacao.Location = new System.Drawing.Point(18, 28);
            this.txtIdentificacao.Margin = new System.Windows.Forms.Padding(6);
            this.txtIdentificacao.Name = "txtIdentificacao";
            this.txtIdentificacao.Size = new System.Drawing.Size(271, 20);
            this.txtIdentificacao.TabIndex = 9;
            // 
            // txtLocalizacao
            // 
            this.txtLocalizacao.Location = new System.Drawing.Point(19, 85);
            this.txtLocalizacao.Margin = new System.Windows.Forms.Padding(6);
            this.txtLocalizacao.Name = "txtLocalizacao";
            this.txtLocalizacao.Size = new System.Drawing.Size(271, 20);
            this.txtLocalizacao.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Localização";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Identificação";
            // 
            // btnCadastraPedagio
            // 
            this.btnCadastraPedagio.Location = new System.Drawing.Point(72, 157);
            this.btnCadastraPedagio.Margin = new System.Windows.Forms.Padding(6);
            this.btnCadastraPedagio.Name = "btnCadastraPedagio";
            this.btnCadastraPedagio.Size = new System.Drawing.Size(141, 27);
            this.btnCadastraPedagio.TabIndex = 5;
            this.btnCadastraPedagio.Text = "Cadastrar Pedagio";
            this.btnCadastraPedagio.UseVisualStyleBackColor = true;
            this.btnCadastraPedagio.Click += new System.EventHandler(this.btnCadastraPedagio_Click);
            // 
            // frmCadastraPedagio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 244);
            this.Controls.Add(this.txtIdentificacao);
            this.Controls.Add(this.txtLocalizacao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadastraPedagio);
            this.Name = "frmCadastraPedagio";
            this.Text = "frmCadastraPedagio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdentificacao;
        private System.Windows.Forms.TextBox txtLocalizacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastraPedagio;
    }
}
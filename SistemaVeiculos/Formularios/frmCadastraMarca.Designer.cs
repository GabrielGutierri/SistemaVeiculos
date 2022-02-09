namespace SistemaVeiculos.Formularios
{
    partial class frmCadastraMarca
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
            this.txtCodigoMarca = new System.Windows.Forms.TextBox();
            this.txtDescricaoMarca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastraMarca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCodigoMarca
            // 
            this.txtCodigoMarca.Location = new System.Drawing.Point(18, 28);
            this.txtCodigoMarca.Margin = new System.Windows.Forms.Padding(6);
            this.txtCodigoMarca.Name = "txtCodigoMarca";
            this.txtCodigoMarca.Size = new System.Drawing.Size(271, 20);
            this.txtCodigoMarca.TabIndex = 14;
            // 
            // txtDescricaoMarca
            // 
            this.txtDescricaoMarca.Location = new System.Drawing.Point(19, 85);
            this.txtDescricaoMarca.Margin = new System.Windows.Forms.Padding(6);
            this.txtDescricaoMarca.Name = "txtDescricaoMarca";
            this.txtDescricaoMarca.Size = new System.Drawing.Size(271, 20);
            this.txtDescricaoMarca.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Descrição";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Código: ";
            // 
            // btnCadastraMarca
            // 
            this.btnCadastraMarca.Location = new System.Drawing.Point(72, 157);
            this.btnCadastraMarca.Margin = new System.Windows.Forms.Padding(6);
            this.btnCadastraMarca.Name = "btnCadastraMarca";
            this.btnCadastraMarca.Size = new System.Drawing.Size(141, 27);
            this.btnCadastraMarca.TabIndex = 10;
            this.btnCadastraMarca.Text = "Cadastrar Marca";
            this.btnCadastraMarca.UseVisualStyleBackColor = true;
            this.btnCadastraMarca.Click += new System.EventHandler(this.btnCadastraMarca_Click);
            // 
            // frmCadastraMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 207);
            this.Controls.Add(this.txtCodigoMarca);
            this.Controls.Add(this.txtDescricaoMarca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadastraMarca);
            this.Name = "frmCadastraMarca";
            this.Text = "frmCadastraMarca";
            this.Load += new System.EventHandler(this.frmCadastraMarca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigoMarca;
        private System.Windows.Forms.TextBox txtDescricaoMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastraMarca;
    }
}
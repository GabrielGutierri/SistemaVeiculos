namespace SistemaVeiculos.Formularios.frmPedagio
{
    partial class frmAcoesPedagio
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
            this.txtVisualizaPedagios = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPagar = new System.Windows.Forms.Button();
            this.cbVeiculos = new System.Windows.Forms.ComboBox();
            this.cbPedagios = new System.Windows.Forms.ComboBox();
            this.btnVerTodosPedagios = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtVisualizaPedagios
            // 
            this.txtVisualizaPedagios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtVisualizaPedagios.Location = new System.Drawing.Point(12, 181);
            this.txtVisualizaPedagios.Margin = new System.Windows.Forms.Padding(6);
            this.txtVisualizaPedagios.Multiline = true;
            this.txtVisualizaPedagios.Name = "txtVisualizaPedagios";
            this.txtVisualizaPedagios.Size = new System.Drawing.Size(519, 154);
            this.txtVisualizaPedagios.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnPagar);
            this.groupBox1.Controls.Add(this.cbVeiculos);
            this.groupBox1.Controls.Add(this.cbPedagios);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 160);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pagar Pedagio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecione o pedagio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selecione o veiculo:";
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(100, 121);
            this.btnPagar.Margin = new System.Windows.Forms.Padding(6);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(121, 28);
            this.btnPagar.TabIndex = 0;
            this.btnPagar.Text = "Pagar Pedagio";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // cbVeiculos
            // 
            this.cbVeiculos.FormattingEnabled = true;
            this.cbVeiculos.Location = new System.Drawing.Point(8, 88);
            this.cbVeiculos.Margin = new System.Windows.Forms.Padding(6);
            this.cbVeiculos.Name = "cbVeiculos";
            this.cbVeiculos.Size = new System.Drawing.Size(322, 21);
            this.cbVeiculos.TabIndex = 4;
            // 
            // cbPedagios
            // 
            this.cbPedagios.FormattingEnabled = true;
            this.cbPedagios.Location = new System.Drawing.Point(9, 37);
            this.cbPedagios.Margin = new System.Windows.Forms.Padding(6);
            this.cbPedagios.Name = "cbPedagios";
            this.cbPedagios.Size = new System.Drawing.Size(321, 21);
            this.cbPedagios.TabIndex = 1;
            // 
            // btnVerTodosPedagios
            // 
            this.btnVerTodosPedagios.Location = new System.Drawing.Point(384, 67);
            this.btnVerTodosPedagios.Margin = new System.Windows.Forms.Padding(6);
            this.btnVerTodosPedagios.Name = "btnVerTodosPedagios";
            this.btnVerTodosPedagios.Size = new System.Drawing.Size(147, 40);
            this.btnVerTodosPedagios.TabIndex = 10;
            this.btnVerTodosPedagios.Text = "Ver Todos os Pedagios";
            this.btnVerTodosPedagios.UseVisualStyleBackColor = true;
            this.btnVerTodosPedagios.Click += new System.EventHandler(this.btnVerTodosPedagios_Click);
            // 
            // frmAcoesPedagio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 346);
            this.Controls.Add(this.btnVerTodosPedagios);
            this.Controls.Add(this.txtVisualizaPedagios);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAcoesPedagio";
            this.Text = "frmAcoesPedagio";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVisualizaPedagios;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.ComboBox cbVeiculos;
        private System.Windows.Forms.ComboBox cbPedagios;
        private System.Windows.Forms.Button btnVerTodosPedagios;
    }
}
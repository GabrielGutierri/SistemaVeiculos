namespace SistemaVeiculos
{
    partial class frmPrincipal
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
            this.btnCadastrarVeiculos = new System.Windows.Forms.Button();
            this.btnLerTXT = new System.Windows.Forms.Button();
            this.btnSalvarTXT = new System.Windows.Forms.Button();
            this.btnInstanciarVeiculos = new System.Windows.Forms.Button();
            this.btnAcoesPedagio = new System.Windows.Forms.Button();
            this.btnCadastrarModelo = new System.Windows.Forms.Button();
            this.btnAcoesVeiculo = new System.Windows.Forms.Button();
            this.btnCadastrarPedagio = new System.Windows.Forms.Button();
            this.btnCadastrarMarca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastrarVeiculos
            // 
            this.btnCadastrarVeiculos.Location = new System.Drawing.Point(12, 30);
            this.btnCadastrarVeiculos.Name = "btnCadastrarVeiculos";
            this.btnCadastrarVeiculos.Size = new System.Drawing.Size(105, 51);
            this.btnCadastrarVeiculos.TabIndex = 0;
            this.btnCadastrarVeiculos.Text = "Cadastrar Veiculos";
            this.btnCadastrarVeiculos.UseVisualStyleBackColor = true;
            this.btnCadastrarVeiculos.Click += new System.EventHandler(this.btnCadastrarVeiculos_Click);
            // 
            // btnLerTXT
            // 
            this.btnLerTXT.Location = new System.Drawing.Point(270, 163);
            this.btnLerTXT.Name = "btnLerTXT";
            this.btnLerTXT.Size = new System.Drawing.Size(105, 51);
            this.btnLerTXT.TabIndex = 14;
            this.btnLerTXT.Text = "Ler Arquivo Texto";
            this.btnLerTXT.UseVisualStyleBackColor = true;
            // 
            // btnSalvarTXT
            // 
            this.btnSalvarTXT.Location = new System.Drawing.Point(270, 100);
            this.btnSalvarTXT.Name = "btnSalvarTXT";
            this.btnSalvarTXT.Size = new System.Drawing.Size(105, 51);
            this.btnSalvarTXT.TabIndex = 13;
            this.btnSalvarTXT.Text = "Salvar em Arquivo Texto";
            this.btnSalvarTXT.UseVisualStyleBackColor = true;
            // 
            // btnInstanciarVeiculos
            // 
            this.btnInstanciarVeiculos.Location = new System.Drawing.Point(270, 30);
            this.btnInstanciarVeiculos.Name = "btnInstanciarVeiculos";
            this.btnInstanciarVeiculos.Size = new System.Drawing.Size(105, 51);
            this.btnInstanciarVeiculos.TabIndex = 12;
            this.btnInstanciarVeiculos.Text = "Instanciar Todos os Veiculos";
            this.btnInstanciarVeiculos.UseVisualStyleBackColor = true;
            this.btnInstanciarVeiculos.Click += new System.EventHandler(this.btnInstanciarVeiculos_Click);
            // 
            // btnAcoesPedagio
            // 
            this.btnAcoesPedagio.Location = new System.Drawing.Point(140, 163);
            this.btnAcoesPedagio.Name = "btnAcoesPedagio";
            this.btnAcoesPedagio.Size = new System.Drawing.Size(105, 51);
            this.btnAcoesPedagio.TabIndex = 11;
            this.btnAcoesPedagio.Text = "Ações Pedágio";
            this.btnAcoesPedagio.UseVisualStyleBackColor = true;
            this.btnAcoesPedagio.Click += new System.EventHandler(this.btnAcoesPedagio_Click);
            // 
            // btnCadastrarModelo
            // 
            this.btnCadastrarModelo.Location = new System.Drawing.Point(140, 100);
            this.btnCadastrarModelo.Name = "btnCadastrarModelo";
            this.btnCadastrarModelo.Size = new System.Drawing.Size(105, 51);
            this.btnCadastrarModelo.TabIndex = 10;
            this.btnCadastrarModelo.Text = "Cadastrar Modelo";
            this.btnCadastrarModelo.UseVisualStyleBackColor = true;
            this.btnCadastrarModelo.Click += new System.EventHandler(this.btnCadastrarModelo_Click);
            // 
            // btnAcoesVeiculo
            // 
            this.btnAcoesVeiculo.Location = new System.Drawing.Point(140, 30);
            this.btnAcoesVeiculo.Name = "btnAcoesVeiculo";
            this.btnAcoesVeiculo.Size = new System.Drawing.Size(105, 51);
            this.btnAcoesVeiculo.TabIndex = 9;
            this.btnAcoesVeiculo.Text = "Ações Veículos";
            this.btnAcoesVeiculo.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarPedagio
            // 
            this.btnCadastrarPedagio.Location = new System.Drawing.Point(12, 163);
            this.btnCadastrarPedagio.Name = "btnCadastrarPedagio";
            this.btnCadastrarPedagio.Size = new System.Drawing.Size(105, 51);
            this.btnCadastrarPedagio.TabIndex = 16;
            this.btnCadastrarPedagio.Text = "Cadastrar Pedagio";
            this.btnCadastrarPedagio.UseVisualStyleBackColor = true;
            this.btnCadastrarPedagio.Click += new System.EventHandler(this.btnCadastrarPedagio_Click);
            // 
            // btnCadastrarMarca
            // 
            this.btnCadastrarMarca.Location = new System.Drawing.Point(12, 100);
            this.btnCadastrarMarca.Name = "btnCadastrarMarca";
            this.btnCadastrarMarca.Size = new System.Drawing.Size(105, 51);
            this.btnCadastrarMarca.TabIndex = 15;
            this.btnCadastrarMarca.Text = "Cadastrar Marca";
            this.btnCadastrarMarca.UseVisualStyleBackColor = true;
            this.btnCadastrarMarca.Click += new System.EventHandler(this.btnCadastrarMarca_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 233);
            this.Controls.Add(this.btnCadastrarPedagio);
            this.Controls.Add(this.btnCadastrarMarca);
            this.Controls.Add(this.btnLerTXT);
            this.Controls.Add(this.btnSalvarTXT);
            this.Controls.Add(this.btnInstanciarVeiculos);
            this.Controls.Add(this.btnAcoesPedagio);
            this.Controls.Add(this.btnCadastrarModelo);
            this.Controls.Add(this.btnAcoesVeiculo);
            this.Controls.Add(this.btnCadastrarVeiculos);
            this.Name = "frmPrincipal";
            this.Text = "Menu Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarVeiculos;
        private System.Windows.Forms.Button btnLerTXT;
        private System.Windows.Forms.Button btnSalvarTXT;
        private System.Windows.Forms.Button btnInstanciarVeiculos;
        private System.Windows.Forms.Button btnAcoesPedagio;
        private System.Windows.Forms.Button btnCadastrarModelo;
        private System.Windows.Forms.Button btnAcoesVeiculo;
        private System.Windows.Forms.Button btnCadastrarPedagio;
        private System.Windows.Forms.Button btnCadastrarMarca;
    }
}


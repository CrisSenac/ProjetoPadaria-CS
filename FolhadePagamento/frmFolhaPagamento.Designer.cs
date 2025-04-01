namespace FolhadePagamento
{
    partial class frmFolhaPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFolhaPagamento));
            this.lblDataFolha = new System.Windows.Forms.Label();
            this.dtpDataFolha = new System.Windows.Forms.DateTimePicker();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lblClube = new System.Windows.Forms.Label();
            this.ckbPlanoSaude = new System.Windows.Forms.CheckBox();
            this.cbbClube = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblSalarioFolha = new System.Windows.Forms.Label();
            this.txtSalarioFolha = new System.Windows.Forms.TextBox();
            this.lblImposto = new System.Windows.Forms.Label();
            this.txtImposto = new System.Windows.Forms.TextBox();
            this.lblSalarioLiquido = new System.Windows.Forms.Label();
            this.txtSalarioLiquido = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDataFolha
            // 
            this.lblDataFolha.AutoSize = true;
            this.lblDataFolha.Location = new System.Drawing.Point(147, 46);
            this.lblDataFolha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataFolha.Name = "lblDataFolha";
            this.lblDataFolha.Size = new System.Drawing.Size(110, 20);
            this.lblDataFolha.TabIndex = 0;
            this.lblDataFolha.Text = "Data da Folha";
            // 
            // dtpDataFolha
            // 
            this.dtpDataFolha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFolha.Location = new System.Drawing.Point(151, 69);
            this.dtpDataFolha.Name = "dtpDataFolha";
            this.dtpDataFolha.Size = new System.Drawing.Size(122, 26);
            this.dtpDataFolha.TabIndex = 0;
            this.dtpDataFolha.TabStop = false;
            this.dtpDataFolha.Value = new System.DateTime(2025, 3, 31, 0, 0, 0, 0);
            this.dtpDataFolha.ValueChanged += new System.EventHandler(this.dtpDataFolha_ValueChanged);
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(147, 113);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(58, 20);
            this.lblSalario.TabIndex = 2;
            this.lblSalario.Text = "Salário";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(151, 136);
            this.txtSalario.MaxLength = 10;
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 26);
            this.txtSalario.TabIndex = 1;
            this.txtSalario.TextChanged += new System.EventHandler(this.txbSalario_TextChanged);
            // 
            // lblClube
            // 
            this.lblClube.AutoSize = true;
            this.lblClube.Location = new System.Drawing.Point(147, 235);
            this.lblClube.Name = "lblClube";
            this.lblClube.Size = new System.Drawing.Size(116, 20);
            this.lblClube.TabIndex = 5;
            this.lblClube.Text = "Clube de Lazer";
            this.lblClube.Click += new System.EventHandler(this.label1_Click);
            // 
            // ckbPlanoSaude
            // 
            this.ckbPlanoSaude.AutoSize = true;
            this.ckbPlanoSaude.Location = new System.Drawing.Point(151, 192);
            this.ckbPlanoSaude.Name = "ckbPlanoSaude";
            this.ckbPlanoSaude.Size = new System.Drawing.Size(141, 24);
            this.ckbPlanoSaude.TabIndex = 2;
            this.ckbPlanoSaude.Text = "Plano de Saúde";
            this.ckbPlanoSaude.UseVisualStyleBackColor = true;
            // 
            // cbbClube
            // 
            this.cbbClube.FormattingEnabled = true;
            this.cbbClube.Items.AddRange(new object[] {
            "Clube A",
            "Clube B",
            "Clube C"});
            this.cbbClube.Location = new System.Drawing.Point(151, 269);
            this.cbbClube.Name = "cbbClube";
            this.cbbClube.Size = new System.Drawing.Size(121, 28);
            this.cbbClube.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcular.Image")));
            this.btnCalcular.Location = new System.Drawing.Point(598, 46);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(134, 59);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(598, 157);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(134, 59);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(598, 269);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(134, 59);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "&Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblSalarioFolha
            // 
            this.lblSalarioFolha.AutoSize = true;
            this.lblSalarioFolha.Location = new System.Drawing.Point(354, 46);
            this.lblSalarioFolha.Name = "lblSalarioFolha";
            this.lblSalarioFolha.Size = new System.Drawing.Size(102, 20);
            this.lblSalarioFolha.TabIndex = 12;
            this.lblSalarioFolha.Text = "Salário Folha";
            // 
            // txtSalarioFolha
            // 
            this.txtSalarioFolha.Enabled = false;
            this.txtSalarioFolha.Location = new System.Drawing.Point(356, 79);
            this.txtSalarioFolha.Name = "txtSalarioFolha";
            this.txtSalarioFolha.Size = new System.Drawing.Size(100, 26);
            this.txtSalarioFolha.TabIndex = 13;
            // 
            // lblImposto
            // 
            this.lblImposto.AutoSize = true;
            this.lblImposto.Location = new System.Drawing.Point(354, 136);
            this.lblImposto.Name = "lblImposto";
            this.lblImposto.Size = new System.Drawing.Size(141, 20);
            this.lblImposto.TabIndex = 14;
            this.lblImposto.Text = "Imposto de Renda";
            // 
            // txtImposto
            // 
            this.txtImposto.Enabled = false;
            this.txtImposto.Location = new System.Drawing.Point(356, 173);
            this.txtImposto.Name = "txtImposto";
            this.txtImposto.Size = new System.Drawing.Size(100, 26);
            this.txtImposto.TabIndex = 4;
            // 
            // lblSalarioLiquido
            // 
            this.lblSalarioLiquido.AutoSize = true;
            this.lblSalarioLiquido.Location = new System.Drawing.Point(354, 221);
            this.lblSalarioLiquido.Name = "lblSalarioLiquido";
            this.lblSalarioLiquido.Size = new System.Drawing.Size(113, 20);
            this.lblSalarioLiquido.TabIndex = 16;
            this.lblSalarioLiquido.Text = "Salário Líquido";
            // 
            // txtSalarioLiquido
            // 
            this.txtSalarioLiquido.Enabled = false;
            this.txtSalarioLiquido.Location = new System.Drawing.Point(358, 254);
            this.txtSalarioLiquido.Name = "txtSalarioLiquido";
            this.txtSalarioLiquido.Size = new System.Drawing.Size(100, 26);
            this.txtSalarioLiquido.TabIndex = 17;
            // 
            // frmFolhaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 388);
            this.Controls.Add(this.txtSalarioLiquido);
            this.Controls.Add(this.lblSalarioLiquido);
            this.Controls.Add(this.txtImposto);
            this.Controls.Add(this.lblImposto);
            this.Controls.Add(this.txtSalarioFolha);
            this.Controls.Add(this.lblSalarioFolha);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.cbbClube);
            this.Controls.Add(this.ckbPlanoSaude);
            this.Controls.Add(this.lblClube);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.dtpDataFolha);
            this.Controls.Add(this.lblDataFolha);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmFolhaPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Folha de Pagamento";
            this.Load += new System.EventHandler(this.frmFolhaPagamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDataFolha;
        private System.Windows.Forms.DateTimePicker dtpDataFolha;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lblClube;
        private System.Windows.Forms.CheckBox ckbPlanoSaude;
        private System.Windows.Forms.ComboBox cbbClube;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblSalarioFolha;
        private System.Windows.Forms.TextBox txtSalarioFolha;
        private System.Windows.Forms.Label lblImposto;
        private System.Windows.Forms.TextBox txtImposto;
        private System.Windows.Forms.Label lblSalarioLiquido;
        private System.Windows.Forms.TextBox txtSalarioLiquido;
    }
}
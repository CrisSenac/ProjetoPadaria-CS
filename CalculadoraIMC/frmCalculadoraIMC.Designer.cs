namespace CalculadoraIMC
{
    partial class frmCalculadoraIMC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculadoraIMC));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.btnHomem = new System.Windows.Forms.Button();
            this.btnMulher = new System.Windows.Forms.Button();
            this.lblIdade = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.lblAltura = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(293, 30);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(148, 20);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Calculadora de IMC";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(293, 59);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(150, 20);
            this.lblSexo.TabIndex = 1;
            this.lblSexo.Text = "Selecione o gênero:";
            // 
            // btnHomem
            // 
            this.btnHomem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnHomem.Image = ((System.Drawing.Image)(resources.GetObject("btnHomem.Image")));
            this.btnHomem.Location = new System.Drawing.Point(224, 93);
            this.btnHomem.Name = "btnHomem";
            this.btnHomem.Size = new System.Drawing.Size(129, 161);
            this.btnHomem.TabIndex = 0;
            this.btnHomem.Text = "&Masculino";
            this.btnHomem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHomem.UseVisualStyleBackColor = false;
            // 
            // btnMulher
            // 
            this.btnMulher.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnMulher.Image = ((System.Drawing.Image)(resources.GetObject("btnMulher.Image")));
            this.btnMulher.Location = new System.Drawing.Point(398, 93);
            this.btnMulher.Name = "btnMulher";
            this.btnMulher.Size = new System.Drawing.Size(129, 161);
            this.btnMulher.TabIndex = 1;
            this.btnMulher.Text = "&Feminino";
            this.btnMulher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMulher.UseVisualStyleBackColor = false;
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(267, 278);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(54, 20);
            this.lblIdade.TabIndex = 4;
            this.lblIdade.Text = "Idade:";
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(341, 275);
            this.txtIdade.MaxLength = 3;
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(100, 26);
            this.txtIdade.TabIndex = 2;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(341, 320);
            this.txtAltura.MaxLength = 4;
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 26);
            this.txtAltura.TabIndex = 3;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(267, 323);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(55, 20);
            this.lblAltura.TabIndex = 6;
            this.lblAltura.Text = "Altura:";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(341, 364);
            this.txtPeso.MaxLength = 3;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 26);
            this.txtPeso.TabIndex = 4;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(267, 367);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(49, 20);
            this.lblPeso.TabIndex = 8;
            this.lblPeso.Text = "Peso:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(230, 475);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(123, 56);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcular.Image")));
            this.btnCalcular.Location = new System.Drawing.Point(422, 475);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(123, 56);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(346, 403);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(86, 20);
            this.lblResultado.TabIndex = 12;
            this.lblResultado.Text = "Resultado:";
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Location = new System.Drawing.Point(297, 426);
            this.txtResultado.MaxLength = 5;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(180, 26);
            this.txtResultado.TabIndex = 8;
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(649, 493);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(123, 56);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "&Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmCalculadoraIMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.btnMulher);
            this.Controls.Add(this.btnHomem);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmCalculadoraIMC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo de  IMC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Button btnHomem;
        private System.Windows.Forms.Button btnMulher;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnSair;
    }
}
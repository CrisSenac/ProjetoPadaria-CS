namespace Padaria
{
    partial class frmPesquisarFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisarFuncionarios));
            this.gpbPesquisarFunc = new System.Windows.Forms.GroupBox();
            this.rdbCodigo = new System.Windows.Forms.RadioButton();
            this.rdbNome = new System.Windows.Forms.RadioButton();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.ltbPesquisar = new System.Windows.Forms.ListBox();
            this.gpbPesquisarFunc.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbPesquisarFunc
            // 
            this.gpbPesquisarFunc.Controls.Add(this.lblDescricao);
            this.gpbPesquisarFunc.Controls.Add(this.txtDescricao);
            this.gpbPesquisarFunc.Controls.Add(this.rdbNome);
            this.gpbPesquisarFunc.Controls.Add(this.rdbCodigo);
            this.gpbPesquisarFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPesquisarFunc.Location = new System.Drawing.Point(12, 12);
            this.gpbPesquisarFunc.Name = "gpbPesquisarFunc";
            this.gpbPesquisarFunc.Size = new System.Drawing.Size(630, 124);
            this.gpbPesquisarFunc.TabIndex = 0;
            this.gpbPesquisarFunc.TabStop = false;
            this.gpbPesquisarFunc.Text = "Pesquisar por";
            this.gpbPesquisarFunc.Enter += new System.EventHandler(this.gpbPesquisarFunc_Enter);
            // 
            // rdbCodigo
            // 
            this.rdbCodigo.AutoSize = true;
            this.rdbCodigo.Location = new System.Drawing.Point(188, 25);
            this.rdbCodigo.Name = "rdbCodigo";
            this.rdbCodigo.Size = new System.Drawing.Size(77, 24);
            this.rdbCodigo.TabIndex = 0;
            this.rdbCodigo.TabStop = true;
            this.rdbCodigo.Text = "Código";
            this.rdbCodigo.UseVisualStyleBackColor = true;
            // 
            // rdbNome
            // 
            this.rdbNome.AutoSize = true;
            this.rdbNome.Location = new System.Drawing.Point(383, 25);
            this.rdbNome.Name = "rdbNome";
            this.rdbNome.Size = new System.Drawing.Size(69, 24);
            this.rdbNome.TabIndex = 1;
            this.rdbNome.TabStop = true;
            this.rdbNome.Text = "Nome";
            this.rdbNome.UseVisualStyleBackColor = true;
            this.rdbNome.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(118, 79);
            this.txtDescricao.MaxLength = 30;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(506, 26);
            this.txtDescricao.TabIndex = 2;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(32, 82);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(80, 20);
            this.lblDescricao.TabIndex = 3;
            this.lblDescricao.Text = "Descrição";
            this.lblDescricao.Click += new System.EventHandler(this.lblDescricao_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(648, 22);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(110, 87);
            this.btnPesquisar.TabIndex = 5;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(648, 133);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(110, 87);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // ltbPesquisar
            // 
            this.ltbPesquisar.FormattingEnabled = true;
            this.ltbPesquisar.Location = new System.Drawing.Point(12, 154);
            this.ltbPesquisar.Name = "ltbPesquisar";
            this.ltbPesquisar.Size = new System.Drawing.Size(518, 95);
            this.ltbPesquisar.TabIndex = 4;
            // 
            // frmPesquisarFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 261);
            this.Controls.Add(this.ltbPesquisar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.gpbPesquisarFunc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmPesquisarFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar Funcionários - Padaria";
            this.gpbPesquisarFunc.ResumeLayout(false);
            this.gpbPesquisarFunc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbPesquisarFunc;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.RadioButton rdbNome;
        private System.Windows.Forms.RadioButton rdbCodigo;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ListBox ltbPesquisar;
    }
}
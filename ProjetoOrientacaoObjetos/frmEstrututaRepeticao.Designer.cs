namespace ProjetoOrientacaoObjetos
{
    partial class frmEstrututaRepeticao
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
            this.cbbEstado = new System.Windows.Forms.ComboBox();
            this.ltbListaDeEstados = new System.Windows.Forms.ListBox();
            this.btnCarregaEstado = new System.Windows.Forms.Button();
            this.btnCarregaLista = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblListaDesejos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInserirEstado = new System.Windows.Forms.TextBox();
            this.btnInserirEstado = new System.Windows.Forms.Button();
            this.btnLimparEstado = new System.Windows.Forms.Button();
            this.btnLimpaItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbbEstado
            // 
            this.cbbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbEstado.FormattingEnabled = true;
            this.cbbEstado.Location = new System.Drawing.Point(57, 80);
            this.cbbEstado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbEstado.Name = "cbbEstado";
            this.cbbEstado.Size = new System.Drawing.Size(180, 28);
            this.cbbEstado.TabIndex = 0;
            this.cbbEstado.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ltbListaDeEstados
            // 
            this.ltbListaDeEstados.FormattingEnabled = true;
            this.ltbListaDeEstados.ItemHeight = 20;
            this.ltbListaDeEstados.Location = new System.Drawing.Point(347, 80);
            this.ltbListaDeEstados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ltbListaDeEstados.Name = "ltbListaDeEstados";
            this.ltbListaDeEstados.Size = new System.Drawing.Size(292, 284);
            this.ltbListaDeEstados.TabIndex = 1;
            this.ltbListaDeEstados.SelectedIndexChanged += new System.EventHandler(this.ltbListaDeDesejos_SelectedIndexChanged);
            // 
            // btnCarregaEstado
            // 
            this.btnCarregaEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregaEstado.Location = new System.Drawing.Point(55, 404);
            this.btnCarregaEstado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCarregaEstado.Name = "btnCarregaEstado";
            this.btnCarregaEstado.Size = new System.Drawing.Size(216, 63);
            this.btnCarregaEstado.TabIndex = 2;
            this.btnCarregaEstado.Text = "Carrega Estado";
            this.btnCarregaEstado.UseVisualStyleBackColor = true;
            this.btnCarregaEstado.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCarregaLista
            // 
            this.btnCarregaLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregaLista.Location = new System.Drawing.Point(345, 404);
            this.btnCarregaLista.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCarregaLista.Name = "btnCarregaLista";
            this.btnCarregaLista.Size = new System.Drawing.Size(294, 68);
            this.btnCarregaLista.TabIndex = 3;
            this.btnCarregaLista.Text = "Carrega Lista de Desejos";
            this.btnCarregaLista.UseVisualStyleBackColor = true;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(51, 44);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(60, 20);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "Estado";
            // 
            // lblListaDesejos
            // 
            this.lblListaDesejos.AutoSize = true;
            this.lblListaDesejos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaDesejos.Location = new System.Drawing.Point(341, 44);
            this.lblListaDesejos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblListaDesejos.Name = "lblListaDesejos";
            this.lblListaDesejos.Size = new System.Drawing.Size(128, 20);
            this.lblListaDesejos.TabIndex = 5;
            this.lblListaDesejos.Text = "Lista de Estados";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 160);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Digite o Estado";
            // 
            // txtInserirEstado
            // 
            this.txtInserirEstado.Location = new System.Drawing.Point(55, 194);
            this.txtInserirEstado.Name = "txtInserirEstado";
            this.txtInserirEstado.Size = new System.Drawing.Size(263, 26);
            this.txtInserirEstado.TabIndex = 7;
            this.txtInserirEstado.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnInserirEstado
            // 
            this.btnInserirEstado.Location = new System.Drawing.Point(55, 236);
            this.btnInserirEstado.Name = "btnInserirEstado";
            this.btnInserirEstado.Size = new System.Drawing.Size(121, 29);
            this.btnInserirEstado.TabIndex = 8;
            this.btnInserirEstado.Text = "Inserir Estado";
            this.btnInserirEstado.UseVisualStyleBackColor = true;
            this.btnInserirEstado.Click += new System.EventHandler(this.btnInserirEstado_Click);
            // 
            // btnLimparEstado
            // 
            this.btnLimparEstado.Location = new System.Drawing.Point(192, 232);
            this.btnLimparEstado.Name = "btnLimparEstado";
            this.btnLimparEstado.Size = new System.Drawing.Size(126, 33);
            this.btnLimparEstado.TabIndex = 9;
            this.btnLimparEstado.Text = "Limpar Estado";
            this.btnLimparEstado.UseVisualStyleBackColor = true;
            this.btnLimparEstado.Click += new System.EventHandler(this.btnLimparEstado_Click);
            // 
            // btnLimpaItem
            // 
            this.btnLimpaItem.Location = new System.Drawing.Point(55, 283);
            this.btnLimpaItem.Name = "btnLimpaItem";
            this.btnLimpaItem.Size = new System.Drawing.Size(263, 38);
            this.btnLimpaItem.TabIndex = 10;
            this.btnLimpaItem.Text = "Limpa Item Estado";
            this.btnLimpaItem.UseVisualStyleBackColor = true;
            this.btnLimpaItem.Click += new System.EventHandler(this.btnLimpaItem_Click);
            // 
            // frmEstrututaRepeticao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 532);
            this.Controls.Add(this.btnLimpaItem);
            this.Controls.Add(this.btnLimparEstado);
            this.Controls.Add(this.btnInserirEstado);
            this.Controls.Add(this.txtInserirEstado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblListaDesejos);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnCarregaLista);
            this.Controls.Add(this.btnCarregaEstado);
            this.Controls.Add(this.ltbListaDeEstados);
            this.Controls.Add(this.cbbEstado);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmEstrututaRepeticao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEstrututaRepeticao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbEstado;
        private System.Windows.Forms.ListBox ltbListaDeEstados;
        private System.Windows.Forms.Button btnCarregaEstado;
        private System.Windows.Forms.Button btnCarregaLista;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblListaDesejos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInserirEstado;
        private System.Windows.Forms.Button btnInserirEstado;
        private System.Windows.Forms.Button btnLimparEstado;
        private System.Windows.Forms.Button btnLimpaItem;
    }
}
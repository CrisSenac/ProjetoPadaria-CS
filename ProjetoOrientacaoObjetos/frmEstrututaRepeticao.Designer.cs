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
            this.ltbListaDeDesejos = new System.Windows.Forms.ListBox();
            this.btnCarregaEstado = new System.Windows.Forms.Button();
            this.btnCarregaLista = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblListaDesejos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbbEstado
            // 
            this.cbbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbEstado.FormattingEnabled = true;
            this.cbbEstado.Location = new System.Drawing.Point(60, 70);
            this.cbbEstado.Name = "cbbEstado";
            this.cbbEstado.Size = new System.Drawing.Size(121, 28);
            this.cbbEstado.TabIndex = 0;
            this.cbbEstado.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ltbListaDeDesejos
            // 
            this.ltbListaDeDesejos.FormattingEnabled = true;
            this.ltbListaDeDesejos.Location = new System.Drawing.Point(253, 70);
            this.ltbListaDeDesejos.Name = "ltbListaDeDesejos";
            this.ltbListaDeDesejos.Size = new System.Drawing.Size(196, 186);
            this.ltbListaDeDesejos.TabIndex = 1;
            this.ltbListaDeDesejos.SelectedIndexChanged += new System.EventHandler(this.ltbListaDeDesejos_SelectedIndexChanged);
            // 
            // btnCarregaEstado
            // 
            this.btnCarregaEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregaEstado.Location = new System.Drawing.Point(48, 309);
            this.btnCarregaEstado.Name = "btnCarregaEstado";
            this.btnCarregaEstado.Size = new System.Drawing.Size(144, 41);
            this.btnCarregaEstado.TabIndex = 2;
            this.btnCarregaEstado.Text = "Carrega Estado";
            this.btnCarregaEstado.UseVisualStyleBackColor = true;
            this.btnCarregaEstado.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCarregaLista
            // 
            this.btnCarregaLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregaLista.Location = new System.Drawing.Point(253, 309);
            this.btnCarregaLista.Name = "btnCarregaLista";
            this.btnCarregaLista.Size = new System.Drawing.Size(196, 41);
            this.btnCarregaLista.TabIndex = 3;
            this.btnCarregaLista.Text = "Carrega Lista de Desejos";
            this.btnCarregaLista.UseVisualStyleBackColor = true;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(56, 47);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(60, 20);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "Estado";
            // 
            // lblListaDesejos
            // 
            this.lblListaDesejos.AutoSize = true;
            this.lblListaDesejos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaDesejos.Location = new System.Drawing.Point(249, 47);
            this.lblListaDesejos.Name = "lblListaDesejos";
            this.lblListaDesejos.Size = new System.Drawing.Size(127, 20);
            this.lblListaDesejos.TabIndex = 5;
            this.lblListaDesejos.Text = "Lista de Desejos";
            // 
            // frmEstrututaRepeticao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 412);
            this.Controls.Add(this.lblListaDesejos);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnCarregaLista);
            this.Controls.Add(this.btnCarregaEstado);
            this.Controls.Add(this.ltbListaDeDesejos);
            this.Controls.Add(this.cbbEstado);
            this.Name = "frmEstrututaRepeticao";
            this.Text = "frmEstrututaRepeticao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbEstado;
        private System.Windows.Forms.ListBox ltbListaDeDesejos;
        private System.Windows.Forms.Button btnCarregaEstado;
        private System.Windows.Forms.Button btnCarregaLista;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblListaDesejos;
    }
}
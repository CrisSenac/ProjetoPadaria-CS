namespace Padaria
{
    partial class frmFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFuncionarios));
            this.gpbDadosPessoais = new System.Windows.Forms.GroupBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.dtpDataNasc = new System.Windows.Forms.DateTimePicker();
            this.mtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.gpbSexo = new System.Windows.Forms.GroupBox();
            this.rdbFeminino = new System.Windows.Forms.RadioButton();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.rdbNaoInformar = new System.Windows.Forms.RadioButton();
            this.lblFoto = new System.Windows.Forms.Label();
            this.pctFoto = new System.Windows.Forms.PictureBox();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.btnExcluirFoto = new System.Windows.Forms.Button();
            this.btnAlterarFoto = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mtbCep = new System.Windows.Forms.MaskedTextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.cmbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.gpbDadosPessoais.SuspendLayout();
            this.gpbSexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctFoto)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbDadosPessoais
            // 
            this.gpbDadosPessoais.Controls.Add(this.lblEstadoCivil);
            this.gpbDadosPessoais.Controls.Add(this.cmbEstadoCivil);
            this.gpbDadosPessoais.Controls.Add(this.btnAlterarFoto);
            this.gpbDadosPessoais.Controls.Add(this.btnExcluirFoto);
            this.gpbDadosPessoais.Controls.Add(this.btnCarregar);
            this.gpbDadosPessoais.Controls.Add(this.pctFoto);
            this.gpbDadosPessoais.Controls.Add(this.lblFoto);
            this.gpbDadosPessoais.Controls.Add(this.gpbSexo);
            this.gpbDadosPessoais.Controls.Add(this.mtbTelefone);
            this.gpbDadosPessoais.Controls.Add(this.lblTelefone);
            this.gpbDadosPessoais.Controls.Add(this.dtpDataNasc);
            this.gpbDadosPessoais.Controls.Add(this.lblDataNasc);
            this.gpbDadosPessoais.Controls.Add(this.mskCpf);
            this.gpbDadosPessoais.Controls.Add(this.lblCpf);
            this.gpbDadosPessoais.Controls.Add(this.txtEmail);
            this.gpbDadosPessoais.Controls.Add(this.lblEmail);
            this.gpbDadosPessoais.Controls.Add(this.txtNome);
            this.gpbDadosPessoais.Controls.Add(this.lblNome);
            this.gpbDadosPessoais.Controls.Add(this.txtCodigo);
            this.gpbDadosPessoais.Controls.Add(this.lblCodigo);
            this.gpbDadosPessoais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDadosPessoais.Location = new System.Drawing.Point(12, 12);
            this.gpbDadosPessoais.Name = "gpbDadosPessoais";
            this.gpbDadosPessoais.Size = new System.Drawing.Size(760, 301);
            this.gpbDadosPessoais.TabIndex = 0;
            this.gpbDadosPessoais.TabStop = false;
            this.gpbDadosPessoais.Text = "Dados Pessoais";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(20, 35);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(59, 20);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(85, 32);
            this.txtCodigo.MaxLength = 10;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(72, 26);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(249, 32);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(454, 26);
            this.txtNome.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(192, 35);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 20);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(76, 64);
            this.txtEmail.MaxLength = 30;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(454, 26);
            this.txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(19, 70);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(53, 20);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "E-mail";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(536, 67);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(40, 20);
            this.lblCpf.TabIndex = 6;
            this.lblCpf.Text = "CPF";
            // 
            // mskCpf
            // 
            this.mskCpf.Location = new System.Drawing.Point(582, 67);
            this.mskCpf.Mask = "000,000,000-00";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(121, 26);
            this.mskCpf.TabIndex = 4;
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.Location = new System.Drawing.Point(19, 103);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(154, 20);
            this.lblDataNasc.TabIndex = 8;
            this.lblDataNasc.Text = "Data de Nascimento";
            // 
            // dtpDataNasc
            // 
            this.dtpDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNasc.Location = new System.Drawing.Point(179, 98);
            this.dtpDataNasc.Name = "dtpDataNasc";
            this.dtpDataNasc.Size = new System.Drawing.Size(122, 26);
            this.dtpDataNasc.TabIndex = 5;
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.Location = new System.Drawing.Point(391, 96);
            this.mtbTelefone.Mask = "00000-9999";
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.Size = new System.Drawing.Size(99, 26);
            this.mtbTelefone.TabIndex = 6;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(314, 103);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(71, 20);
            this.lblTelefone.TabIndex = 10;
            this.lblTelefone.Text = "Telefone";
            // 
            // gpbSexo
            // 
            this.gpbSexo.Controls.Add(this.rdbNaoInformar);
            this.gpbSexo.Controls.Add(this.rdbMasculino);
            this.gpbSexo.Controls.Add(this.rdbFeminino);
            this.gpbSexo.Location = new System.Drawing.Point(480, 165);
            this.gpbSexo.Name = "gpbSexo";
            this.gpbSexo.Size = new System.Drawing.Size(200, 100);
            this.gpbSexo.TabIndex = 12;
            this.gpbSexo.TabStop = false;
            this.gpbSexo.Text = "Sexo";
            // 
            // rdbFeminino
            // 
            this.rdbFeminino.AutoSize = true;
            this.rdbFeminino.Location = new System.Drawing.Point(18, 25);
            this.rdbFeminino.Name = "rdbFeminino";
            this.rdbFeminino.Size = new System.Drawing.Size(92, 24);
            this.rdbFeminino.TabIndex = 11;
            this.rdbFeminino.TabStop = true;
            this.rdbFeminino.Text = "Feminino";
            this.rdbFeminino.UseVisualStyleBackColor = true;
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(18, 47);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(98, 24);
            this.rdbMasculino.TabIndex = 12;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // rdbNaoInformar
            // 
            this.rdbNaoInformar.AutoSize = true;
            this.rdbNaoInformar.Location = new System.Drawing.Point(18, 70);
            this.rdbNaoInformar.Name = "rdbNaoInformar";
            this.rdbNaoInformar.Size = new System.Drawing.Size(169, 24);
            this.rdbNaoInformar.TabIndex = 13;
            this.rdbNaoInformar.TabStop = true;
            this.rdbNaoInformar.Text = "Não desejo informar";
            this.rdbNaoInformar.UseVisualStyleBackColor = true;
            this.rdbNaoInformar.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Location = new System.Drawing.Point(20, 138);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(42, 20);
            this.lblFoto.TabIndex = 13;
            this.lblFoto.Text = "Foto";
            // 
            // pctFoto
            // 
            this.pctFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctFoto.Location = new System.Drawing.Point(154, 160);
            this.pctFoto.Name = "pctFoto";
            this.pctFoto.Size = new System.Drawing.Size(132, 127);
            this.pctFoto.TabIndex = 14;
            this.pctFoto.TabStop = false;
            // 
            // btnCarregar
            // 
            this.btnCarregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregar.Location = new System.Drawing.Point(23, 165);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(75, 30);
            this.btnCarregar.TabIndex = 8;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            // 
            // btnExcluirFoto
            // 
            this.btnExcluirFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirFoto.Location = new System.Drawing.Point(24, 212);
            this.btnExcluirFoto.Name = "btnExcluirFoto";
            this.btnExcluirFoto.Size = new System.Drawing.Size(75, 28);
            this.btnExcluirFoto.TabIndex = 9;
            this.btnExcluirFoto.Text = "Excluir";
            this.btnExcluirFoto.UseVisualStyleBackColor = true;
            this.btnExcluirFoto.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAlterarFoto
            // 
            this.btnAlterarFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarFoto.Location = new System.Drawing.Point(23, 260);
            this.btnAlterarFoto.Name = "btnAlterarFoto";
            this.btnAlterarFoto.Size = new System.Drawing.Size(75, 27);
            this.btnAlterarFoto.TabIndex = 10;
            this.btnAlterarFoto.Text = "Alterar";
            this.btnAlterarFoto.UseVisualStyleBackColor = true;
            this.btnAlterarFoto.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtComplemento);
            this.groupBox2.Controls.Add(this.lblComplemento);
            this.groupBox2.Controls.Add(this.txtNumero);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.lblEstado);
            this.groupBox2.Controls.Add(this.cmbEstado);
            this.groupBox2.Controls.Add(this.txtCidade);
            this.groupBox2.Controls.Add(this.lblCidade);
            this.groupBox2.Controls.Add(this.txtBairro);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.mtbCep);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtLogradouro);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(8, 319);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(764, 136);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endereço";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(106, 25);
            this.txtLogradouro.MaxLength = 50;
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(445, 26);
            this.txtLogradouro.TabIndex = 14;
            this.txtLogradouro.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Logradouro";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(569, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "CEP";
            // 
            // mtbCep
            // 
            this.mtbCep.Location = new System.Drawing.Point(616, 28);
            this.mtbCep.Mask = "00000-000";
            this.mtbCep.Name = "mtbCep";
            this.mtbCep.Size = new System.Drawing.Size(91, 26);
            this.mtbCep.TabIndex = 15;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(224, 68);
            this.txtBairro.MaxLength = 20;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(139, 26);
            this.txtBairro.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(169, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Bairro";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(444, 67);
            this.txtCidade.MaxLength = 30;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(145, 26);
            this.txtCidade.TabIndex = 18;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(379, 73);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(59, 20);
            this.lblCidade.TabIndex = 11;
            this.lblCidade.Text = "Cidade";
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            " AC",
            " AL",
            " AP",
            " AM",
            " BA",
            " CE",
            " DF",
            " ES",
            " GO",
            " MA",
            " MT",
            " MS",
            " MG",
            " PA",
            " PB",
            " PR",
            " PE",
            " PI",
            " RJ",
            " RN",
            " RS",
            " RO",
            " RR",
            " SC",
            " SP",
            " SE",
            " TO"});
            this.cmbEstado.Location = new System.Drawing.Point(669, 67);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(62, 28);
            this.cmbEstado.TabIndex = 19;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(603, 73);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(60, 20);
            this.lblEstado.TabIndex = 14;
            this.lblEstado.Text = "Estado";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(82, 65);
            this.txtNumero.MaxLength = 10;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(79, 26);
            this.txtNumero.TabIndex = 16;
            this.txtNumero.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 20);
            this.label12.TabIndex = 15;
            this.label12.Text = "Número";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.Controls.Add(this.btnLimpar);
            this.panel1.Controls.Add(this.btnPesquisar);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.btnAlterar);
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Controls.Add(this.btnNovo);
            this.panel1.Location = new System.Drawing.Point(8, 467);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 78);
            this.panel1.TabIndex = 2;
            // 
            // btnNovo
            // 
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.Location = new System.Drawing.Point(4, 19);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(100, 40);
            this.btnNovo.TabIndex = 21;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.Location = new System.Drawing.Point(110, 19);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(100, 40);
            this.btnCadastrar.TabIndex = 22;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(222, 19);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(100, 40);
            this.btnAlterar.TabIndex = 23;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(328, 19);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 40);
            this.btnExcluir.TabIndex = 24;
            this.btnExcluir.Text = "E&xcluir";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(434, 19);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 40);
            this.btnPesquisar.TabIndex = 25;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(544, 19);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 40);
            this.btnLimpar.TabIndex = 26;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(650, 19);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(100, 40);
            this.btnVoltar.TabIndex = 27;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Location = new System.Drawing.Point(499, 102);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(91, 20);
            this.lblEstadoCivil.TabIndex = 19;
            this.lblEstadoCivil.Text = "Estado Civil";
            this.lblEstadoCivil.Click += new System.EventHandler(this.lblEstadoCivil_Click);
            // 
            // cmbEstadoCivil
            // 
            this.cmbEstadoCivil.FormattingEnabled = true;
            this.cmbEstadoCivil.Items.AddRange(new object[] {
            "Solteiro(a)",
            "Casado(a)",
            "Viúvo(a)",
            "Divorciado(a)",
            "União estável"});
            this.cmbEstadoCivil.Location = new System.Drawing.Point(596, 96);
            this.cmbEstadoCivil.Name = "cmbEstadoCivil";
            this.cmbEstadoCivil.Size = new System.Drawing.Size(107, 28);
            this.cmbEstadoCivil.TabIndex = 7;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(122, 104);
            this.txtComplemento.MaxLength = 20;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(241, 26);
            this.txtComplemento.TabIndex = 20;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(8, 107);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(108, 20);
            this.lblComplemento.TabIndex = 17;
            this.lblComplemento.Text = "Complemento";
            // 
            // frmFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 557);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gpbDadosPessoais);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionarios - Padaria";
            this.gpbDadosPessoais.ResumeLayout(false);
            this.gpbDadosPessoais.PerformLayout();
            this.gpbSexo.ResumeLayout(false);
            this.gpbSexo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctFoto)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDadosPessoais;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.MaskedTextBox mskCpf;
        private System.Windows.Forms.Label lblDataNasc;
        private System.Windows.Forms.DateTimePicker dtpDataNasc;
        private System.Windows.Forms.MaskedTextBox mtbTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.GroupBox gpbSexo;
        private System.Windows.Forms.RadioButton rdbNaoInformar;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.RadioButton rdbFeminino;
        private System.Windows.Forms.Button btnAlterarFoto;
        private System.Windows.Forms.Button btnExcluirFoto;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.PictureBox pctFoto;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox mtbCep;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.ComboBox cmbEstadoCivil;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label lblComplemento;
    }
}
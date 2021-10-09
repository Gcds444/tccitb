namespace GUI
{
    partial class Cliente
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
            this.components = new System.ComponentModel.Container();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTelRepresentante = new System.Windows.Forms.MaskedTextBox();
            this.txtCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.btnEncontrar = new System.Windows.Forms.Button();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtEmailRepresentante = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtNomeRepresentante = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRazao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtTel = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnFConsultar = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(947, 377);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(153, 60);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.Cadastrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtSenha);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtTelRepresentante);
            this.panel1.Controls.Add(this.txtCNPJ);
            this.panel1.Controls.Add(this.btnEncontrar);
            this.panel1.Controls.Add(this.txtCEP);
            this.panel1.Controls.Add(this.txtEmailRepresentante);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.txtNomeRepresentante);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.txtUF);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.txtCidade);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txtBairro);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtComplemento);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtNumero);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtLogradouro);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtRazao);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtCPF);
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Controls.Add(this.txtTel);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(27, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1125, 464);
            this.panel1.TabIndex = 8;
            // 
            // txtTelRepresentante
            // 
            this.txtTelRepresentante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelRepresentante.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtTelRepresentante.Location = new System.Drawing.Point(650, 296);
            this.txtTelRepresentante.Mask = "(99)0000-0000";
            this.txtTelRepresentante.Name = "txtTelRepresentante";
            this.txtTelRepresentante.Size = new System.Drawing.Size(153, 37);
            this.txtTelRepresentante.TabIndex = 173;
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCNPJ.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtCNPJ.Location = new System.Drawing.Point(136, 109);
            this.txtCNPJ.Mask = "99.999.999/9999-99";
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(241, 37);
            this.txtCNPJ.TabIndex = 172;
            this.txtCNPJ.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtCNPJ_MaskInputRejected);
            // 
            // btnEncontrar
            // 
            this.btnEncontrar.BackColor = System.Drawing.Color.Transparent;
            this.btnEncontrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEncontrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEncontrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncontrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncontrar.Location = new System.Drawing.Point(269, 252);
            this.btnEncontrar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnEncontrar.Name = "btnEncontrar";
            this.btnEncontrar.Size = new System.Drawing.Size(85, 27);
            this.btnEncontrar.TabIndex = 171;
            this.btnEncontrar.Text = "Encontrar";
            this.btnEncontrar.UseVisualStyleBackColor = false;
            this.btnEncontrar.Click += new System.EventHandler(this.btnEncontrar_Click);
            // 
            // txtCEP
            // 
            this.txtCEP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCEP.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtCEP.Location = new System.Drawing.Point(136, 250);
            this.txtCEP.Mask = "00000-000";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(125, 37);
            this.txtCEP.TabIndex = 170;
            this.txtCEP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEmailRepresentante
            // 
            this.txtEmailRepresentante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmailRepresentante.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailRepresentante.Location = new System.Drawing.Point(650, 343);
            this.txtEmailRepresentante.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtEmailRepresentante.Name = "txtEmailRepresentante";
            this.txtEmailRepresentante.Size = new System.Drawing.Size(241, 40);
            this.txtEmailRepresentante.TabIndex = 48;
            this.txtEmailRepresentante.TextChanged += new System.EventHandler(this.txtEmailRepresentante_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label17.Location = new System.Drawing.Point(405, 345);
            this.label17.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(290, 30);
            this.label17.TabIndex = 47;
            this.label17.Text = "Email do representante";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label18.Location = new System.Drawing.Point(405, 298);
            this.label18.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(258, 30);
            this.label18.TabIndex = 45;
            this.label18.Text = "Tel do representante";
            // 
            // txtNomeRepresentante
            // 
            this.txtNomeRepresentante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeRepresentante.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeRepresentante.Location = new System.Drawing.Point(650, 199);
            this.txtNomeRepresentante.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtNomeRepresentante.Name = "txtNomeRepresentante";
            this.txtNomeRepresentante.Size = new System.Drawing.Size(241, 40);
            this.txtNomeRepresentante.TabIndex = 44;
            this.txtNomeRepresentante.TextChanged += new System.EventHandler(this.txtNomeRepresentante_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label19.Location = new System.Drawing.Point(405, 204);
            this.label19.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(299, 30);
            this.label19.TabIndex = 43;
            this.label19.Text = "Nome do representante";
            // 
            // txtUF
            // 
            this.txtUF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUF.Enabled = false;
            this.txtUF.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtUF.Location = new System.Drawing.Point(136, 346);
            this.txtUF.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(77, 37);
            this.txtUF.TabIndex = 42;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label20.Location = new System.Drawing.Point(14, 348);
            this.label20.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 30);
            this.label20.TabIndex = 41;
            this.label20.Text = "UF";
            // 
            // txtCidade
            // 
            this.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCidade.Enabled = false;
            this.txtCidade.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtCidade.Location = new System.Drawing.Point(650, 15);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(241, 37);
            this.txtCidade.TabIndex = 40;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label14.Location = new System.Drawing.Point(405, 17);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 30);
            this.label14.TabIndex = 39;
            this.label14.Text = "Cidade";
            // 
            // txtBairro
            // 
            this.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBairro.Enabled = false;
            this.txtBairro.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtBairro.Location = new System.Drawing.Point(650, 61);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(241, 37);
            this.txtBairro.TabIndex = 38;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label13.Location = new System.Drawing.Point(405, 63);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 30);
            this.label13.TabIndex = 37;
            this.label13.Text = "Bairro";
            // 
            // txtComplemento
            // 
            this.txtComplemento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComplemento.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtComplemento.Location = new System.Drawing.Point(650, 152);
            this.txtComplemento.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(241, 37);
            this.txtComplemento.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label12.Location = new System.Drawing.Point(405, 159);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(190, 30);
            this.label12.TabIndex = 35;
            this.label12.Text = "Complemento";
            // 
            // txtNumero
            // 
            this.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumero.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtNumero.Location = new System.Drawing.Point(650, 105);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(78, 37);
            this.txtNumero.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label11.Location = new System.Drawing.Point(405, 111);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 30);
            this.label11.TabIndex = 33;
            this.label11.Text = "Numero";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogradouro.Enabled = false;
            this.txtLogradouro.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtLogradouro.Location = new System.Drawing.Point(136, 297);
            this.txtLogradouro.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(241, 37);
            this.txtLogradouro.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label9.Location = new System.Drawing.Point(14, 300);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 30);
            this.label9.TabIndex = 29;
            this.label9.Text = "Logradouro";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label8.Location = new System.Drawing.Point(14, 253);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 30);
            this.label8.TabIndex = 27;
            this.label8.Text = "CEP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label6.Location = new System.Drawing.Point(14, 112);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 30);
            this.label6.TabIndex = 25;
            this.label6.Text = "CNPJ";
            // 
            // txtRazao
            // 
            this.txtRazao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRazao.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtRazao.Location = new System.Drawing.Point(136, 62);
            this.txtRazao.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtRazao.Name = "txtRazao";
            this.txtRazao.Size = new System.Drawing.Size(241, 37);
            this.txtRazao.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label3.Location = new System.Drawing.Point(14, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 30);
            this.label3.TabIndex = 23;
            this.label3.Text = "Razão";
            // 
            // txtCPF
            // 
            this.txtCPF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCPF.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPF.Location = new System.Drawing.Point(650, 247);
            this.txtCPF.Mask = "000.000.000-99";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(156, 40);
            this.txtCPF.TabIndex = 17;
            this.txtCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtCPF_MaskInputRejected);
            this.txtCPF.Leave += new System.EventHandler(this.txtCPF_Leave);
            // 
            // txtTel
            // 
            this.txtTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTel.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtTel.Location = new System.Drawing.Point(136, 203);
            this.txtTel.Mask = "(99)0000-0000";
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(153, 37);
            this.txtTel.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label4.Location = new System.Drawing.Point(405, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 30);
            this.label4.TabIndex = 15;
            this.label4.Text = "CPF do representante";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label5.Location = new System.Drawing.Point(14, 206);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 30);
            this.label5.TabIndex = 14;
            this.label5.Text = "Telefone";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtEmail.Location = new System.Drawing.Point(136, 156);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(241, 37);
            this.txtEmail.TabIndex = 11;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label2.Location = new System.Drawing.Point(14, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 30);
            this.label2.TabIndex = 10;
            this.label2.Text = "Email";
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtNome.Location = new System.Drawing.Point(136, 15);
            this.txtNome.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(241, 37);
            this.txtNome.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 26.25F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(52, 34);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(179, 55);
            this.label10.TabIndex = 113;
            this.label10.Text = "Cliente";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1173, 109);
            this.panel4.TabIndex = 174;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1055, 20);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 70);
            this.button1.TabIndex = 20;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(-4, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(256, 119);
            this.panel3.TabIndex = 15;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnFConsultar);
            this.panel5.Location = new System.Drawing.Point(256, 108);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1221, 516);
            this.panel5.TabIndex = 18;
            // 
            // btnFConsultar
            // 
            this.btnFConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFConsultar.Location = new System.Drawing.Point(579, 44);
            this.btnFConsultar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnFConsultar.Name = "btnFConsultar";
            this.btnFConsultar.Size = new System.Drawing.Size(273, 378);
            this.btnFConsultar.TabIndex = 15;
            this.btnFConsultar.Text = "Consultar";
            this.btnFConsultar.UseVisualStyleBackColor = true;
            // 
            // txtSenha
            // 
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenha.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(650, 391);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(241, 40);
            this.txtSenha.TabIndex = 175;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label7.Location = new System.Drawing.Point(405, 393);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 30);
            this.label7.TabIndex = 174;
            this.label7.Text = "Senha";
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(227)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1173, 622);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cliente";
            this.Load += new System.EventHandler(this.Cliente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.MaskedTextBox txtTel;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRazao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmailRepresentante;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtNomeRepresentante;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnEncontrar;
        private System.Windows.Forms.MaskedTextBox txtCEP;
        private System.Windows.Forms.MaskedTextBox txtTelRepresentante;
        private System.Windows.Forms.MaskedTextBox txtCNPJ;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnFConsultar;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label7;
    }
}


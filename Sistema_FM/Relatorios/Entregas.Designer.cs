namespace GUI
{
    partial class Entregas
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnFConsultar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEndereco = new System.Windows.Forms.Button();
            this.Endereco = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnEncontrar = new System.Windows.Forms.Button();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnID = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.dataGridConsultar = new System.Windows.Forms.DataGridView();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Endereco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsultar)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.panel4.Controls.Add(this.btnVoltar);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1564, 134);
            this.panel4.TabIndex = 20;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.White;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(1407, 25);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(128, 86);
            this.btnVoltar.TabIndex = 22;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(-1, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(341, 134);
            this.panel3.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnFConsultar);
            this.panel5.Location = new System.Drawing.Point(341, 133);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1628, 635);
            this.panel5.TabIndex = 18;
            // 
            // btnFConsultar
            // 
            this.btnFConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFConsultar.Location = new System.Drawing.Point(772, 54);
            this.btnFConsultar.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.btnFConsultar.Name = "btnFConsultar";
            this.btnFConsultar.Size = new System.Drawing.Size(364, 465);
            this.btnFConsultar.TabIndex = 15;
            this.btnFConsultar.Text = "Consultar";
            this.btnFConsultar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(77, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 55);
            this.label2.TabIndex = 3;
            this.label2.Text = "Entregas";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnEndereco);
            this.panel1.Controls.Add(this.Endereco);
            this.panel1.Controls.Add(this.btnMostrar);
            this.panel1.Controls.Add(this.btnID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.dataGridConsultar);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(36, 168);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1499, 571);
            this.panel1.TabIndex = 21;
            // 
            // btnEndereco
            // 
            this.btnEndereco.BackColor = System.Drawing.Color.Transparent;
            this.btnEndereco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEndereco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEndereco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndereco.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnEndereco.Location = new System.Drawing.Point(672, 18);
            this.btnEndereco.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnEndereco.Name = "btnEndereco";
            this.btnEndereco.Size = new System.Drawing.Size(211, 76);
            this.btnEndereco.TabIndex = 202;
            this.btnEndereco.Text = "Atualizar endereço";
            this.btnEndereco.UseVisualStyleBackColor = false;
            this.btnEndereco.Click += new System.EventHandler(this.btnEndereco_Click);
            // 
            // Endereco
            // 
            this.Endereco.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Endereco.Controls.Add(this.btnCancelar);
            this.Endereco.Controls.Add(this.txtNumero);
            this.Endereco.Controls.Add(this.btnCadastrar);
            this.Endereco.Controls.Add(this.btnEncontrar);
            this.Endereco.Controls.Add(this.txtUF);
            this.Endereco.Controls.Add(this.label15);
            this.Endereco.Controls.Add(this.txtCidade);
            this.Endereco.Controls.Add(this.label12);
            this.Endereco.Controls.Add(this.txtBairro);
            this.Endereco.Controls.Add(this.label11);
            this.Endereco.Controls.Add(this.txtComplemento);
            this.Endereco.Controls.Add(this.label10);
            this.Endereco.Controls.Add(this.label9);
            this.Endereco.Controls.Add(this.txtLogradouro);
            this.Endereco.Controls.Add(this.label6);
            this.Endereco.Controls.Add(this.txtCEP);
            this.Endereco.Controls.Add(this.label3);
            this.Endereco.Enabled = false;
            this.Endereco.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.Endereco.Location = new System.Drawing.Point(907, 18);
            this.Endereco.Name = "Endereco";
            this.Endereco.Size = new System.Drawing.Size(570, 528);
            this.Endereco.TabIndex = 201;
            this.Endereco.TabStop = false;
            this.Endereco.Text = "Novo Endereço";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnCancelar.Location = new System.Drawing.Point(302, 461);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(233, 52);
            this.btnCancelar.TabIndex = 193;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumero.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.txtNumero.Location = new System.Drawing.Point(228, 270);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(140, 38);
            this.txtNumero.TabIndex = 192;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnCadastrar.Location = new System.Drawing.Point(18, 461);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(233, 52);
            this.btnCadastrar.TabIndex = 191;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnEncontrar
            // 
            this.btnEncontrar.BackColor = System.Drawing.Color.Transparent;
            this.btnEncontrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEncontrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEncontrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncontrar.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.btnEncontrar.Location = new System.Drawing.Point(435, 39);
            this.btnEncontrar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnEncontrar.Name = "btnEncontrar";
            this.btnEncontrar.Size = new System.Drawing.Size(100, 40);
            this.btnEncontrar.TabIndex = 189;
            this.btnEncontrar.Text = "Encontrar";
            this.btnEncontrar.UseVisualStyleBackColor = false;
            this.btnEncontrar.Click += new System.EventHandler(this.btnEncontrar_Click);
            // 
            // txtUF
            // 
            this.txtUF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUF.Enabled = false;
            this.txtUF.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.txtUF.Location = new System.Drawing.Point(228, 176);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(140, 38);
            this.txtUF.TabIndex = 188;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label15.Location = new System.Drawing.Point(12, 178);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 31);
            this.label15.TabIndex = 187;
            this.label15.Text = "UF";
            // 
            // txtCidade
            // 
            this.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCidade.Enabled = false;
            this.txtCidade.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.txtCidade.Location = new System.Drawing.Point(228, 129);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(307, 38);
            this.txtCidade.TabIndex = 186;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label12.Location = new System.Drawing.Point(12, 131);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 31);
            this.label12.TabIndex = 185;
            this.label12.Text = "Cidade";
            // 
            // txtBairro
            // 
            this.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBairro.Enabled = false;
            this.txtBairro.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.txtBairro.Location = new System.Drawing.Point(228, 82);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(307, 38);
            this.txtBairro.TabIndex = 184;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label11.Location = new System.Drawing.Point(12, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 31);
            this.label11.TabIndex = 183;
            this.label11.Text = "Bairro";
            // 
            // txtComplemento
            // 
            this.txtComplemento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComplemento.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtComplemento.Location = new System.Drawing.Point(18, 353);
            this.txtComplemento.Multiline = true;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(517, 102);
            this.txtComplemento.TabIndex = 182;
            this.txtComplemento.Text = "\r\n\r\n\r\n\r\n";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label10.Location = new System.Drawing.Point(176, 319);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(192, 31);
            this.label10.TabIndex = 181;
            this.label10.Text = "Complemento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label9.Location = new System.Drawing.Point(12, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 31);
            this.label9.TabIndex = 180;
            this.label9.Text = "Número";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogradouro.Enabled = false;
            this.txtLogradouro.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.txtLogradouro.Location = new System.Drawing.Point(228, 223);
            this.txtLogradouro.Margin = new System.Windows.Forms.Padding(5);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(307, 38);
            this.txtLogradouro.TabIndex = 179;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label6.Location = new System.Drawing.Point(12, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 31);
            this.label6.TabIndex = 178;
            this.label6.Text = "Logradouro";
            // 
            // txtCEP
            // 
            this.txtCEP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCEP.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.txtCEP.Location = new System.Drawing.Point(228, 35);
            this.txtCEP.Mask = "00000-000";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(186, 38);
            this.txtCEP.TabIndex = 177;
            this.txtCEP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label3.Location = new System.Drawing.Point(12, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 31);
            this.label3.TabIndex = 176;
            this.label3.Text = "CEP";
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.Transparent;
            this.btnMostrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMostrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnMostrar.Location = new System.Drawing.Point(447, 18);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(211, 76);
            this.btnMostrar.TabIndex = 23;
            this.btnMostrar.Text = "Todas entregas";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnID
            // 
            this.btnID.BackColor = System.Drawing.Color.Transparent;
            this.btnID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnID.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnID.Location = new System.Drawing.Point(237, 18);
            this.btnID.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnID.Name = "btnID";
            this.btnID.Size = new System.Drawing.Size(196, 76);
            this.btnID.TabIndex = 22;
            this.btnID.Text = "Consultar ";
            this.btnID.UseVisualStyleBackColor = false;
            this.btnID.Click += new System.EventHandler(this.btnID_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(28, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 50);
            this.label1.TabIndex = 21;
            this.label1.Text = "Insira um ID\r\nde pedido:\r\n";
            // 
            // txtId
            // 
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtId.Location = new System.Drawing.Point(33, 62);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(183, 32);
            this.txtId.TabIndex = 20;
            // 
            // dataGridConsultar
            // 
            this.dataGridConsultar.AllowUserToAddRows = false;
            this.dataGridConsultar.AllowUserToDeleteRows = false;
            this.dataGridConsultar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridConsultar.Location = new System.Drawing.Point(33, 102);
            this.dataGridConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridConsultar.Name = "dataGridConsultar";
            this.dataGridConsultar.ReadOnly = true;
            this.dataGridConsultar.Size = new System.Drawing.Size(850, 444);
            this.dataGridConsultar.TabIndex = 7;
            // 
            // Entregas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(227)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1564, 766);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Entregas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entregas";
            this.Load += new System.EventHandler(this.Entregas_Load);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Endereco.ResumeLayout(false);
            this.Endereco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsultar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnFConsultar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridConsultar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnID;
        private System.Windows.Forms.Button btnEndereco;
        private System.Windows.Forms.GroupBox Endereco;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnEncontrar;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtCEP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnCancelar;
    }
}
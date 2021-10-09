namespace GUI
{
    partial class Estoque
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
            this.dataGridConsultar = new System.Windows.Forms.DataGridView();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnFConsultar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txtQuantidade = new System.Windows.Forms.NumericUpDown();
            this.btnInativar = new System.Windows.Forms.Button();
            this.pnlAtivar = new System.Windows.Forms.Panel();
            this.btnAtivar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.btnCadastros = new System.Windows.Forms.Button();
            this.btnVencido = new System.Windows.Forms.Button();
            this.btnInativo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValorUnico = new System.Windows.Forms.TextBox();
            this.txtProduto = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsultar)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade)).BeginInit();
            this.pnlAtivar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridConsultar
            // 
            this.dataGridConsultar.AllowUserToAddRows = false;
            this.dataGridConsultar.AllowUserToDeleteRows = false;
            this.dataGridConsultar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridConsultar.Location = new System.Drawing.Point(439, 259);
            this.dataGridConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridConsultar.Name = "dataGridConsultar";
            this.dataGridConsultar.ReadOnly = true;
            this.dataGridConsultar.Size = new System.Drawing.Size(1096, 483);
            this.dataGridConsultar.TabIndex = 0;
            this.dataGridConsultar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridConsultar_CellContentClick);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label11.Location = new System.Drawing.Point(13, 211);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(165, 30);
            this.label11.TabIndex = 157;
            this.label11.Text = "Quantidade ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label6.Location = new System.Drawing.Point(13, 161);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 30);
            this.label6.TabIndex = 155;
            this.label6.Text = "Produto";
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
            this.panel4.TabIndex = 173;
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
            this.btnVoltar.TabIndex = 20;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(-5, -1);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(341, 146);
            this.panel3.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 26.25F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(69, 42);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 55);
            this.label7.TabIndex = 113;
            this.label7.Text = "Estoque";
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
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(227)))), ((int)(((byte)(238)))));
            this.btnInserir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInserir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserir.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Location = new System.Drawing.Point(439, 152);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(153, 90);
            this.btnInserir.TabIndex = 174;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(227)))), ((int)(((byte)(238)))));
            this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.btnAlterar.Location = new System.Drawing.Point(600, 152);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(153, 90);
            this.btnAlterar.TabIndex = 177;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantidade.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtQuantidade.Location = new System.Drawing.Point(172, 204);
            this.txtQuantidade.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtQuantidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(247, 37);
            this.txtQuantidade.TabIndex = 185;
            this.txtQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnInativar
            // 
            this.btnInativar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInativar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInativar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInativar.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.btnInativar.Location = new System.Drawing.Point(761, 152);
            this.btnInativar.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnInativar.Name = "btnInativar";
            this.btnInativar.Size = new System.Drawing.Size(153, 90);
            this.btnInativar.TabIndex = 188;
            this.btnInativar.Text = "Inativar";
            this.btnInativar.UseVisualStyleBackColor = false;
            this.btnInativar.Click += new System.EventHandler(this.btnInativar_Click);
            // 
            // pnlAtivar
            // 
            this.pnlAtivar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(227)))), ((int)(((byte)(238)))));
            this.pnlAtivar.Controls.Add(this.btnAtivar);
            this.pnlAtivar.Controls.Add(this.panel2);
            this.pnlAtivar.Location = new System.Drawing.Point(761, 135);
            this.pnlAtivar.Margin = new System.Windows.Forms.Padding(4);
            this.pnlAtivar.Name = "pnlAtivar";
            this.pnlAtivar.Size = new System.Drawing.Size(153, 114);
            this.pnlAtivar.TabIndex = 189;
            // 
            // btnAtivar
            // 
            this.btnAtivar.BackColor = System.Drawing.Color.Transparent;
            this.btnAtivar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAtivar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtivar.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.btnAtivar.Location = new System.Drawing.Point(0, 17);
            this.btnAtivar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAtivar.Name = "btnAtivar";
            this.btnAtivar.Size = new System.Drawing.Size(153, 90);
            this.btnAtivar.TabIndex = 17;
            this.btnAtivar.Text = "Ativar";
            this.btnAtivar.UseVisualStyleBackColor = false;
            this.btnAtivar.Click += new System.EventHandler(this.btnAtivar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button5);
            this.panel2.Location = new System.Drawing.Point(289, 158);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1628, 635);
            this.panel2.TabIndex = 18;
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(772, 54);
            this.button5.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(364, 465);
            this.button5.TabIndex = 15;
            this.button5.Text = "Consultar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnCadastros
            // 
            this.btnCadastros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(227)))), ((int)(((byte)(238)))));
            this.btnCadastros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCadastros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastros.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastros.Location = new System.Drawing.Point(16, 317);
            this.btnCadastros.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnCadastros.Name = "btnCadastros";
            this.btnCadastros.Size = new System.Drawing.Size(402, 110);
            this.btnCadastros.TabIndex = 186;
            this.btnCadastros.Text = "Cadastros Ativos";
            this.btnCadastros.UseVisualStyleBackColor = false;
            this.btnCadastros.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVencido
            // 
            this.btnVencido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(227)))), ((int)(((byte)(238)))));
            this.btnVencido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVencido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVencido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVencido.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVencido.Location = new System.Drawing.Point(16, 631);
            this.btnVencido.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnVencido.Name = "btnVencido";
            this.btnVencido.Size = new System.Drawing.Size(403, 110);
            this.btnVencido.TabIndex = 176;
            this.btnVencido.Text = "Vencido";
            this.btnVencido.UseVisualStyleBackColor = false;
            this.btnVencido.Click += new System.EventHandler(this.btnVencido_Click);
            // 
            // btnInativo
            // 
            this.btnInativo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(227)))), ((int)(((byte)(238)))));
            this.btnInativo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInativo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInativo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInativo.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInativo.Location = new System.Drawing.Point(16, 474);
            this.btnInativo.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnInativo.Name = "btnInativo";
            this.btnInativo.Size = new System.Drawing.Size(403, 110);
            this.btnInativo.TabIndex = 187;
            this.btnInativo.Text = "Cadastros Inativos";
            this.btnInativo.UseVisualStyleBackColor = false;
            this.btnInativo.Click += new System.EventHandler(this.btnInativo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label2.Location = new System.Drawing.Point(14, 266);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 30);
            this.label2.TabIndex = 190;
            this.label2.Text = "Valor Unico";
            // 
            // txtValorUnico
            // 
            this.txtValorUnico.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtValorUnico.Location = new System.Drawing.Point(172, 259);
            this.txtValorUnico.Name = "txtValorUnico";
            this.txtValorUnico.Size = new System.Drawing.Size(247, 37);
            this.txtValorUnico.TabIndex = 191;
            // 
            // txtProduto
            // 
            this.txtProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtProduto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.txtProduto.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtProduto.FormattingEnabled = true;
            this.txtProduto.Location = new System.Drawing.Point(172, 153);
            this.txtProduto.Margin = new System.Windows.Forms.Padding(4);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(246, 38);
            this.txtProduto.TabIndex = 192;
            // 
            // Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(227)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1564, 766);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.txtValorUnico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridConsultar);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnInativo);
            this.Controls.Add(this.btnInativar);
            this.Controls.Add(this.btnVencido);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.btnCadastros);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pnlAtivar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Estoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque";
            this.Load += new System.EventHandler(this.Estoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsultar)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade)).EndInit();
            this.pnlAtivar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridConsultar;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnFConsultar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown txtQuantidade;
        private System.Windows.Forms.Button btnInativar;
        private System.Windows.Forms.Panel pnlAtivar;
        private System.Windows.Forms.Button btnAtivar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnInativo;
        private System.Windows.Forms.Button btnVencido;
        private System.Windows.Forms.Button btnCadastros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValorUnico;
        private System.Windows.Forms.ComboBox txtProduto;
    }
}
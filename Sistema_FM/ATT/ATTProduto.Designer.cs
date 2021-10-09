
namespace GUI
{
    partial class ATTProduto
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLiberar = new System.Windows.Forms.Button();
            this.Categoria = new System.Windows.Forms.GroupBox();
            this.txtNomeCategoria = new System.Windows.Forms.TextBox();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dataGridConsultar = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtSabor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnFConsultar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.Categoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsultar)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnLiberar);
            this.panel1.Controls.Add(this.Categoria);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtCategoria);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.txtDescricao);
            this.panel1.Controls.Add(this.txtValor);
            this.panel1.Controls.Add(this.txtSabor);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Location = new System.Drawing.Point(27, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1125, 464);
            this.panel1.TabIndex = 10;
            // 
            // btnLiberar
            // 
            this.btnLiberar.BackColor = System.Drawing.Color.Transparent;
            this.btnLiberar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLiberar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLiberar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLiberar.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.btnLiberar.Location = new System.Drawing.Point(366, 349);
            this.btnLiberar.Name = "btnLiberar";
            this.btnLiberar.Size = new System.Drawing.Size(129, 55);
            this.btnLiberar.TabIndex = 205;
            this.btnLiberar.Text = "Nova Categoria";
            this.btnLiberar.UseVisualStyleBackColor = false;
            this.btnLiberar.Click += new System.EventHandler(this.btnLiberar_Click);
            // 
            // Categoria
            // 
            this.Categoria.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Categoria.Controls.Add(this.txtNomeCategoria);
            this.Categoria.Controls.Add(this.btnCategoria);
            this.Categoria.Controls.Add(this.btnExcluir);
            this.Categoria.Controls.Add(this.dataGridConsultar);
            this.Categoria.Enabled = false;
            this.Categoria.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.Categoria.Location = new System.Drawing.Point(588, 26);
            this.Categoria.Name = "Categoria";
            this.Categoria.Size = new System.Drawing.Size(503, 422);
            this.Categoria.TabIndex = 204;
            this.Categoria.TabStop = false;
            this.Categoria.Text = "Nova Categoria";
            // 
            // txtNomeCategoria
            // 
            this.txtNomeCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeCategoria.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtNomeCategoria.Location = new System.Drawing.Point(13, 71);
            this.txtNomeCategoria.Multiline = true;
            this.txtNomeCategoria.Name = "txtNomeCategoria";
            this.txtNomeCategoria.Size = new System.Drawing.Size(478, 84);
            this.txtNomeCategoria.TabIndex = 39;
            // 
            // btnCategoria
            // 
            this.btnCategoria.BackColor = System.Drawing.Color.Transparent;
            this.btnCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoria.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnCategoria.Location = new System.Drawing.Point(13, 161);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(478, 31);
            this.btnCategoria.TabIndex = 40;
            this.btnCategoria.Text = "Criar nova categoria";
            this.btnCategoria.UseVisualStyleBackColor = false;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnExcluir.Location = new System.Drawing.Point(416, 217);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(77, 165);
            this.btnExcluir.TabIndex = 20;
            this.btnExcluir.Text = "Eliminar";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // dataGridConsultar
            // 
            this.dataGridConsultar.AllowUserToAddRows = false;
            this.dataGridConsultar.AllowUserToDeleteRows = false;
            this.dataGridConsultar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridConsultar.Location = new System.Drawing.Point(13, 215);
            this.dataGridConsultar.Name = "dataGridConsultar";
            this.dataGridConsultar.ReadOnly = true;
            this.dataGridConsultar.RowTemplate.Height = 24;
            this.dataGridConsultar.Size = new System.Drawing.Size(397, 167);
            this.dataGridConsultar.TabIndex = 0;
            // 
            // txtID
            // 
            this.txtID.AutoSize = true;
            this.txtID.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtID.Location = new System.Drawing.Point(56, 10);
            this.txtID.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(37, 30);
            this.txtID.TabIndex = 176;
            this.txtID.Text = "ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label8.Location = new System.Drawing.Point(22, 10);
            this.label8.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 30);
            this.label8.TabIndex = 175;
            this.label8.Text = "ID:";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtCategoria.FormattingEnabled = true;
            this.txtCategoria.Location = new System.Drawing.Point(145, 79);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(347, 38);
            this.txtCategoria.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label6.Location = new System.Drawing.Point(23, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 30);
            this.label6.TabIndex = 39;
            this.label6.Text = "Categoria";
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtNome.Location = new System.Drawing.Point(145, 42);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(347, 37);
            this.txtNome.TabIndex = 38;
            // 
            // txtDescricao
            // 
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricao.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtDescricao.Location = new System.Drawing.Point(145, 115);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(347, 165);
            this.txtDescricao.TabIndex = 37;
            // 
            // txtValor
            // 
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtValor.Location = new System.Drawing.Point(145, 323);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(137, 37);
            this.txtValor.TabIndex = 36;
            // 
            // txtSabor
            // 
            this.txtSabor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSabor.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtSabor.Location = new System.Drawing.Point(145, 286);
            this.txtSabor.Name = "txtSabor";
            this.txtSabor.Size = new System.Drawing.Size(255, 37);
            this.txtSabor.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label5.Location = new System.Drawing.Point(29, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 30);
            this.label5.TabIndex = 34;
            this.label5.Text = "Sabor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label4.Location = new System.Drawing.Point(29, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 30);
            this.label4.TabIndex = 33;
            this.label4.Text = "Custo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label3.Location = new System.Drawing.Point(23, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 30);
            this.label3.TabIndex = 32;
            this.label3.Text = "Descrição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label2.Location = new System.Drawing.Point(23, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 30);
            this.label2.TabIndex = 31;
            this.label2.Text = "Nome";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnSalvar.Location = new System.Drawing.Point(27, 411);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(465, 48);
            this.btnSalvar.TabIndex = 19;
            this.btnSalvar.Text = "Atualizar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click_1);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.panel4.Controls.Add(this.btnVoltar);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1173, 109);
            this.panel4.TabIndex = 174;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.White;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(1055, 20);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(5);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(96, 70);
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
            this.panel3.Location = new System.Drawing.Point(-4, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(256, 119);
            this.panel3.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(28, 48);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(213, 30);
            this.label7.TabIndex = 113;
            this.label7.Text = "Atualizar Produto";
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
            // ATTProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(227)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1173, 622);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ATTProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produto";
            this.Load += new System.EventHandler(this.Produto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Categoria.ResumeLayout(false);
            this.Categoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsultar)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalvar;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnFConsultar;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.TextBox txtDescricao;
        public System.Windows.Forms.TextBox txtValor;
        public System.Windows.Forms.TextBox txtSabor;
        public System.Windows.Forms.ComboBox txtCategoria;
        public System.Windows.Forms.Label txtID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnLiberar;
        private System.Windows.Forms.GroupBox Categoria;
        private System.Windows.Forms.TextBox txtNomeCategoria;
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView dataGridConsultar;

    }
}
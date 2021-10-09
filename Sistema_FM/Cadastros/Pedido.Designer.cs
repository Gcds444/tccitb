namespace GUI
{
    partial class Pedido
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnFConsultar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnIncompleto = new System.Windows.Forms.Button();
            this.btnPedido = new System.Windows.Forms.Button();
            this.lblAjuda = new System.Windows.Forms.Label();
            this.btnMostrarPedido = new System.Windows.Forms.Button();
            this.btnProduto = new System.Windows.Forms.Button();
            this.txtProduto = new System.Windows.Forms.ComboBox();
            this.lblID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPedido = new System.Windows.Forms.Label();
            this.lblSoma = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblProduto = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.SuspendLayout();
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
            this.panel4.TabIndex = 16;
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
            this.btnVoltar.TabIndex = 21;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.label1);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(77, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pedido";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgvPedido);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnIncompleto);
            this.panel1.Controls.Add(this.btnPedido);
            this.panel1.Controls.Add(this.lblAjuda);
            this.panel1.Controls.Add(this.btnMostrarPedido);
            this.panel1.Controls.Add(this.btnProduto);
            this.panel1.Controls.Add(this.txtProduto);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cmbCliente);
            this.panel1.Controls.Add(this.lblFuncionario);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblPedido);
            this.panel1.Controls.Add(this.lblSoma);
            this.panel1.Controls.Add(this.lblValor);
            this.panel1.Controls.Add(this.btnRetirar);
            this.panel1.Controls.Add(this.btnSelecionar);
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Controls.Add(this.lblProduto);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(36, 161);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1499, 571);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnCancelar.Location = new System.Drawing.Point(298, 113);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 66);
            this.btnCancelar.TabIndex = 167;
            this.btnCancelar.Text = "Cancelar Pedido";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnIncompleto
            // 
            this.btnIncompleto.BackColor = System.Drawing.Color.Transparent;
            this.btnIncompleto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnIncompleto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIncompleto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncompleto.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnIncompleto.Location = new System.Drawing.Point(159, 113);
            this.btnIncompleto.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnIncompleto.Name = "btnIncompleto";
            this.btnIncompleto.Size = new System.Drawing.Size(121, 66);
            this.btnIncompleto.TabIndex = 166;
            this.btnIncompleto.Text = "Selecionar Incompleto";
            this.btnIncompleto.UseVisualStyleBackColor = false;
            this.btnIncompleto.Click += new System.EventHandler(this.button1_Click_4);
            // 
            // btnPedido
            // 
            this.btnPedido.BackColor = System.Drawing.Color.Transparent;
            this.btnPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedido.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnPedido.Location = new System.Drawing.Point(20, 113);
            this.btnPedido.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(121, 66);
            this.btnPedido.TabIndex = 165;
            this.btnPedido.Text = "Gerar Pedido";
            this.btnPedido.UseVisualStyleBackColor = false;
            this.btnPedido.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // lblAjuda
            // 
            this.lblAjuda.AutoSize = true;
            this.lblAjuda.Font = new System.Drawing.Font("Century Gothic", 22F);
            this.lblAjuda.Location = new System.Drawing.Point(442, 2);
            this.lblAjuda.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblAjuda.Name = "lblAjuda";
            this.lblAjuda.Size = new System.Drawing.Size(461, 44);
            this.lblAjuda.TabIndex = 164;
            this.lblAjuda.Text = "Pedidos incompletos:      ";
            // 
            // btnMostrarPedido
            // 
            this.btnMostrarPedido.BackColor = System.Drawing.Color.Transparent;
            this.btnMostrarPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMostrarPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarPedido.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnMostrarPedido.Location = new System.Drawing.Point(222, 291);
            this.btnMostrarPedido.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnMostrarPedido.Name = "btnMostrarPedido";
            this.btnMostrarPedido.Size = new System.Drawing.Size(198, 75);
            this.btnMostrarPedido.TabIndex = 163;
            this.btnMostrarPedido.Text = "Mostrar Pedido";
            this.btnMostrarPedido.UseVisualStyleBackColor = false;
            this.btnMostrarPedido.Visible = false;
            this.btnMostrarPedido.Click += new System.EventHandler(this.btnMostrarPedido_Click);
            // 
            // btnProduto
            // 
            this.btnProduto.BackColor = System.Drawing.Color.Transparent;
            this.btnProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduto.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnProduto.Location = new System.Drawing.Point(21, 291);
            this.btnProduto.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(197, 75);
            this.btnProduto.TabIndex = 162;
            this.btnProduto.Text = "Mostrar produto";
            this.btnProduto.UseVisualStyleBackColor = false;
            this.btnProduto.Visible = false;
            this.btnProduto.Click += new System.EventHandler(this.btnProduto_Click);
            // 
            // txtProduto
            // 
            this.txtProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtProduto.Enabled = false;
            this.txtProduto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.txtProduto.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtProduto.FormattingEnabled = true;
            this.txtProduto.Location = new System.Drawing.Point(125, 243);
            this.txtProduto.Margin = new System.Windows.Forms.Padding(4);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(295, 38);
            this.txtProduto.TabIndex = 161;
            this.txtProduto.Visible = false;
            this.txtProduto.SelectedIndexChanged += new System.EventHandler(this.txtProduto_SelectedIndexChanged_1);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(194, 192);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 30);
            this.lblID.TabIndex = 160;
            this.lblID.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label7.Location = new System.Drawing.Point(15, 66);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 30);
            this.label7.TabIndex = 155;
            this.label7.Text = "Cliente";
            // 
            // cmbCliente
            // 
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(125, 64);
            this.cmbCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(295, 38);
            this.cmbCliente.TabIndex = 154;
            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Location = new System.Drawing.Point(177, 9);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(27, 30);
            this.lblFuncionario.TabIndex = 153;
            this.lblFuncionario.Text = "  ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 30);
            this.label6.TabIndex = 152;
            this.label6.Text = "Funcionario";
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.lblPedido.Location = new System.Drawing.Point(18, 192);
            this.lblPedido.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(165, 30);
            this.lblPedido.TabIndex = 150;
            this.lblPedido.Text = "Id do Pedido";
            this.lblPedido.Visible = false;
            // 
            // lblSoma
            // 
            this.lblSoma.AutoSize = true;
            this.lblSoma.Location = new System.Drawing.Point(16, 458);
            this.lblSoma.Name = "lblSoma";
            this.lblSoma.Size = new System.Drawing.Size(230, 30);
            this.lblSoma.TabIndex = 146;
            this.lblSoma.Text = "Soma dos valores:";
            this.lblSoma.Visible = false;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.lblValor.Location = new System.Drawing.Point(324, 458);
            this.lblValor.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(26, 30);
            this.lblValor.TabIndex = 139;
            this.lblValor.Text = "0";
            this.lblValor.Visible = false;
            // 
            // btnRetirar
            // 
            this.btnRetirar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(30)))), ((int)(((byte)(25)))));
            this.btnRetirar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRetirar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRetirar.Enabled = false;
            this.btnRetirar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetirar.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnRetirar.Location = new System.Drawing.Point(222, 377);
            this.btnRetirar.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(198, 75);
            this.btnRetirar.TabIndex = 136;
            this.btnRetirar.Text = "Retirar";
            this.btnRetirar.UseVisualStyleBackColor = false;
            this.btnRetirar.Visible = false;
            this.btnRetirar.Click += new System.EventHandler(this.btnRetirar_Click);
            // 
            // dgvPedido
            // 
            this.dgvPedido.AllowUserToAddRows = false;
            this.dgvPedido.AllowUserToDeleteRows = false;
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Location = new System.Drawing.Point(450, 41);
            this.dgvPedido.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.ReadOnly = true;
            this.dgvPedido.Size = new System.Drawing.Size(1013, 515);
            this.dgvPedido.TabIndex = 135;
            this.dgvPedido.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedido_CellContentClick);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(216)))), ((int)(((byte)(0)))));
            this.btnSelecionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelecionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelecionar.Enabled = false;
            this.btnSelecionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionar.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnSelecionar.Location = new System.Drawing.Point(21, 377);
            this.btnSelecionar.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(197, 75);
            this.btnSelecionar.TabIndex = 127;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = false;
            this.btnSelecionar.Visible = false;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.Enabled = false;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnCadastrar.Location = new System.Drawing.Point(21, 494);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(399, 62);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Finalizar Pedido";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Visible = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click_1);
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.lblProduto.Location = new System.Drawing.Point(18, 246);
            this.lblProduto.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(105, 30);
            this.lblProduto.TabIndex = 89;
            this.lblProduto.Text = "Produto";
            this.lblProduto.Visible = false;
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(227)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1564, 766);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Pedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU";
            this.Load += new System.EventHandler(this.Venda_Load_1);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnFConsultar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.Label lblSoma;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblProduto;
        public System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbCliente;
        public System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ComboBox txtProduto;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Label lblAjuda;
        private System.Windows.Forms.Button btnMostrarPedido;
        private System.Windows.Forms.Button btnProduto;
        private System.Windows.Forms.Button btnPedido;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnIncompleto;
    }
}
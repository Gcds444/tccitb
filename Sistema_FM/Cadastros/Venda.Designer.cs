namespace GUI
{
    partial class Venda
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
            this.btnInativar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.txtValorTotal = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtPedido = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtParcela = new System.Windows.Forms.NumericUpDown();
            this.btnPedidosAtivos = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.btnPedido = new System.Windows.Forms.Button();
            this.lblParcela = new System.Windows.Forms.Label();
            this.lblBandeira = new System.Windows.Forms.Label();
            this.txtBandeira = new System.Windows.Forms.ComboBox();
            this.lblPagamento = new System.Windows.Forms.Label();
            this.txtPagamento = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtParcela)).BeginInit();
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
            this.btnVoltar.TabIndex = 22;
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
            this.label1.Size = new System.Drawing.Size(171, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "Venda";
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
            this.panel1.Controls.Add(this.btnInativar);
            this.panel1.Controls.Add(this.btnFinalizar);
            this.panel1.Controls.Add(this.txtValorTotal);
            this.panel1.Controls.Add(this.lblValorTotal);
            this.panel1.Controls.Add(this.txtValor);
            this.panel1.Controls.Add(this.lblValor);
            this.panel1.Controls.Add(this.txtPedido);
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Controls.Add(this.txtParcela);
            this.panel1.Controls.Add(this.btnPedidosAtivos);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dgvPedido);
            this.panel1.Controls.Add(this.btnPedido);
            this.panel1.Controls.Add(this.lblParcela);
            this.panel1.Controls.Add(this.lblBandeira);
            this.panel1.Controls.Add(this.txtBandeira);
            this.panel1.Controls.Add(this.lblPagamento);
            this.panel1.Controls.Add(this.txtPagamento);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(36, 161);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1499, 571);
            this.panel1.TabIndex = 17;
            // 
            // btnInativar
            // 
            this.btnInativar.BackColor = System.Drawing.Color.Transparent;
            this.btnInativar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInativar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInativar.Enabled = false;
            this.btnInativar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInativar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnInativar.Location = new System.Drawing.Point(513, 439);
            this.btnInativar.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnInativar.Name = "btnInativar";
            this.btnInativar.Size = new System.Drawing.Size(137, 51);
            this.btnInativar.TabIndex = 178;
            this.btnInativar.Text = "Cancelar";
            this.btnInativar.UseVisualStyleBackColor = false;
            this.btnInativar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.Transparent;
            this.btnFinalizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFinalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizar.Enabled = false;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnFinalizar.Location = new System.Drawing.Point(367, 496);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(283, 51);
            this.btnFinalizar.TabIndex = 177;
            this.btnFinalizar.Text = "Finalizar Venda";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.AutoSize = true;
            this.txtValorTotal.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotal.Location = new System.Drawing.Point(237, 505);
            this.txtValorTotal.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(0, 37);
            this.txtValorTotal.TabIndex = 176;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Enabled = false;
            this.lblValorTotal.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(-8, 505);
            this.lblValorTotal.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(235, 37);
            this.lblValorTotal.TabIndex = 175;
            this.lblValorTotal.Text = "Valor Restante:";
            // 
            // txtValor
            // 
            this.txtValor.Enabled = false;
            this.txtValor.Location = new System.Drawing.Point(340, 159);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(310, 37);
            this.txtValor.TabIndex = 174;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Enabled = false;
            this.lblValor.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.lblValor.ForeColor = System.Drawing.Color.Black;
            this.lblValor.Location = new System.Drawing.Point(30, 159);
            this.lblValor.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(300, 30);
            this.lblValor.TabIndex = 173;
            this.lblValor.Text = "Valor desse pagamento";
            // 
            // txtPedido
            // 
            this.txtPedido.AutoSize = true;
            this.txtPedido.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtPedido.Location = new System.Drawing.Point(210, 18);
            this.txtPedido.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.Size = new System.Drawing.Size(0, 30);
            this.txtPedido.TabIndex = 171;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.Enabled = false;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnCadastrar.Location = new System.Drawing.Point(367, 439);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(143, 51);
            this.btnCadastrar.TabIndex = 170;
            this.btnCadastrar.Text = "Pagar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtParcela
            // 
            this.txtParcela.Enabled = false;
            this.txtParcela.Location = new System.Drawing.Point(340, 388);
            this.txtParcela.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtParcela.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.txtParcela.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtParcela.Name = "txtParcela";
            this.txtParcela.Size = new System.Drawing.Size(107, 37);
            this.txtParcela.TabIndex = 169;
            this.txtParcela.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnPedidosAtivos
            // 
            this.btnPedidosAtivos.BackColor = System.Drawing.Color.Transparent;
            this.btnPedidosAtivos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPedidosAtivos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPedidosAtivos.Enabled = false;
            this.btnPedidosAtivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedidosAtivos.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnPedidosAtivos.Location = new System.Drawing.Point(187, 69);
            this.btnPedidosAtivos.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnPedidosAtivos.Name = "btnPedidosAtivos";
            this.btnPedidosAtivos.Size = new System.Drawing.Size(143, 69);
            this.btnPedidosAtivos.TabIndex = 168;
            this.btnPedidosAtivos.Text = "Escolher outro pedido";
            this.btnPedidosAtivos.UseVisualStyleBackColor = false;
            this.btnPedidosAtivos.Click += new System.EventHandler(this.btnPedidosAtivos_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(667, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 30);
            this.label5.TabIndex = 167;
            this.label5.Text = "Pedidos ativos:";
            // 
            // dgvPedido
            // 
            this.dgvPedido.AllowUserToAddRows = false;
            this.dgvPedido.AllowUserToDeleteRows = false;
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Location = new System.Drawing.Point(672, 58);
            this.dgvPedido.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.ReadOnly = true;
            this.dgvPedido.Size = new System.Drawing.Size(767, 489);
            this.dgvPedido.TabIndex = 166;
            // 
            // btnPedido
            // 
            this.btnPedido.BackColor = System.Drawing.Color.Transparent;
            this.btnPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedido.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnPedido.Location = new System.Drawing.Point(30, 69);
            this.btnPedido.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(143, 69);
            this.btnPedido.TabIndex = 164;
            this.btnPedido.Text = "Selecionar Pedido";
            this.btnPedido.UseVisualStyleBackColor = false;
            this.btnPedido.Click += new System.EventHandler(this.btnPedido_Click);
            // 
            // lblParcela
            // 
            this.lblParcela.AutoSize = true;
            this.lblParcela.Enabled = false;
            this.lblParcela.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.lblParcela.Location = new System.Drawing.Point(30, 388);
            this.lblParcela.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblParcela.Name = "lblParcela";
            this.lblParcela.Size = new System.Drawing.Size(258, 30);
            this.lblParcela.TabIndex = 163;
            this.lblParcela.Text = "Número de parcelas";
            // 
            // lblBandeira
            // 
            this.lblBandeira.AutoSize = true;
            this.lblBandeira.Enabled = false;
            this.lblBandeira.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.lblBandeira.Location = new System.Drawing.Point(30, 311);
            this.lblBandeira.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblBandeira.Name = "lblBandeira";
            this.lblBandeira.Size = new System.Drawing.Size(244, 30);
            this.lblBandeira.TabIndex = 161;
            this.lblBandeira.Text = "Bandeira do cartão";
            // 
            // txtBandeira
            // 
            this.txtBandeira.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtBandeira.Enabled = false;
            this.txtBandeira.FormattingEnabled = true;
            this.txtBandeira.Items.AddRange(new object[] {
            "VISA",
            "MASTERCARD ",
            "ELO",
            "AMERICAN EXPRESS"});
            this.txtBandeira.Location = new System.Drawing.Point(340, 311);
            this.txtBandeira.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBandeira.Name = "txtBandeira";
            this.txtBandeira.Size = new System.Drawing.Size(310, 38);
            this.txtBandeira.TabIndex = 160;
            this.txtBandeira.SelectedIndexChanged += new System.EventHandler(this.txtBandeira_SelectedIndexChanged);
            // 
            // lblPagamento
            // 
            this.lblPagamento.AutoSize = true;
            this.lblPagamento.Enabled = false;
            this.lblPagamento.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.lblPagamento.ForeColor = System.Drawing.Color.Black;
            this.lblPagamento.Location = new System.Drawing.Point(30, 234);
            this.lblPagamento.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblPagamento.Name = "lblPagamento";
            this.lblPagamento.Size = new System.Drawing.Size(277, 30);
            this.lblPagamento.TabIndex = 159;
            this.lblPagamento.Text = "Forma de pagamento";
            // 
            // txtPagamento
            // 
            this.txtPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtPagamento.Enabled = false;
            this.txtPagamento.FormattingEnabled = true;
            this.txtPagamento.Items.AddRange(new object[] {
            "Cartão de Crédito",
            "Cartão de Débito ",
            "Dinheiro",
            "Boleto"});
            this.txtPagamento.Location = new System.Drawing.Point(340, 234);
            this.txtPagamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPagamento.Name = "txtPagamento";
            this.txtPagamento.Size = new System.Drawing.Size(310, 38);
            this.txtPagamento.TabIndex = 158;
            this.txtPagamento.SelectedIndexChanged += new System.EventHandler(this.txtPagamento_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label7.Location = new System.Drawing.Point(30, 17);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 30);
            this.label7.TabIndex = 157;
            this.label7.Text = "Inserir Pedido";
            // 
            // Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(227)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1564, 766);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Venda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU";
            this.Load += new System.EventHandler(this.Venda_Load);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtParcela)).EndInit();
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
        private System.Windows.Forms.Label lblBandeira;
        private System.Windows.Forms.ComboBox txtBandeira;
        private System.Windows.Forms.Label lblPagamento;
        private System.Windows.Forms.ComboBox txtPagamento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblParcela;
        private System.Windows.Forms.Button btnPedido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.Button btnPedidosAtivos;
        private System.Windows.Forms.NumericUpDown txtParcela;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label txtPedido;
        private System.Windows.Forms.Label txtValorTotal;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnInativar;
    }
}
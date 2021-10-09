namespace GUI
{
    partial class ConsultarPedidoFinal
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.dataGridConsultar = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnInativar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnFConsultar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pnlAtivar = new System.Windows.Forms.Panel();
            this.btnAtivar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsultar)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pnlAtivar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // txtId
            // 
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtId.Location = new System.Drawing.Point(99, 65);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(139, 32);
            this.txtId.TabIndex = 17;
            // 
            // dataGridConsultar
            // 
            this.dataGridConsultar.AllowUserToAddRows = false;
            this.dataGridConsultar.AllowUserToDeleteRows = false;
            this.dataGridConsultar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridConsultar.Location = new System.Drawing.Point(36, 161);
            this.dataGridConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridConsultar.Name = "dataGridConsultar";
            this.dataGridConsultar.ReadOnly = true;
            this.dataGridConsultar.Size = new System.Drawing.Size(1500, 571);
            this.dataGridConsultar.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.panel4.Controls.Add(this.btnInativar);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.btnAtualizar);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.pnlAtivar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1564, 134);
            this.panel4.TabIndex = 19;
            // 
            // btnInativar
            // 
            this.btnInativar.BackColor = System.Drawing.Color.White;
            this.btnInativar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInativar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInativar.FlatAppearance.BorderSize = 0;
            this.btnInativar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInativar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnInativar.Location = new System.Drawing.Point(983, 28);
            this.btnInativar.Margin = new System.Windows.Forms.Padding(4);
            this.btnInativar.Name = "btnInativar";
            this.btnInativar.Size = new System.Drawing.Size(201, 74);
            this.btnInativar.TabIndex = 16;
            this.btnInativar.Text = "Inativar";
            this.btnInativar.UseVisualStyleBackColor = false;
            this.btnInativar.Click += new System.EventHandler(this.btnInativar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.txtId);
            this.panel3.Location = new System.Drawing.Point(-5, -1);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(341, 146);
            this.panel3.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(93, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Insira um ID";
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.button1.Location = new System.Drawing.Point(355, 28);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 74);
            this.button1.TabIndex = 7;
            this.button1.Text = "Consultar por ID";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.White;
            this.btnAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.FlatAppearance.BorderSize = 0;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnAtualizar.Location = new System.Drawing.Point(1192, 28);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(201, 74);
            this.btnAtualizar.TabIndex = 14;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.button2.Location = new System.Drawing.Point(773, 28);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 74);
            this.button2.TabIndex = 13;
            this.button2.Text = "Mostrar Inativo";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.button3.Location = new System.Drawing.Point(564, 28);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(201, 74);
            this.button3.TabIndex = 9;
            this.button3.Text = "Mostrar Cadastros";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.button4.Location = new System.Drawing.Point(1428, 28);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 74);
            this.button4.TabIndex = 10;
            this.button4.Text = "Voltar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pnlAtivar
            // 
            this.pnlAtivar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.pnlAtivar.Controls.Add(this.btnAtivar);
            this.pnlAtivar.Controls.Add(this.panel2);
            this.pnlAtivar.Location = new System.Drawing.Point(976, -1);
            this.pnlAtivar.Margin = new System.Windows.Forms.Padding(4);
            this.pnlAtivar.Name = "pnlAtivar";
            this.pnlAtivar.Size = new System.Drawing.Size(428, 146);
            this.pnlAtivar.TabIndex = 17;
            // 
            // btnAtivar
            // 
            this.btnAtivar.BackColor = System.Drawing.Color.White;
            this.btnAtivar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAtivar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtivar.FlatAppearance.BorderSize = 0;
            this.btnAtivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtivar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnAtivar.Location = new System.Drawing.Point(5, 30);
            this.btnAtivar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAtivar.Name = "btnAtivar";
            this.btnAtivar.Size = new System.Drawing.Size(203, 74);
            this.btnAtivar.TabIndex = 17;
            this.btnAtivar.Text = "Ativar";
            this.btnAtivar.UseVisualStyleBackColor = false;
            this.btnAtivar.Click += new System.EventHandler(this.btnAtivar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button5);
            this.panel2.Location = new System.Drawing.Point(341, 133);
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
            // ConsultarPedidoFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(227)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1564, 766);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dataGridConsultar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConsultarPedidoFinal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultarPedidoFinal";
            this.Load += new System.EventHandler(this.ConsultarPedidoFinal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsultar)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.pnlAtivar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridView dataGridConsultar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnInativar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnFConsultar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel pnlAtivar;
        private System.Windows.Forms.Button btnAtivar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button5;
    }
}
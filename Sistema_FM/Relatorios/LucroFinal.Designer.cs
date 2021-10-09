namespace GUI
{
    partial class LucroFinal
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtData = new System.Windows.Forms.DateTimePicker();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.cht1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblVenda = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnFConsultar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblLucro = new System.Windows.Forms.Label();
            this.btnTabela = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cht1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.Controls.Add(this.btnTabela);
            this.panel1.Controls.Add(this.cht1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblLucro);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtData);
            this.panel1.Controls.Add(this.lblEstoque);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Controls.Add(this.lblVenda);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(36, 161);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1499, 571);
            this.panel1.TabIndex = 20;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtData
            // 
            this.txtData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtData.Location = new System.Drawing.Point(20, 25);
            this.txtData.MaxDate = new System.DateTime(2018, 11, 1, 0, 0, 0, 0);
            this.txtData.MinDate = new System.DateTime(2018, 9, 1, 0, 0, 0, 0);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(321, 37);
            this.txtData.TabIndex = 174;
            this.txtData.Value = new System.DateTime(2018, 10, 1, 0, 0, 0, 0);
            this.txtData.ValueChanged += new System.EventHandler(this.txtData_ValueChanged);
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstoque.ForeColor = System.Drawing.Color.Red;
            this.lblEstoque.Location = new System.Drawing.Point(71, 315);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(34, 37);
            this.lblEstoque.TabIndex = 5;
            this.lblEstoque.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(13, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 37);
            this.label4.TabIndex = 4;
            this.label4.Text = "R$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 74);
            this.label3.TabIndex = 3;
            this.label3.Text = "Soma das vendas \r\nno mês:\r\n";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnCadastrar.Location = new System.Drawing.Point(20, 71);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(321, 42);
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "Selecionar Lucro do mês";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // cht1
            // 
            chartArea4.Name = "ChartArea1";
            this.cht1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.cht1.Legends.Add(legend4);
            this.cht1.Location = new System.Drawing.Point(435, 25);
            this.cht1.Name = "cht1";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.cht1.Series.Add(series4);
            this.cht1.Size = new System.Drawing.Size(1033, 493);
            this.cht1.TabIndex = 1;
            // 
            // lblVenda
            // 
            this.lblVenda.AutoSize = true;
            this.lblVenda.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenda.ForeColor = System.Drawing.Color.Green;
            this.lblVenda.Location = new System.Drawing.Point(71, 204);
            this.lblVenda.Name = "lblVenda";
            this.lblVenda.Size = new System.Drawing.Size(34, 37);
            this.lblVenda.TabIndex = 0;
            this.lblVenda.Text = "0";
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
            this.panel4.TabIndex = 19;
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
            this.label2.Size = new System.Drawing.Size(141, 55);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lucro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(13, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 37);
            this.label1.TabIndex = 175;
            this.label1.Text = "R$";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(305, 74);
            this.label5.TabIndex = 176;
            this.label5.Text = "Soma do custo dos \r\nprodutos no mês:\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 25F);
            this.label6.Location = new System.Drawing.Point(11, 404);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 51);
            this.label6.TabIndex = 177;
            this.label6.Text = "Lucro:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 25F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(11, 455);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 51);
            this.label7.TabIndex = 179;
            this.label7.Text = "R$";
            // 
            // lblLucro
            // 
            this.lblLucro.AutoSize = true;
            this.lblLucro.Font = new System.Drawing.Font("Century Gothic", 25F);
            this.lblLucro.ForeColor = System.Drawing.Color.Black;
            this.lblLucro.Location = new System.Drawing.Point(87, 455);
            this.lblLucro.Name = "lblLucro";
            this.lblLucro.Size = new System.Drawing.Size(45, 51);
            this.lblLucro.TabIndex = 178;
            this.lblLucro.Text = "0";
            // 
            // btnTabela
            // 
            this.btnTabela.BackColor = System.Drawing.Color.Transparent;
            this.btnTabela.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTabela.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTabela.Enabled = false;
            this.btnTabela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabela.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnTabela.Location = new System.Drawing.Point(20, 512);
            this.btnTabela.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnTabela.Name = "btnTabela";
            this.btnTabela.Size = new System.Drawing.Size(321, 42);
            this.btnTabela.TabIndex = 180;
            this.btnTabela.Text = "Colocar valor na tabela";
            this.btnTabela.UseVisualStyleBackColor = false;
            this.btnTabela.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // LucroFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(227)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1564, 766);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LucroFinal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LucroFinal";
            this.Load += new System.EventHandler(this.LucroFinal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cht1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblVenda;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnFConsultar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart cht1;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DateTimePicker txtData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblLucro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTabela;
    }
}
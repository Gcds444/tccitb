namespace GUI
{
    partial class SelecionarProduto
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridConsultar = new System.Windows.Forms.DataGridView();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnID = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsultar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnMostrar);
            this.panel1.Controls.Add(this.btnID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.dataGridConsultar);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(873, 433);
            this.panel1.TabIndex = 0;
            // 
            // dataGridConsultar
            // 
            this.dataGridConsultar.AllowUserToAddRows = false;
            this.dataGridConsultar.AllowUserToDeleteRows = false;
            this.dataGridConsultar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridConsultar.Location = new System.Drawing.Point(19, 92);
            this.dataGridConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridConsultar.Name = "dataGridConsultar";
            this.dataGridConsultar.ReadOnly = true;
            this.dataGridConsultar.Size = new System.Drawing.Size(834, 325);
            this.dataGridConsultar.TabIndex = 8;
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.Transparent;
            this.btnMostrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMostrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.btnMostrar.Location = new System.Drawing.Point(400, 15);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(164, 67);
            this.btnMostrar.TabIndex = 27;
            this.btnMostrar.Text = "Selecionar Produto";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnID
            // 
            this.btnID.BackColor = System.Drawing.Color.Transparent;
            this.btnID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnID.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.btnID.Location = new System.Drawing.Point(222, 15);
            this.btnID.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnID.Name = "btnID";
            this.btnID.Size = new System.Drawing.Size(164, 67);
            this.btnID.TabIndex = 26;
            this.btnID.Text = "Consultar ";
            this.btnID.UseVisualStyleBackColor = false;
            this.btnID.Click += new System.EventHandler(this.btnID_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 31);
            this.label1.TabIndex = 25;
            this.label1.Text = "procurar um ID";
            // 
            // txtId
            // 
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtId.Location = new System.Drawing.Point(19, 50);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(183, 32);
            this.txtId.TabIndex = 24;
            // 
            // SelecionarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(227)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(897, 457);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelecionarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelecionarProduto";
            this.Load += new System.EventHandler(this.SelecionarProduto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsultar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridConsultar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
    }
}
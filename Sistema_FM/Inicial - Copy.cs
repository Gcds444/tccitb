using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GUI
{
    public partial class Inicial : Form
    {   
        
        public Inicial()
        {
            InitializeComponent();
            panelInicial.BringToFront();
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Form f = new Cliente();
            f.ShowDialog();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            Form f = new Produto();
            f.ShowDialog();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            Form f = new Funcionario();
            f.ShowDialog();
        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Inicial_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            panelConsulta.BringToFront();
        }    

        private void btnConsultarFuncionario_Click_1(object sender, EventArgs e)
        {
            Form f = new ConsultarFuncionario();
            f.ShowDialog();
        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            panelInicial.BringToFront();
        }

        private void btnConsultarCliente_Click(object sender, EventArgs e)
        {
            Form f = new ConsultarCliente();
            f.ShowDialog();
        }

        private void btnConsultarProduto_Click(object sender, EventArgs e)
        {
            Form f = new ConsultarPedido();
            f.ShowDialog();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("Deseja realmente sair ? ","", MessageBoxButtons.YesNo);
            if (dialogo == DialogResult.Yes)
            {

                Form f = new Login();
                this.Hide();
                f.ShowDialog();
            }
            else if(dialogo == DialogResult.No)
            {

            }


        }

        private void btnFornec_Click(object sender, EventArgs e)
        {
            Form f = new Fornecedor();
            f.ShowDialog();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            Form f = new Venda();
            f.ShowDialog();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            Form f = new Pedido();
            f.ShowDialog();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Form f = new ConsultarPedidoFinal();
            f.ShowDialog();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Form f = new ConsultarVenda();
            f.ShowDialog();
        }

        

      


        
    }
}

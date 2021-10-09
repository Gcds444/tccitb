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
    public partial class InicialFunc : Form
    {
        private BLL.BLLEstoqueSql estoque;

        public InicialFunc()
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
            estoque = new BLL.BLLEstoqueSql();
            estoque.VencimentoAutomatico();
            estoque.EsgotamentoAutomatico();

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
            Form f = new Estoque();
            f.ShowDialog();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            Form f = new Estoque();
            f.ShowDialog();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
           Pedido f = new Pedido();
           f.lblFuncionario.Text = lblFucionario.Text;
           f.Show();
         
           
           
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            panel1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
        }

        private void bunifuThinButton29_Click(object sender, EventArgs e)
        {
            panelInicial.BringToFront();
        }

        private void bunifuThinButton29_Click_1(object sender, EventArgs e)
        {
            panelInicial.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f = new Venda();
            f.ShowDialog();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

       

        private void btnGerarLucro_Click(object sender, EventArgs e)
        {
            Form F = new LucroFinal();
            F.ShowDialog();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            Form F = new Entregas();
            F.ShowDialog();
        }

        

      


        
    }
}

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
    public partial class Consulta : Form
    {
        private BLL.BLLCliente cliente;
        private BLL.BLLFuncionario funcionario;
        private BLL.BLLProduto produto;

        public Consulta()
        {
            InitializeComponent();
            panelVazio.BringToFront();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            panelCliente.BringToFront();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            panelFuncionario.BringToFront();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            panelProduto.BringToFront();
        }
       
        private void SelecionarClienteForm()
        {
            cliente = new BLL.BLLCliente();

            DataTable t = cliente.SelecionarClienteCPF(txtCPF.Text);

            string Empresa = t.Rows[0][1].ToString();
            string Nome = t.Rows[0][2].ToString();
            string Email = t.Rows[0][3].ToString();
            string Tel = t.Rows[0][4].ToString();
            string CPF = t.Rows[0][5].ToString();

            txtEmpresa.Text = Empresa;
            textBoxNome.Text = Nome;
            txtEmail.Text = Email;
            txtTel.Text = Tel;
            txtCPF.Text = CPF;

        }
        private void SelecionarProdutoForm()
        {
           produto = new BLL.BLLProduto();

           DataTable t = produto.SelecionarProdutoid(Convert.ToInt32(txtConsultarProduto.Text));

            string Nome = t.Rows[0][1].ToString();
            string Descricao = t.Rows[0][2].ToString();
            string Preco = t.Rows[0][3].ToString();
            string Quantidade = t.Rows[0][4].ToString();
            

            txtNomeProduto.Text = Nome;
            txtDescricaoProduto.Text = Descricao ;
            txtPrecoProduto.Text = Preco;
            txtQuantidadeProduto.Text = Quantidade;
            

        }
        private void SelecionarFuncionarioForm()
        {
            funcionario = new BLL.BLLFuncionario();

            DataTable t = funcionario.SelecionarFuncionarioCPF(txtCPFFuncionario.Text);

            string Nome = t.Rows[0][1].ToString();
            string DtNasc = t.Rows[0][2].ToString();
            string RG = t.Rows[0][3].ToString();
            string CPF = t.Rows[0][4].ToString();
            string Email = t.Rows[0][5].ToString();
            string Residencial = t.Rows[0][6].ToString();
            string Movel = t.Rows[0][7].ToString();
            string CEP = t.Rows[0][8].ToString();

            txtMovelFuncionario.Text = Movel;
            txtNomeFuncionario.Text = Nome;
            txtEmailFuncionario.Text = Email;
            txtResidencialFuncionario.Text = Residencial;
            txtCPFFuncionario.Text = CPF;
            txtDtNascFuncionario.Text = DtNasc;
            txtRGFuncionario.Text = RG;
            txtCEPFuncionario.Text = CEP;

        }

        private void btnConsultarCliente_Click(object sender, EventArgs e)
        {
            SelecionarClienteForm();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelVazio.BringToFront();

        }

        private void btnConsultarProduto_Click(object sender, EventArgs e)
        {
            SelecionarProdutoForm();
        }

        private void btnConsultarFuncionario_Click(object sender, EventArgs e)
        {
            SelecionarFuncionarioForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new Inicial();
            this.Hide();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
            panelVazio.BringToFront();

        
        }

        

       
     
    }
}

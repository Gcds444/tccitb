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
    public partial class ConsultarPedido : Form
    {
        private BLL.BLLProdutoSql produto;

        public ConsultarPedido()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            produto = new BLL.BLLProdutoSql();
            dataGridConsultar.DataSource = produto.BuscarProdutoID(txtId.Text);
        }
        private void SelecionarProdutoForm()
        {
            produto = new BLL.BLLProdutoSql();
            // dataGridConsultar.DataSource = produto.SelecionarProdutoid(Convert.ToInt32(txtId.Text));

       }
        

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form f = new Inicial();
            this.Hide();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            produto = new BLL.BLLProdutoSql();
             dataGridConsultar.DataSource = produto.BuscarProduto();
        }

        private void btnMostrarInativo_Click(object sender, EventArgs e)
        {
            produto = new BLL.BLLProdutoSql();
            dataGridConsultar.DataSource = produto.SelecionarProdutoInativo();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridConsultar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            produto = new BLL.BLLProdutoSql();
            DataTable m = produto.BuscarProdutoID(txtId.Text);

            if (m.Rows.Count == 0)
            {
                MessageBox.Show("ID não encontrado");
            }
            else if (m.Rows[0][6].ToString() == "Ativo")
                {
                    pnlAtivar.SendToBack();
                    dataGridConsultar.DataSource = m;
                }
                else
                {
                    pnlAtivar.BringToFront();
                    dataGridConsultar.DataSource = m;
                

            }
        }
    


        private void button3_Click(object sender, EventArgs e)
        {
            pnlAtivar.SendToBack();
            produto = new BLL.BLLProdutoSql();
            dataGridConsultar.DataSource = produto.BuscarProduto();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlAtivar.BringToFront();
            produto = new BLL.BLLProdutoSql();
            dataGridConsultar.DataSource = produto.SelecionarProdutoInativo();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form f = new Inicial();
            this.Hide();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (dataGridConsultar.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum produto selecionado");
            }
            else
            {
                ATTProduto aa = new ATTProduto();

                aa.txtID.Text = dataGridConsultar.Rows[dataGridConsultar.CurrentRow.Index].Cells[0].Value.ToString();
                aa.txtNome.Text = dataGridConsultar.Rows[dataGridConsultar.CurrentRow.Index].Cells[1].Value.ToString();
                aa.txtCategoria.Text = dataGridConsultar.Rows[dataGridConsultar.CurrentRow.Index].Cells[2].Value.ToString();
                aa.txtDescricao.Text = dataGridConsultar.Rows[dataGridConsultar.CurrentRow.Index].Cells[3].Value.ToString();
                aa.txtValor.Text = dataGridConsultar.Rows[dataGridConsultar.CurrentRow.Index].Cells[5].Value.ToString();
                aa.txtSabor.Text = dataGridConsultar.Rows[dataGridConsultar.CurrentRow.Index].Cells[4].Value.ToString();
                aa.Show();

                dataGridConsultar.DataSource = null;
            }
        }

        private void btnInativar_Click(object sender, EventArgs e)
        {
            if (dataGridConsultar.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum produto selecionado");
            }
            else
            {
                string m;
                m = dataGridConsultar.CurrentRow.Cells[0].Value.ToString();
                produto.Inativar(m);
                pnlAtivar.SendToBack();
                dataGridConsultar.DataSource = produto.BuscarProduto();
            }
        }

        private void btnAtivar_Click(object sender, EventArgs e)
        {
            if (dataGridConsultar.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum produto selecionado");
            }
            else
            {
                string m;
                m = dataGridConsultar.CurrentRow.Cells[0].Value.ToString();
                produto.Ativar(m);
                pnlAtivar.SendToBack();
                dataGridConsultar.DataSource = produto.BuscarProduto();
            }
        }

        private void ConsultarPedido_Load(object sender, EventArgs e)
        {
            produto = new BLL.BLLProdutoSql();
            dataGridConsultar.DataSource = produto.BuscarProduto();
        }
        
    }
}

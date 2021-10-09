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
    public partial class SelecionarProduto : Form
    {
        private BLL.BLLProdutoSql produto;
        public SelecionarProduto()
        {
            InitializeComponent();
        }

        private void SelecionarProduto_Load(object sender, EventArgs e)
        {
            produto = new BLL.BLLProdutoSql();
            dataGridConsultar.DataSource = produto.BuscarProduto();
        }

        private void btnID_Click(object sender, EventArgs e)
        {
            produto = new BLL.BLLProdutoSql();
            DataTable m = produto.BuscarProdutoID(txtId.Text);

            if (m.Rows.Count == 0)
            {
                MessageBox.Show("ID não encontrado");
            }
            else
            {
                dataGridConsultar.DataSource = m;
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            
            Estoque est = new Estoque();
            est.Enabled = false;
            //est.txtProduto.Text = dataGridConsultar.Rows[dataGridConsultar.CurrentRow.Index].Cells[1].Value.ToString();
           
            //est.Enabled = true;

          //  DataGridConsultar.Leave();
        }
    }
}

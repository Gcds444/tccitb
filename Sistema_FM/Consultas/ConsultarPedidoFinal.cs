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
    public partial class ConsultarPedidoFinal : Form
    {
        private BLL.BLLPedidoSql pedido;

        public ConsultarPedidoFinal()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form f = new Inicial();
            this.Hide();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {


        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {


        }

        private void btnMostrarInativo_Click(object sender, EventArgs e)
        {
            pedido = new BLL.BLLPedidoSql();
            dataGridConsultar.DataSource = pedido.SelecionarPedidoInativo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pedido = new BLL.BLLPedidoSql();
            DataTable m = pedido.BuscarPedidoID(txtId.Text);

            if (m.Rows.Count == 0)
            {
                MessageBox.Show("ID não encontrado");
            }
            else if (m.Rows[0][5].ToString() == "Ativo")
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
            pedido = new BLL.BLLPedidoSql();
            dataGridConsultar.DataSource = pedido.SelecionarPedidoInteiro();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlAtivar.BringToFront();
            pedido = new BLL.BLLPedidoSql();
            dataGridConsultar.DataSource = pedido.SelecionarPedidoInativo();
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
                MessageBox.Show("Nenhum pedido selecionado");
            }
            else
            {

                ATTPedido aa = new ATTPedido();

                aa.lblID.Text = dataGridConsultar.Rows[dataGridConsultar.CurrentRow.Index].Cells[0].Value.ToString();
                aa.cmbFuncionario.Text = dataGridConsultar.Rows[dataGridConsultar.CurrentRow.Index].Cells[1].Value.ToString();
                aa.cmbCliente.Text = dataGridConsultar.Rows[dataGridConsultar.CurrentRow.Index].Cells[2].Value.ToString();
                aa.lblValor.Text = dataGridConsultar.Rows[dataGridConsultar.CurrentRow.Index].Cells[3].Value.ToString();
                aa.Show();

                dataGridConsultar.DataSource = null;
            }
        }

        private void btnInativar_Click(object sender, EventArgs e)
        {
            if (dataGridConsultar.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum pedido selecionado");
            }
            else
            {
                string m;
                m = dataGridConsultar.CurrentRow.Cells[0].Value.ToString();
                pedido.Inativar(m);
                pnlAtivar.SendToBack();
                dataGridConsultar.DataSource = pedido.SelecionarPedidoInteiro();
            }
        }

        private void btnAtivar_Click(object sender, EventArgs e)
        {
            if (dataGridConsultar.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum pedido selecionado");
            }
            else
            {
                string m;
                m = dataGridConsultar.CurrentRow.Cells[0].Value.ToString();
                pedido.Ativar(m);
                pnlAtivar.SendToBack();
                dataGridConsultar.DataSource = pedido.SelecionarPedidoInteiro();
            }
        }

        private void ConsultarPedidoFinal_Load(object sender, EventArgs e)
        {
            pedido = new BLL.BLLPedidoSql();
            dataGridConsultar.DataSource = pedido.SelecionarPedidoInteiro();
        }
    }
}

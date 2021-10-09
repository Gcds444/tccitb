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
    public partial class Venda : Form
    {

        private BLL.BLLProdutoSql produto;
        private BLL.BLLEstoqueSql estoque;
        private BLL.BLLClienteSql cliente;
        private BLL.BLLPedidoSql pedido;

        private BLL.BLLItemSql item;
        private BLL.BLLVendaSql venda;

        public int preco;
        public int quantidade;

        public Venda()
        {
            InitializeComponent();

        }

        private void Venda_Load(object sender, EventArgs e)
        {
            pedido = new BLL.BLLPedidoSql();
            dgvPedido.DataSource = pedido.SelecionarPedidoInteiro();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            venda = new BLL.BLLVendaSql();
            txtPedido.Text = dgvPedido.CurrentRow.Cells[0].Value.ToString();
            txtValorTotal.Text = Convert.ToString(dgvPedido.CurrentRow.Cells[3].Value.ToString());
            item = new BLL.BLLItemSql();
            dgvPedido.DataSource = venda.SelecionarVendaId(txtPedido.Text);
            lblValor.Enabled = true;
            txtValor.Enabled = true;
            lblValorTotal.Enabled = true;
            label5.Text = "Informações do pedido:";
            btnPedidosAtivos.Enabled = true;
            lblPagamento.Enabled = true;
            txtPagamento.Enabled = true;
            label7.Enabled = false;
            txtPedido.Enabled = false;
            btnPedido.Enabled = false;
            txtValorTotal.Enabled = true;
            btnInativar.Enabled = true;
            btnCadastrar.Enabled = true;
            btnInativar.Enabled = true;
            double valor = Convert.ToDouble(txtValorTotal.Text);
            DataTable j = new DataTable();
            j = venda.ValorVenda(txtPedido.Text);
            string a = j.Rows[0][0].ToString();
            double valor2 = Convert.ToDouble(a);
            double valorTotal = valor - valor2;
            txtValorTotal.Text = Convert.ToString(valorTotal);
            dgvPedido.DataSource = venda.SelecionarVendaTotal(txtPedido.Text);
            
            if (txtValorTotal.Text == "0")
            {
                btnFinalizar.Enabled = true;
            }
            else
            {
                btnFinalizar.Enabled = false;

            }


        }

        private void btnPedidosAtivos_Click(object sender, EventArgs e)
        {
            pedido = new BLL.BLLPedidoSql();
            dgvPedido.DataSource = pedido.SelecionarPedidoInteiro();
            label5.Text = "Pedidos ativos:";

            lblBandeira.Enabled = false;
            txtBandeira.Enabled = false;
            lblParcela.Enabled = false;
            txtParcela.Enabled = false;
            btnPedidosAtivos.Enabled = false;
            lblPagamento.Enabled = false;
            txtPagamento.Enabled = false;
            label7.Enabled = true;
            txtPedido.Enabled = true;
            btnPedido.Enabled = true;
            txtPagamento.Text = "";
            txtBandeira.Text = "";
            txtParcela.Value = 1;
            txtValorTotal.Text = "";
        }

        private void txtBandeira_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtPagamento.Text == "Cartão de Crédito")
            {
                txtBandeira.Enabled = true;
                lblBandeira.Enabled = true;
                txtParcela.Enabled = true;
                lblParcela.Enabled = true;
            }
            else if (txtPagamento.Text == "Boleto" )
            {
                txtParcela.Value = 1;
                txtBandeira.SelectedItem = null;
                txtBandeira.Enabled = false;
                lblBandeira.Enabled = false;
                txtParcela.Enabled = false;
                lblParcela.Enabled = false;

            }
            else if (txtPagamento.Text == "Dinheiro")
            {
                txtParcela.Value = 1;
                txtBandeira.SelectedItem = null;
                txtBandeira.Enabled = false;
                lblBandeira.Enabled = false;
                txtParcela.Enabled = false;
                lblParcela.Enabled = false;

            }
            else if (txtPagamento.Text == "Cartão de Débito ")
            {
                txtParcela.Value = 1;
                txtBandeira.Text = "";
                txtBandeira.Enabled = true;
                lblBandeira.Enabled = true;
                txtParcela.Enabled = false;
                lblParcela.Enabled = false;
                
            }

        }
        public void cartaodebito()
        {
            if (txtPagamento.Text == "Cartão de Débito ")
            {
                txtBandeira.Enabled = true;
                lblBandeira.Enabled = true;
            }
            else
            {
                txtBandeira.Enabled = false;
                lblBandeira.Enabled = false;
                txtParcela.Enabled = false;
                lblParcela.Enabled = false;
                txtParcela.Value = 1;
                txtBandeira.Text = "";
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtValor.Text == "" || txtPagamento.Text == "")
            {
                MessageBox.Show("Insira os valores corretamente");
            }
            else
            {
                pedido = new BLL.BLLPedidoSql();
                venda = new BLL.BLLVendaSql();
                int idPedido = Convert.ToInt32(txtPedido.Text);
                int Parcela = Convert.ToInt32(txtParcela.Value);
                double Valor = Convert.ToDouble(txtValor.Text);
                double ValorTotal = Convert.ToDouble(txtValorTotal.Text);
                double final = ValorTotal - Valor;


                //pedido.Vender(idPedido);           
                if (Valor > ValorTotal)
                {
                    MessageBox.Show("Valor maior do que o necessario");
                }
                else
                {
                    txtValorTotal.Text = Convert.ToString(final);
                    venda.Inserir(idPedido, txtPagamento.Text, txtBandeira.Text, Parcela, Valor);
                    MessageBox.Show("Pagamento realizado");
                    dgvPedido.DataSource = venda.SelecionarVendaTotal(txtPedido.Text);
                    if (final == 0)
                    {
                        btnFinalizar.Enabled = true;
                    }
                    else
                    {
                        btnFinalizar.Enabled = false;

                    }
                }
                
            }
        }
        private void Finalizar(object sender, EventArgs e)
        {

        }

        /* dgvPedido.DataSource = pedido.SelecionarPedidoInteiro();
         label5.Text = "Pedidos ativos:";

         lblBandeira.Enabled = false;
         txtBandeira.Enabled = false;
         lblParcela.Enabled = false;
         txtParcela.Enabled = false;
         btnPedidosAtivos.Enabled = false;
         lblPagamento.Enabled = false;
         txtPagamento.Enabled = false;
         label7.Enabled = true;
         txtPedido.Enabled = true;
         btnPedido.Enabled = true;
         txtPagamento.Text = "";
         txtBandeira.Text = "";
         txtParcela.Value = 1;
         txtPedido.Text = "";
     }
         */
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form f = new Inicial();
            this.Hide();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("Deseja finalizar a venda? Ela não poderá ser alterada!", "", MessageBoxButtons.YesNo);
            if (dialogo == DialogResult.Yes)
            {
                pedido = new BLL.BLLPedidoSql();
                venda = new BLL.BLLVendaSql();
                int idPedido = Convert.ToInt32(txtPedido.Text);
                pedido.Vender(idPedido);
                dgvPedido.DataSource = pedido.SelecionarPedidoInteiro();
                label5.Text = "Pedidos ativos:";
                DataTable u = pedido.PegarUF(idPedido);
                string UF = u.Rows[0][0].ToString();

                pedido.InserirEntrega(idPedido);


                txtPagamento.Text = "";
                txtBandeira.Text = "";
                txtParcela.Value = 1;
                txtPedido.Text = "";
                
                lblBandeira.Enabled = false;
                txtBandeira.Enabled = false;
               
                lblParcela.Enabled = false;
                txtParcela.Enabled = false;
                btnPedidosAtivos.Enabled = false;
                lblPagamento.Enabled = false;
                txtPagamento.Enabled = false;
                label7.Enabled = true;
                txtPedido.Enabled = true;
                btnPedido.Enabled = true;
                
                txtValorTotal.Enabled = false;
                lblValorTotal.Enabled = false;
                btnFinalizar.Enabled = false;
                btnCadastrar.Enabled = false;
                lblValor.Enabled = false;
                txtValor.Enabled = false;
                txtValor.Text = "0";
                btnInativar.Enabled = false;

                

            }
            else if (dialogo == DialogResult.No)
            {

            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvPedido.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum produto inserido");
            }
            else
            {
                double valor1 = Convert.ToDouble(dgvPedido.CurrentRow.Cells[5].Value.ToString());
                double valor2 = Convert.ToDouble(txtValorTotal.Text);
                double valorfim = valor1 + valor2;
                txtValorTotal.Text = valorfim.ToString();
                venda = new BLL.BLLVendaSql();
                string m;
                m = dgvPedido.CurrentRow.Cells[0].Value.ToString();
                venda.Inativar(m);
                venda = new BLL.BLLVendaSql();
                 
                 dgvPedido.DataSource = venda.SelecionarVendaTotal(txtPedido.Text);

                 if (valorfim == 0)
                 {
                     btnFinalizar.Enabled = true;
                 }
                 else
                 {
                     btnFinalizar.Enabled = false;

                 }
            }
        }
    }
}


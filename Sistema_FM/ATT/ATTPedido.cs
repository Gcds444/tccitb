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
    public partial class ATTPedido : Form
    {
        private BLL.BLLFuncionarioSql funcionario;
        private BLL.BLLProdutoSql produto;
        private BLL.BLLEstoqueSql estoque;
        private BLL.BLLPedidoSql pedido;
        private BLL.BLLClienteSql cliente;
        private BLL.BLLItemSql item;

        public int preco;
        public int quantidade;

        public ATTPedido()
        {
            funcionario = new BLL.BLLFuncionarioSql();
            InitializeComponent();
            //SomarValores();
            //string r = nome;
            //DataTable p = new DataTable();
            //  p = funcionario.SelecionarIDlogin(r);
            // int id = Convert.ToInt32(p.Rows[0][1].ToString());
            //label1.Text = id.ToString(); 


        }

        private void txtFuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {


            /*if (txtFuncionario.SelectedIndex != -1)
            {
                funcionario = new BLL.BLLFuncionarioSql();
               Id_Cargo = Convert.ToInt32(funcionario.carregarComboFuncionario(txtFuncionario.SelectedItem.ToString()));
            }*/

        }


        private void Venda_Load(object sender, EventArgs e)
        {
            produto = new BLL.BLLProdutoSql();
            produto.carregarComboProduto(txtProduto);

        }

        private void txtProduto_SelectedIndexChanged(object sender, EventArgs e)
        { }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

        }

        private void txtCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConsultarCliente_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f = new Inicial();
            this.Hide();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {



        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblValor_Click(object sender, EventArgs e)
        {

        }

        private void Venda_Load_1(object sender, EventArgs e)
        {
            cliente = new BLL.BLLClienteSql();
            cliente.carregarComboCliente(cmbCliente);

            funcionario = new BLL.BLLFuncionarioSql();
            funcionario.carregarComboFuncionario(cmbFuncionario);

            produto = new BLL.BLLProdutoSql();
            produto.carregarComboProduto(txtProduto);

            item = new BLL.BLLItemSql();
            produto = new BLL.BLLProdutoSql();
            estoque = new BLL.BLLEstoqueSql();
            dgvPedido.DataSource = item.SelecionarItemPedido(lblID.Text);
            btnSelecionar.Enabled = false;
            btnRetirar.Enabled = true;
            lblAjuda.Text = "Pedido:";
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void txtQuantidade_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblPreco_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void cmbValidade_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtProduto_SelectedIndexChanged_1(object sender, EventArgs e)
        {


        }

        private void dgvPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            //if(lblID.Text == "")
            //{

            this.Hide();

        }
        /*            else
                    {
                        Incompleto();
                    }
           
                }
                public void Incompleto()
                {
                    DialogResult dialogo = MessageBox.Show("Pedido incompleto, Deseja realmente sair ? ", "", MessageBoxButtons.YesNo);
                    if (dialogo == DialogResult.Yes)
                    {
                        pedido = new BLL.BLLPedidoSql();
                        pedido.InativarIncompleto(lblID.Text);
                        this.Hide();
                    }
                    else if (dialogo == DialogResult.No)
                    {

                    }
                }*/

        private void lblFuncionario_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click_2(object sender, EventArgs e)
        {
             if (lblValor.Text == "0")
            {
                MessageBox.Show("Insira algum produto");
            }
            else
            {
                 cliente = new BLL.BLLClienteSql();
                DataTable p = new DataTable();
                p = cliente.SelecionarClienteID(cmbCliente.Text);
                funcionario = new BLL.BLLFuncionarioSql();
                DataTable t = new DataTable();
                t = funcionario.SelecionarIDFuncionario(cmbFuncionario.Text);
                string idFunc = Convert.ToString(t.Rows[0][0].ToString());
                string idCliente = Convert.ToString(p.Rows[0][0].ToString());
           
            pedido = new BLL.BLLPedidoSql();
            pedido.AtualizarPedido(lblID.Text, idFunc, idCliente, lblValor.Text);
            MessageBox.Show("Pedido Atualizado ");
        }
        }

        private void btnSelecionar_Click_1(object sender, EventArgs e)
        {
            if (dgvPedido.DataSource == null || dgvPedido.Rows.Count == 0)
            {
                MessageBox.Show("Selecione um produto");
            }
            else
            {
                pedido = new BLL.BLLPedidoSql();
                item = new BLL.BLLItemSql();
                estoque = new BLL.BLLEstoqueSql();
                int idEstoque = Convert.ToInt32(dgvPedido.CurrentRow.Cells[0].Value.ToString());
                int idProduto = Convert.ToInt32(dgvPedido.CurrentRow.Cells[1].Value.ToString());
                int idPedido = Convert.ToInt32(lblID.Text);
                item.InserirItemPedido(idEstoque, idPedido, idProduto);
                estoque.Pendente(idEstoque);
                dgvPedido.DataSource = item.SelecionarItemPedido(lblID.Text);
                DataTable t = new DataTable();
                t = item.SelecionarValorPedido(lblID.Text);
                lblValor.Text = t.Rows[0][0].ToString();
                btnSelecionar.Enabled = false;
                btnRetirar.Enabled = true;
                lblAjuda.Text = "Pedido:";
                pedido.AtualizarValor(idPedido, lblValor.Text);






            }
            /*private void txtValorTotal_TextChanged(Object sender, KeyEventArgs e)
            {
                Decimal Valor1 = Convert.ToDecimal(txtPreco.Text);
                Decimal Valor2 = Convert.ToDecimal(txtQuantidade.Text);
                Decimal Total;

                if (e.KeyCode == Keys.Enter)
                {

                    Total = Valor1 + Valor2;
                    txtValorTotal.Text = Total.ToString("C2");
                }
            }

            private void txtValorTotal_TextChanged(object sender, EventArgs e)
            {
                txtValorTotal.Text = (Convert.ToInt32(txtQuantidade.Text) * Convert.ToInt32(txtPreco)).ToString();
            }*/
        }

        private void btnRetirar_Click_1(object sender, EventArgs e)
        {
            if (dgvPedido.DataSource == null || dgvPedido.Rows.Count == 0)
            {
                MessageBox.Show("Selcione um pedido");
            }
            else
            {
                int idPedido = Convert.ToInt32(lblID.Text);
                estoque = new BLL.BLLEstoqueSql();
                string idEstoque = dgvPedido.CurrentRow.Cells[2].Value.ToString();
                string idItem = dgvPedido.CurrentRow.Cells[0].Value.ToString();
                estoque.Ativar(idEstoque);
                item.Inativar(idItem);

                DataTable t = new DataTable();
                t = item.SelecionarValorPedido(lblID.Text);
                lblValor.Text = t.Rows[0][0].ToString();
                dgvPedido.DataSource = item.SelecionarItemPedido(lblID.Text);
                pedido.AtualizarValor(idPedido, lblValor.Text);
            }
        }

        private void btnMostrarPedido_Click(object sender, EventArgs e)
        {
            item = new BLL.BLLItemSql();
            produto = new BLL.BLLProdutoSql();
            estoque = new BLL.BLLEstoqueSql();
            dgvPedido.DataSource = item.SelecionarItemPedido(lblID.Text);
            btnSelecionar.Enabled = false;
            btnRetirar.Enabled = true;
            lblAjuda.Text = "Pedido:";
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            if (txtProduto.Text == "")
            {
                MessageBox.Show("Selecionar Um Produto");
            }
            else
            {
                produto = new BLL.BLLProdutoSql();
                estoque = new BLL.BLLEstoqueSql();

                DataTable p = new DataTable();
                p = estoque.SelecionarIdProdutoEstoque(txtProduto.Text);
                int id = Convert.ToInt32(p.Rows[0][0].ToString());
                DataTable t = estoque.TabelaProduto(id);

                dgvPedido.DataSource = t;
                btnSelecionar.Enabled = true;
                btnRetirar.Enabled = false;
                lblAjuda.Text = "Produto:";
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("Deseja realmente cancelar? "
                +"(Para retornar o pedido será necessario acessar a tela de cadastro ", "", MessageBoxButtons.YesNo);
            if (dialogo == DialogResult.Yes)
            {
                btnCadastrar.Enabled = false;
                cmbFuncionario.Enabled = false;
                cmbFuncionario.Text = "";
                cmbCliente.Enabled = false;
                lblPedido.Enabled = false;
                lblProduto.Enabled = false;
                txtProduto.Enabled = false;
                btnSelecionar.Enabled = false;
                btnRetirar.Enabled = false;
                lblValor.Enabled = false;
                btnCadastrar.Enabled = false;
                lblSoma.Enabled = false;
                pedido = new BLL.BLLPedidoSql();
                pedido.InativarIncompleto(lblID.Text);
                dgvPedido.DataSource = pedido.SelecionarPedidoIncompleto();
                lblID.Text = "";
                //  lblPreco.Text = "0";
                lblValor.Text = "0";
                //  lblEstoque.Text = "0";
                //  cmbValidade.Text = "";
                //  cmbValidade.Text = "";
                txtProduto.Text = "";
                cmbCliente.Text = "";

                btnSelecionar.Enabled = false;
                btnRetirar.Enabled = false;
                txtProduto.Enabled = false;
                //  txtQuantidade.Enabled = false;

                cmbCliente.Enabled = true;
                //  cmbValidade.Enabled = false;
                btnCadastrar.Enabled = false;
                btnMostrarPedido.Enabled = false;
                btnProduto.Enabled = false;
                lblAjuda.Text = "Pedidos incompletos:";
                btnCancelar.Enabled = false;
            }
            else if (dialogo == DialogResult.No)
            {

            }
        }

        private void txtProduto_SelectedIndexChanged_2(object sender, EventArgs e)
        {

            produto = new BLL.BLLProdutoSql();
            estoque = new BLL.BLLEstoqueSql();

            DataTable p = new DataTable();
            p = estoque.SelecionarIdProdutoEstoque(txtProduto.Text);
            int id = Convert.ToInt32(p.Rows[0][0].ToString());
            DataTable t = estoque.TabelaProduto(id);

            dgvPedido.DataSource = t;

            btnSelecionar.Enabled = true;
            btnRetirar.Enabled = false;
            lblAjuda.Text = "Produto:";

           
        }
    }
}
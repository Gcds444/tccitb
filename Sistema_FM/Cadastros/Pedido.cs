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
    public partial class Pedido : Form
    {   
        
        private BLL.BLLProdutoSql produto;
        private BLL.BLLEstoqueSql estoque;
        private BLL.BLLFuncionarioSql funcionario;
        private BLL.BLLPedidoSql pedido;
        private BLL.BLLClienteSql cliente;
        private BLL.BLLItemSql item;
       
        public int preco;
        public int quantidade;

        public Pedido()
        {   funcionario = new BLL.BLLFuncionarioSql();
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
           // Decimal Valor1 = Convert.ToDecimal(lblPreco.Text);
          //  Decimal Valor2 = Convert.ToDecimal(txtQuantidade.Text);
          //  Decimal Total;

           // Total = Valor1 * Valor2;
           // dgvPedido.Rows.Add(txtProduto.Text, txtQuantidade.Text, Total);
           // SomarValores();
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
                /*  item = new BLL.BLLItemSql();
                  DataTable t = new DataTable();
                  t = item.SelecionarItemPedido(lblID.Text);
                  if (t.Rows[0][4].ToString() == "Inativo")
                  {
                      MessageBox.Show("Pedido já inativo");
                  }
                  else
                  {
                      Retirar(); 
                  if (dgvPedido.Rows.Count == 0)
                  {
                      MessageBox.Show("Nenhum produto inserido");
                  }
                  else if (dgvPedido.CurrentRow.Cells[4].ToString() == "Inativo")
                  {
                      MessageBox.Show("Item já inativo");
                  }
                  else if (cmbValidade.Text == "")
                  {
                      MessageBox.Show("Selecione a validade");
                  }
                  else
                  {
                      estoque = new BLL.BLLEstoqueSql();
                      DataTable t = new DataTable();
                      string nomeProduto = dgvPedido.CurrentRow.Cells[2].ToString();
                      t = estoque.SelecionarIdProdutoEstoque(nomeProduto);
                     // int idproduto = Convert.ToInt32(t.Rows[0][0].ToString());

                      string idEstoque = dgvPedido.CurrentRow.Cells[6].Value.ToString();
                
                
                      DataTable h = new DataTable();
                      h = estoque.SelecionarQuantidade(idEstoque);

                      item = new BLL.BLLItemSql();
                      string m;
                      m = dgvPedido.CurrentRow.Cells[0].Value.ToString();
                      item.Inativar(m);
                      item = new BLL.BLLItemSql();
                      dgvPedido.DataSource = item.SelecionarItemPedido(lblID.Text);
                      item = new BLL.BLLItemSql();
                      DataTable k = new DataTable();
                      k = item.Valor(lblID.Text);
                      lblValor.Text = k.Rows[0][0].ToString();

                      decimal quantidadeEstoque = Convert.ToDecimal(h.Rows[0][0].ToString());
                      decimal Valor1 = Convert.ToDecimal(lblPreco.Text);
                      decimal Valor2 = Convert.ToInt32(txtQuantidade.Value);
                      //decimal Valor3 = Convert.ToInt32(lblEstoque.Text);
                

                      decimal EstoqueRetirar  = Convert.ToDecimal(dgvPedido.CurrentRow.Cells[5].Value.ToString());

                      decimal SelecionarRetirar = EstoqueRetirar + quantidadeEstoque;
                

                      item = new BLL.BLLItemSql();
                      dgvPedido.DataSource = item.SelecionarItemPedido(lblID.Text);
                      string validade = cmbValidade.Text;
                      estoque.AtualizarQuantidade(SelecionarRetirar, idEstoque);


                      DataTable r = new DataTable();
                      r = estoque.MostrarQuantidadeVencimento(cmbValidade.Text);
                     // int Quantidade = Convert.ToInt32(r.Rows[0][0].ToString());
                     // lblEstoque.Text = Quantidade.ToString();
                     // txtQuantidade.Maximum = Quantidade;

                  }*/
            }

        }
        public void Retirar()
        {
            if (dgvPedido.Rows.Count == 0)
            {
            MessageBox.Show("Nenhum produto inserido");
            }
            else
            {
                item = new BLL.BLLItemSql();
                string m;
                m = dgvPedido.CurrentRow.Cells[0].Value.ToString();
                item.Inativar(m);
                item = new BLL.BLLItemSql();
                dgvPedido.DataSource = item.SelecionarItemPedido(lblID.Text);
          //      decimal t;
          //      t = Convert.ToDecimal(dgvPedido.CurrentRow.Cells[3].Value.ToString());
          //      decimal o = Convert.ToDecimal(lblValor.Text);
          //      decimal Final;
          //      Final = t - o;
          //      lblValor.Text = Final.ToString();
}
            

       }

        public void SomarValores()
        {
           /* item = new BLL.BLLItemSql();
            DataTable t = new DataTable();
            t = item.SelecionarItemPedido(lblID.Text);
            if (t.Rows[0][4].ToString() == "Ativo")*/
            {
                double total = 0;
                foreach (DataGridViewRow row in dgvPedido.Rows)
                {
                    total += Convert.ToDouble(row.Cells["TOTAL"].Value);
                }
                lblValor.Text = Convert.ToString(total);
            }
           
        }
        public void SubtrairValores()
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
            pedido = new BLL.BLLPedidoSql();
            dgvPedido.DataSource = pedido.SelecionarPedidoIncompleto();

            cliente = new BLL.BLLClienteSql();
            cliente.carregarComboCliente(cmbCliente);

            produto = new BLL.BLLProdutoSql();
            produto.carregarComboProduto(txtProduto);
          //  produto.BuscarProdutoVencimento(cmbValidade);
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (dgvPedido.DataSource == null || dgvPedido.Rows.Count == 0)
            {
                MessageBox.Show("Selecione um produto");
            }
            else
            {
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
                pedido.AtualizarValor(idPedido,lblValor.Text);




                /*
                    t = estoque.SelecionarIdProdutoEstoque(txtProduto.Text);
                    int idproduto = Convert.ToInt32(t.Rows[0][0].ToString());
                   decimal Valor1 = Convert.ToDecimal(lblPreco.Text);
                    decimal Valor2 = Convert.ToInt32(txtQuantidade.Value);
                    decimal Valor3 = Convert.ToInt32(lblEstoque.Text);
                   decimal EstoqueSelecionar = Valor3 - Valor2;
                    decimal EstoqueRetirar = Valor3 + Valor2;

                    int SelecionarFim = Convert.ToInt32(EstoqueSelecionar);
                    decimal Total;
                    string TotalFinal;

                    Total = Valor1 * Valor2;
                    TotalFinal = Total.ToString();


                    string datavenc = cmbValidade.Text;

                    estoque = new BLL.BLLEstoqueSql();
                    DataTable h = new DataTable();
                    h = estoque.SelecionarIDEstoque(datavenc, idproduto);
                    string idEstoque = h.Rows[0][0].ToString();


                    int idpedido = Convert.ToInt32(lblID.Text);
                    item = new BLL.BLLItemSql();

                    item.InserirItemPedido(idpedido, idproduto, TotalFinal, txtQuantidade.Value, idEstoque);
                    item = new BLL.BLLItemSql();
                    dgvPedido.DataSource = item.SelecionarItemPedido(lblID.Text);
                   string validade = cmbValidade.Text;
                    estoque.AtualizarQuantidade(SelecionarFim, idEstoque);

                    DataTable r = new DataTable();
                    r = estoque.MostrarQuantidadeVencimento(cmbValidade.Text);
                    int Quantidade = Convert.ToInt32(r.Rows[0][0].ToString());
                    lblEstoque.Text = Quantidade.ToString();
                    txtQuantidade.Maximum = Quantidade;
                           Total = Valor1 * Valor2;
                           dgvPedido.Rows.Add(txtProduto.Text, txtQuantidade.Text, Total);
                    item = new BLL.BLLItemSql();
                    DataTable k = new DataTable();
                    k = item.Valor(lblID.Text);
                    lblValor.Text = k.Rows[0][0].ToString();
            
                */
            }
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void txtQuantidade_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
           // decimal valor = Convert.ToDecimal(lblValor.Text);
            if (lblValor.Text == "0")
            {
                MessageBox.Show("Insira algum produto");
            }
            else
            {
                pedido = new BLL.BLLPedidoSql();
                pedido.ValorTotal(lblValor.Text, lblID.Text);
                MessageBox.Show("pedido finalizado");
                pedido.Ativar(lblID.Text);
                btnProduto.Visible = false;
                btnMostrarPedido.Visible = false;
                btnCancelar.Enabled = false;
                
                lblPedido.Visible = false;
                lblProduto.Visible = false;
                txtProduto.Visible = false;
                btnSelecionar.Visible = false;
                btnRetirar.Visible = false;
                lblValor.Visible = false;
                btnCadastrar.Visible = false;
                lblSoma.Visible = false;
                btnIncompleto.Enabled = true;
                btnSelecionar.Visible = false;
                btnRetirar.Visible = false;
                lblValor.Visible = false;
                btnCadastrar.Visible = false;
                lblSoma.Visible = false;
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
                pedido = new BLL.BLLPedidoSql();
                
              //  txtQuantidade.Enabled = false;
                btnPedido.Enabled = true;
                cmbCliente.Enabled = true;
              //  cmbValidade.Enabled = false;
                btnCadastrar.Enabled = false;
                dgvPedido.DataSource = pedido.SelecionarPedidoIncompleto();
                


            }
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
            produto = new BLL.BLLProdutoSql();
           // produto.BuscarProdutoVencimento(cmbValidade,txtProduto.Text);
            
        }

        private void cmbValidade_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* estoque = new BLL.BLLEstoqueSql();
            DataTable r = new DataTable();
            r = estoque.MostrarQuantidadeVencimento(cmbValidade.Text);
            int Quantidade = Convert.ToInt32(r.Rows[0][0].ToString());
            lblEstoque.Text = Quantidade.ToString();
            txtQuantidade.Maximum = Quantidade;
            */
        }

        private void txtProduto_SelectedIndexChanged_1(object sender, EventArgs e)
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

        private void dgvPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if(lblID.Text == "")
            {
                
                this.Hide();
               
            }
           
            else
            {
                Incompleto();
            }
           
        }
        public void Incompleto()
        {
            DialogResult dialogo = MessageBox.Show("Pedido incompleto, Deseja realmente sair? ", "", MessageBoxButtons.YesNo);
            if (dialogo == DialogResult.Yes)
            {
                pedido = new BLL.BLLPedidoSql();
                pedido.InativarIncompleto(lblID.Text);
                this.Hide();
            }
            else if (dialogo == DialogResult.No)
            {

            }
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

        private void button1_Click_3(object sender, EventArgs e)
        {
            if (cmbCliente.Text == "")
            {
                MessageBox.Show("Selecione um cliente");
            }
            else
            {
                btnCancelar.Enabled = true;
                btnIncompleto.Enabled = false;
                pedido = new BLL.BLLPedidoSql();
                cliente = new BLL.BLLClienteSql();
                DataTable p = new DataTable();
                p = cliente.SelecionarClienteID(cmbCliente.Text);
                funcionario = new BLL.BLLFuncionarioSql();
                DataTable t = new DataTable();
                t = funcionario.SelecionarIDFuncionario(lblFuncionario.Text);
                int id = Convert.ToInt32(t.Rows[0][0].ToString());
                int Cliente = Convert.ToInt32(p.Rows[0][0].ToString());
                int Valor = Convert.ToInt32(lblValor.Text);
                pedido.Inserir(id, Cliente, Valor);
                MessageBox.Show("Pedido gerado");
                btnSelecionar.Enabled = true;
                btnRetirar.Enabled = true;
                btnSelecionar.Visible = true;
                btnRetirar.Visible = true;
                txtProduto.Enabled = true;
                // txtQuantidade.Enabled = true;
                btnPedido.Enabled = false;
                cmbCliente.Enabled = false;
                //  cmbValidade.Enabled = true;
                btnCadastrar.Enabled = true;
                DataTable m = pedido.MostrarUltimoID();
                string IDPedido = m.Rows[0][0].ToString();
                lblID.Text = IDPedido;

                item = new BLL.BLLItemSql();
                DataTable k = new DataTable();
                
                // k = item.Valor(lblID.Text);
                // lblValor.Text = k.Rows[0][0].ToString();
                btnMostrarPedido.Visible = true;
                btnProduto.Visible = true;
                dgvPedido.DataSource = null;
                lblPedido.Visible = true;
                lblSoma.Visible = true;
                lblProduto.Visible = true;
                lblID.Visible = true;
                txtProduto.Visible = true;
                lblValor.Visible = true;
                btnCadastrar.Visible = true;

            }
        }
            private void button1_Click_4(object sender, EventArgs e)
        {
            if (dgvPedido.DataSource == null || dgvPedido.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum pedido incompleto");
            }
            else
            {


                btnCancelar.Enabled = true;
                btnIncompleto.Enabled = false;
                btnCadastrar.Visible = true;
                btnPedido.Visible = true;
                lblPedido.Visible = true;
                lblSoma.Visible = true;
                lblProduto.Visible = true;
                lblID.Visible = true;
                txtProduto.Visible = true;
                lblValor.Visible = true;
                btnSelecionar.Visible = true;
                btnRetirar.Visible = true;
                btnSelecionar.Enabled = true;
                btnRetirar.Enabled = true;
                txtProduto.Enabled = true;
                // txtQuantidade.Enabled = true;
                btnPedido.Enabled = false;
                cmbCliente.Enabled = false;
                //  cmbValidade.Enabled = true;
                btnCadastrar.Enabled = true;
                string IDPedido = dgvPedido.CurrentRow.Cells[0].Value.ToString();
                lblID.Text = IDPedido;
                string valor = dgvPedido.CurrentRow.Cells[3].Value.ToString();
                lblValor.Text = valor;
                btnMostrarPedido.Visible = true;
                btnProduto.Visible = true;
                btnCadastrar.Visible = true;
                dgvPedido.DataSource = null;
                btnCancelar.Enabled = true;
            }
             
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("Deseja realmente cancelar? ", "", MessageBoxButtons.YesNo);
            if (dialogo == DialogResult.Yes)
            {
                lblPedido.Visible = false;
                lblProduto.Visible = false;
                txtProduto.Visible = false;
                btnSelecionar.Visible = false;
                btnRetirar.Visible = false;
                lblValor.Visible = false;
                btnCadastrar.Visible = false;
                lblSoma.Visible = false;
                btnIncompleto.Enabled = true;
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
                btnPedido.Enabled = true;
                cmbCliente.Enabled = true;
                //  cmbValidade.Enabled = false;
                btnCadastrar.Enabled = false;
                btnMostrarPedido.Visible = false;
                btnProduto.Visible = false;
                lblAjuda.Text = "Pedidos incompletos:";
                btnCancelar.Enabled = false;
            }
            else if (dialogo == DialogResult.No)
            {

            }
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
}

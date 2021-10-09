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
    public partial class Estoque : Form
    {
        private BLL.BLLProdutoSql produto;
        private BLL.BLLEstoqueSql estoque;

        public Estoque()
        {
            InitializeComponent();
        }

        private void Estoque_Load(object sender, EventArgs e)
        {
            produto = new BLL.BLLProdutoSql();
           produto.carregarComboProduto(txtProduto);
            estoque = new BLL.BLLEstoqueSql();
            dataGridConsultar.DataSource = estoque.SelecionarEstoque();
        

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            String produto = txtProduto.Text;
            if (produto == "")
            {
                MessageBox.Show("Insira um produto");
            }
            else if (txtValorUnico.Text == "")
            {
                MessageBox.Show("Insira um valor");
            }
            else
            {
                estoque = new BLL.BLLEstoqueSql();
                DataTable t = new DataTable();
                t = estoque.SelecionarIdProdutoEstoque(txtProduto.Text);
                double CustoUnico2 = Convert.ToDouble(t.Rows[0][5].ToString());
                int id = Convert.ToInt32(t.Rows[0][0].ToString());
                double custo = Convert.ToDouble(txtValorUnico.Text);
                double quantidade = Convert.ToDouble(txtQuantidade.Value);
                double custototal = custo * quantidade;

                double CUSTO2 = quantidade * CustoUnico2;
                estoque.Inserir(id, txtQuantidade.Text, custototal,CUSTO2);
                MessageBox.Show("Dados inseridos");
                estoque = new BLL.BLLEstoqueSql();
                dataGridConsultar.DataSource = estoque.SelecionarEstoque();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form f = new Inicial();
            this.Hide();
        }

        private void txtProduto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridConsultar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dataGridConsultar.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum produto selecionado");
            }
            else
            {
                string unidade = dataGridConsultar.CurrentRow.Cells[4].Value.ToString();
                Double unidadeFim = Convert.ToDouble(unidade);
                string valor = dataGridConsultar.CurrentRow.Cells[5].Value.ToString();
                Double valorFim = Convert.ToDouble(valor);

                Double valorUnico = valorFim / unidadeFim; 

                ATTEstoque aa = new ATTEstoque();
                
                aa.txtID.Text = dataGridConsultar.Rows[dataGridConsultar.CurrentRow.Index].Cells[0].Value.ToString();
                aa.txtProduto.Text = dataGridConsultar.Rows[dataGridConsultar.CurrentRow.Index].Cells[1].Value.ToString();
                // aa.txtProduto.DropDownStyle = ComboBoxStyle.DropDownList;
                aa.txtQuantidade.Text = dataGridConsultar.Rows[dataGridConsultar.CurrentRow.Index].Cells[4].Value.ToString();
                aa.txtValorUnico.Text = Convert.ToString(valorUnico);
                aa.ShowDialog();

                dataGridConsultar.DataSource = null;
            }
        }
        

        private void btnVencido_Click(object sender, EventArgs e)
        {
            btnAlterar.Enabled = false;
            btnAtivar.Enabled = false;
            btnInativar.Enabled = false;
            estoque = new BLL.BLLEstoqueSql();
            dataGridConsultar.DataSource = estoque.SelecionarVencimento();
        }

        private void btnEsgotado_Click(object sender, EventArgs e)
        {
            btnAlterar.Enabled = false;
            btnAtivar.Enabled = false;
            btnInativar.Enabled = false;
            estoque = new BLL.BLLEstoqueSql();
            dataGridConsultar.DataSource = estoque.SelecionarEsgotado();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlAtivar.SendToBack();
            btnAlterar.Enabled = true;
            btnAtivar.Enabled = true;
            btnInativar.Enabled = true;
            estoque = new BLL.BLLEstoqueSql();
            dataGridConsultar.DataSource = estoque.SelecionarEstoque();
        }

        private void btnInativo_Click(object sender, EventArgs e)
        {
            pnlAtivar.BringToFront();
            btnAlterar.Enabled = false;
            btnAtivar.Enabled = true;
            btnInativar.Enabled = true;
            estoque = new BLL.BLLEstoqueSql();
            dataGridConsultar.DataSource = estoque.SelecionarInativo();
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
                estoque = new BLL.BLLEstoqueSql();
                estoque.Inativar(m);
                dataGridConsultar.DataSource = estoque.SelecionarEstoque();
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
                estoque = new BLL.BLLEstoqueSql();
                estoque.Ativar(m);
                dataGridConsultar.DataSource = estoque.SelecionarInativo();
            }
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SelecionarProduto f = new SelecionarProduto();

            f.ShowDialog();

            
            
        }
    }
}

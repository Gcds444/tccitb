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
    public partial class ATTProduto : Form
    {
        private BLL.BLLProdutoSql produto;

        public ATTProduto()
        {
            InitializeComponent();
        }

     
        private void btnSalvar_Click(object sender, EventArgs e)
        {
          
        }

        private void Produto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bancoDataSet1.Produto' table. You can move, or remove it, as needed.
            produto = new BLL.BLLProdutoSql();
            produto.carregarComboCategoria(txtCategoria);
            // TODO: This line of code loads data into the 'bancoDataSet.Produto' table. You can move, or remove it, as needed.

        }



        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new Inicial();
            this.Hide();
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            String nome = txtNome.Text;
            String categoria = txtCategoria.Text;
            String Valor = txtValor.Text;
            String Descricao = txtDescricao.Text;
            String Sabor = txtSabor.Text;

            if (nome == "" || categoria == "" || Valor == "" || Descricao == "" || Sabor == "")
            {
                MessageBox.Show("Preencha todos campos");
            }
            else
            {
                MessageBox.Show("Dados Atualizados");
                produto = new BLL.BLLProdutoSql();
                double valor = Convert.ToDouble(txtValor.Text);
                produto.AtualizarProdutoID(txtID.Text, txtNome.Text, txtCategoria.Text, txtDescricao.Text, txtSabor.Text, valor);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            DataTable m = new DataTable();
            m = produto.ConsultarCategoriaNome(txtNomeCategoria.Text.ToUpper());
            if (m.Rows.Count > 0)
            {
                MessageBox.Show("Categoria já criada");
            }
            else
            {
                produto = new BLL.BLLProdutoSql();
                produto.InserirCategoria(txtNomeCategoria.Text.ToUpper());
                txtNomeCategoria.Text = "";
                dataGridConsultar.DataSource = produto.ConsultarCategoria();
            }
        }

        private void btnLiberar_Click(object sender, EventArgs e)
        {
            if (btnLiberar.Text == "Retornar ao Cadastro")
            {
                produto = new BLL.BLLProdutoSql();
                Categoria.Enabled = false;
                txtCategoria.Enabled = true;
                
                txtDescricao.Enabled = true;
                txtNome.Enabled = true;
                txtSabor.Enabled = true;
                txtValor.Enabled = true;
                
                label2.Enabled = true;
                label3.Enabled = true;
                label4.Enabled = true;
                label5.Enabled = true;
                label6.Enabled = true;
                btnSalvar.Enabled = true;
                btnLiberar.Text = "Nova Categoria";
                dataGridConsultar.DataSource = null;
                txtCategoria.Items.Clear();
                txtCategoria.Text = "";
                produto.carregarComboCategoria(txtCategoria);


            }
            else
            {
                produto = new BLL.BLLProdutoSql();
                Categoria.Enabled = true;
                txtCategoria.Enabled = false;
                txtDescricao.Enabled = false;
                txtNome.Enabled = false;
                txtSabor.Enabled = false;
                txtValor.Enabled = false;
               
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                btnSalvar.Enabled = false;
                btnLiberar.Text = "Retornar ao Cadastro";
                dataGridConsultar.DataSource = produto.ConsultarCategoria();

            }

            /*   private void btnConsultarProduto_Click(object sender, EventArgs e)
              {
                  produto = new BLL.BLLProdutoSql();
                  DataTable t = produto.BuscarProdutoID( txtID.Text);

                  string Nome = t.Rows[0][1].ToString();
                  string Categoria = t.Rows[0][2].ToString();
                  string Descricao = t.Rows[0][3].ToString();            
                  string Sabor = t.Rows[0][4].ToString();        
                  string Valor = t.Rows[0][5].ToString();

                  txtNome.Text = Nome;
                  txtCategoria.Text = Categoria;
                  txtDescricao.Text = Descricao;
                  txtValor.Text = Valor;
                  txtSabor.Text = Sabor;
           
              }

              private void btnAtualizar_Click(object sender, EventArgs e)
               {
                   produto.AtualizarProdutoID(txtID.Text, txtNome.Text, txtCategoria.Text, txtDescricao.Text, txtSabor.Text, txtValor.Text);
                   MessageBox.Show("Dados atualizados");
               }

               private void btnExcluir_Click(object sender, EventArgs e)
               {
                   produto.Inativar(txtID.Text);
                   MessageBox.Show("Dados Inativados");
               }

               private void SelecionarProdutoFormid()
               {
                   produto = new BLL.BLLProduto();

                   DataTable t = produto.SelecionarProdutoid(Convert.ToInt32(txtID.Text));

                   string Nome = t.Rows[0][1].ToString();
                   string Descricao = t.Rows[0][2].ToString();
                   string Preco = t.Rows[0][3].ToString();
                   string Quantidade = t.Rows[0][4].ToString();

                   txtNome.Text = Nome;
                   txtDescricao.Text = Descricao;
                   txtPreco.Text = Preco;
                   txtSabor.Text = Quantidade;

               }


               private void btnConsultarProduto_Click(object sender, EventArgs e)
               {
                   SelecionarProdutoFormid();
               }


               private void Atualizar()
               {
           
                   produto.AtualizarProdutoid(txtID.Text ,txtNome.Text, txtDescricao.Text, txtSabor.Text, txtPreco.Text);
                   MessageBox.Show("Dados atualizados");
               }

               private void btnAtualizar_Click(object sender, EventArgs e)
               {
                   Atualizar();
               }

               private void Excluir()
               {         
                   DialogResult dialogo = MessageBox.Show("Deseja realmente excluir este produto ? ", "", MessageBoxButtons.YesNo);
                   if (dialogo == DialogResult.Yes)
                   {
                       produto.ExcluirProdutoid(Convert.ToInt32(txtID.Text));
                       MessageBox.Show("Dados Excluídos");

                   }
                   else if (dialogo == DialogResult.No)
                   {

                   }
               }

               private void btnExcluir_Click(object sender, EventArgs e)
               {
                   Excluir();
               }

               private void ValidarCampos()
               {

                   String nome = txtNome.Text;
                   String descricao = txtDescricao.Text; 
                   String preco = txtPreco.Text;
                   String quantidade = txtSabor.Text;
           

                   if (nome != "" && nome != "" && descricao != "" && preco != "" && quantidade != "")
                   {

                       MessageBox.Show("Dados Inseridos");
                   }
                   else
                   {
                       MessageBox.Show("Dados Incompletos");
                   }
               }

               private void panel1_Paint(object sender, PaintEventArgs e)
               {

               }*/



        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridConsultar.Rows.Count == 0)
            {
                MessageBox.Show("Nenhuma categoria selecionado");
            }
            else
            {
                string m;
                m = dataGridConsultar.CurrentRow.Cells[0].Value.ToString();
                produto.InativarCategoria(m);
                dataGridConsultar.DataSource = produto.ConsultarCategoria();

            }
        }
    }
}


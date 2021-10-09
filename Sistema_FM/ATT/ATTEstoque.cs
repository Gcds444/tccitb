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
    public partial class ATTEstoque : Form
    {
        private BLL.BLLProdutoSql produto;
        private BLL.BLLEstoqueSql estoque;

        public ATTEstoque()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ATTEstoque_Load(object sender, EventArgs e)
        {
            produto = new BLL.BLLProdutoSql();
            produto.carregarComboProduto(txtProduto);
            //txtProduto.DropDownStyle = ComboBoxStyle.DropDownList;
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            double custo = Convert.ToDouble(txtValorUnico.Text);
            double quantidade = Convert.ToDouble(txtQuantidade.Value);
            double custototal = custo * quantidade;

            estoque = new BLL.BLLEstoqueSql();
            DataTable t = new DataTable();
            t = estoque.SelecionarIdProdutoEstoque(txtProduto.Text);
            int idproduto = Convert.ToInt32(t.Rows[0][0].ToString());
            int quantidadeCad = Convert.ToInt32(txtQuantidade.Value);
            estoque.Atualizar(idproduto, quantidadeCad, custototal, txtID.Text);
            MessageBox.Show("Dados Atualizados");
        }
    }
}

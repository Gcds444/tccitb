using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using System.Text.RegularExpressions;

namespace GUI
{
    public partial class Entregas : Form
    {
        private BLL.BLLPedidoSql pedido;
        private BLL.BLLDetalheSql detalhe;

        public Entregas()
        {
            InitializeComponent();
        }

        private void Entregas_Load(object sender, EventArgs e)
        {
            pedido = new BLL.BLLPedidoSql();
            dataGridConsultar.DataSource = pedido.BuscarEntrega();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            pedido = new BLL.BLLPedidoSql();
            dataGridConsultar.DataSource = pedido.BuscarEntrega();

        }

        private void btnID_Click(object sender, EventArgs e)
        {
            pedido = new BLL.BLLPedidoSql();
            DataTable m = pedido.BuscarEntregaID(txtId.Text);

            if (m.Rows.Count == 0)
            {
                MessageBox.Show("ID não encontrado");
            }
            else
            {
                dataGridConsultar.DataSource = m;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form f = new Inicial();
            this.Hide();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (btnCadastrar.Text == "Cadastrar")
            {
                txtCEP.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                detalhe = new BLL.BLLDetalheSql();
                string idPedido = dataGridConsultar.CurrentRow.Cells[1].Value.ToString();
                detalhe.InserirDetalhe(idPedido, txtCEP.Text, txtBairro.Text, txtCidade.Text, txtUF.Text, txtNumero.Text, txtComplemento.Text, txtLogradouro.Text);
                txtCEP.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                Endereco.Enabled = false;
                dataGridConsultar.Enabled = true;
                btnEndereco.Enabled = true;
                MessageBox.Show("Local cadastrado");
                txtCEP.Text = "";
                txtBairro.Text = "";
                txtCidade.Text = "";
                txtComplemento.Text = "";
                txtLogradouro.Text = "";
                txtNumero.Text = "";
                txtUF.Text = "";
            
            }
            else
            {
                txtCEP.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                detalhe = new BLL.BLLDetalheSql();
                string idPedido = dataGridConsultar.CurrentRow.Cells[1].Value.ToString();
                detalhe.Atualizar(idPedido, txtCEP.Text, txtBairro.Text, txtCidade.Text, txtUF.Text, txtNumero.Text, txtComplemento.Text, txtLogradouro.Text);
                txtCEP.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                Endereco.Enabled = false;
                dataGridConsultar.Enabled = true;
                btnEndereco.Enabled = true;
                MessageBox.Show("Local atualizado");
                txtCEP.Text = "";
                txtBairro.Text = "";
                txtCidade.Text = "";
                txtComplemento.Text = "";
                txtLogradouro.Text = "";
                txtNumero.Text = "";
                txtUF.Text = "";
            }
           
        }

        private void btnEndereco_Click(object sender, EventArgs e)
        {
            
            detalhe = new BLL.BLLDetalheSql();
            string idpedido = dataGridConsultar.CurrentRow.Cells[1].Value.ToString();
            DataTable x = detalhe.BuscarEndereco(idpedido);
            if (x.Rows.Count > 0)
            {
                txtCEP.Text = x.Rows[0][2].ToString();
                BuscarCEP();
                txtNumero.Text = x.Rows[0][6].ToString();
                txtComplemento.Text = x.Rows[0][7].ToString();
                btnCadastrar.Text = "Atualizar";
            }
            else
            {
                btnCadastrar.Text = "Cadastrar";
            }
            Endereco.Enabled = true;
            btnEndereco.Enabled = false;
            dataGridConsultar.Enabled = false;
            txtId.Enabled = false;
            btnID.Enabled = false;
            btnMostrar.Enabled = false;

        }

        private void btnEncontrar_Click(object sender, EventArgs e)
        {
            BuscarCEP();
        }
        public void BuscarCEP()
        {
            BLL.BLLCepSql adm = new BLL.BLLCepSql();
            OracleDataReader dr;
            Regex regex = new Regex(@"[^\d]");




            dr = adm.RetornarCEPPorFavor(Convert.ToString(regex.Replace(txtCEP.Text, "")));
            dr.Read();

            if (dr.HasRows)
            {
                string Logradouro = dr["DESCRICAO"].ToString();
                string Cidade = dr["CIDADE"].ToString();
                string Bairro = dr["BAIRRO"].ToString();
                string UF = dr["UF"].ToString();

                txtLogradouro.Text = Logradouro;
                txtCidade.Text = Cidade;
                txtBairro.Text = Bairro;
                txtUF.Text = UF;


            }
            else
            {
                MessageBox.Show("CEP não encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtCEP.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtComplemento.Text = "";
            txtLogradouro.Text = "";
            txtNumero.Text = "";
            txtUF.Text = "";
            Endereco.Enabled = false;
            btnEndereco.Enabled = true;
            dataGridConsultar.Enabled = true;
            txtId.Enabled = true;
            btnID.Enabled = true;
            btnMostrar.Enabled = true;
        }
    }
}
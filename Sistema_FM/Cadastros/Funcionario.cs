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
    public partial class Funcionario : Form
    {
        public Funcionario()
        {
            InitializeComponent();
        }

        private BLL.BLLFuncionarioSql funcionario;


        /*private void Inserir()
        {
            String Nome = txtNome.Text;
            String dtNasc = txtDataNasc.Text;
            String RG = txtRG.Text;
            String CPF = txtCPF.Text;
            String Email = txtEmail.Text;
            String telResidencial = txtResidencial.Text;
            String telMovel = txtMovel.Text;
            String CEP = txtCEP.Text;
            String Senha = txtSenha.Text;
            String Usuario = txtUsuario.Text;
            String confirmaSenha = txtConfirmaSenha.Text;

            if (Nome != "" && dtNasc != "  /  /  " && RG != "  ,   ,   - " && CPF != "   ,   ,   -  " && Email != "" && telResidencial != "(  )    -    " && telMovel != "(  )     -    " && Usuario != "" && Senha != "" && confirmaSenha != "")
            {
                if (Senha != confirmaSenha)
                {
                    MessageBox.Show("As senhas não são compativeis");
                }
                else
        {
            MessageBox.Show("Dados Inseridos");
            funcionario = new BLL.BLLFuncionarioSql();
            funcionario.Inserir(txtNome.Text, txtDataNasc.Text, txtSexo.Text, txtRG.Text, txtCPF.Text, txtEmail.Text, txtResidencial.Text, txtMovel.Text, txtCEP.Text, txtLogradouro.Text, txtNumero.Text, txtComplemento.Text, txtBairro.Text, txtCidade.Text, txtUF.Text, txtSenha.Text, txtUsuario.Text, txtFuncao.Text);

        }
        }
        else
        {
            MessageBox.Show("Dados Incompletos");
        }
    }*/

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form f = new Inicial();
            this.Hide();
        }

        private void txtCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (DAO.ValidaCPF.IsCpf(txtCPF.Text))
            {
                txtCPF.BackColor = Color.PaleGreen;
            }
            else
            {
                txtCPF.BackColor = Color.Tomato;
            }
        }

        private void SelecionarFuncionarioFormCPF()
        {
            // funcionario = new BLL.BLLFuncionario();//

            //DataTable t = funcionario.SelecionarFuncionarioCPF(Convert.ToString(txtCPF.Text));//

            /*string Nome = t.Rows[0][1].ToString();
            string DataNasc = t.Rows[0][2].ToString();
            string RG = t.Rows[0][3].ToString();
            string CPF = t.Rows[0][4].ToString();
            string Email = t.Rows[0][5].ToString();
            string Residencial = t.Rows[0][6].ToString();
            string Movel = t.Rows[0][7].ToString();
            string CEP = t.Rows[0][8].ToString();
            string Usuario = t.Rows[0][9].ToString();
            string Senha = t.Rows[0][10].ToString();


            txtNome.Text = Nome;
            txtDataNasc.Text = DataNasc;
            txtRG.Text = RG;
            txtCPF.Text = CPF;
            txtEmail.Text = Email;
            txtResidencial.Text = Residencial;
            txtMovel.Text = Movel;
            txtCEP.Text = CEP;
            txtUsuario.Text = Usuario;
            txtSenha.Text = Senha;*/

        }

       
        private void txtResidencial_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtCEP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Funcionario_Load(object sender, EventArgs e)
        {

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

        private void btnEncontrar_Click(object sender, EventArgs e)
        {
            BuscarCEP();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Nome = txtNome.Text;
            String dtNasc = txtDataNasc.Text;
            String CPF = txtCPF.Text;
            //String Email = txtEmail.Text;
            String telResidencial = txtResidencial.Text;
            String telMovel = txtMovel.Text;
            String CEP = txtCEP.Text;
            String UF = txtUF.Text;
            String Senha = txtSenha.Text;
            String Usuario = txtUsuario.Text;
            string email = txtEmail.Text;

            Regex rg = new Regex(@"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$");
            Regex nomeValidado = new Regex(@"^[A-Z][a-z]* [A-Z][a-z]*");
           
            if ( Nome == "" || dtNasc == "  /  /  " || UF == ""|| CPF == "   ,   ,   -  " || telResidencial == "(  )    -    " || telMovel == "(  )     -    " || Usuario == "" || Senha == "")// && confirmaSenha != "")
            {
                MessageBox.Show("Preencha todos os campos");
                
            }
            else
            {
                if (txtCPF.BackColor == Color.Tomato)
                {
                    MessageBox.Show("CPF inválido!");
                }
                else if (txtNome.BackColor != Color.Tomato && txtEmail.BackColor != Color.Tomato)
                {
                    CPFRepitido();
                }
                else
                {
                    MessageBox.Show("Campos inválidos!");
                }
            }
        }
         

        
        private void txtCPF_Leave_1(object sender, EventArgs e)
        {
            {
                if (DAO.ValidaCPF.IsCpf(txtCPF.Text))
                {
                    txtCPF.BackColor = Color.White;
                }
                else
                {
                    txtCPF.BackColor = Color.Tomato;
                }
            }

        }

       private void CPFRepitido()
        {
            funcionario = new BLL.BLLFuncionarioSql();
            DataTable r = new DataTable();
            txtCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;        
            r = funcionario.SelecionarFuncionarioCPF(txtCPF.Text);
            txtCPF.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            if (r.Rows.Count > 0)
            {
                MessageBox.Show("cpf já utilizado");
            }
            else
            {
                txtCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                txtCEP.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                txtNumero.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                txtMovel.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                txtResidencial.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                DateTime dataNasc = Convert.ToDateTime(txtDataNasc.Text);
                var dataresumida = dataNasc.ToShortDateString();
                funcionario = new BLL.BLLFuncionarioSql();
                funcionario.Inserir(txtNome.Text, dataresumida, txtSexo.Text, txtCPF.Text, txtEmail.Text, txtResidencial.Text, txtMovel.Text, txtCEP.Text, txtLogradouro.Text, txtNumero.Text , txtComplemento.Text, txtBairro.Text, txtCidade.Text, txtUF.Text, txtUsuario.Text, txtSenha.Text, txtFuncao.Text);
                
                MessageBox.Show("Dados inseridos");
                txtCPF.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                txtCEP.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                txtNumero.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                txtMovel.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                txtResidencial.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                
            }
        }

       private void txtNome_TextChanged(object sender, EventArgs e)
       {
           Regex nomeValidado = new Regex(@"^[A-Z][a-z]* [A-Z][a-z]*");

           if (nomeValidado.IsMatch(txtNome.Text))
           {
               txtNome.BackColor = Color.White;
           }
           else
           {
               txtNome.BackColor = Color.Tomato;
           }
       }

       private void txtEmail_TextChanged(object sender, EventArgs e)
       {
           Regex Email = new Regex(@"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$");
           if (Email.IsMatch(txtEmail.Text))
           {
               txtEmail.BackColor = Color.White;
           }
           else
           {
               txtEmail.BackColor = Color.Tomato;
           }
       }

       private void label3_Click(object sender, EventArgs e)
       {

       }

       private void label6_Click(object sender, EventArgs e)
       {

       }

       private void txtLogradouro_TextChanged(object sender, EventArgs e)
       {

       }

       private void label11_Click(object sender, EventArgs e)
       {

       }

       private void txtBairro_TextChanged(object sender, EventArgs e)
       {

       }

       private void label12_Click(object sender, EventArgs e)
       {

       }

       private void txtCidade_TextChanged(object sender, EventArgs e)
       {

       }
    }
}
        
        


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using Oracle.DataAccess.Client;
using System.Text.RegularExpressions;


namespace GUI
{
    public partial class ATTCliente : Form
    {
        private BLL.BLLClienteSql cliente;

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
        public ATTCliente()
        {
            InitializeComponent();
        }


        /* private void inserir()
         {
             String empresa = txtEmpresa.Text;
             String nome = txtNome.Text;
             String email = txtEmail.Text;
             String tel = txtTel.Text;
             String CPF = txtCPF.Text;

             if (empresa != "" && nome != "" && email != "" && tel != "(  )    -" && CPF != "   ,   ,   -")
             {
                 cliente = new BLL.BLLCliente();
                 cliente.Incluir(txtEmpresa.Text, txtNome.Text, txtEmail.Text, txtTel.Text, txtCPF.Text);
                 MessageBox.Show("Dados Inseridos");
             }
             else
             {
                 MessageBox.Show("Dados Incompletos");
             }
        
         }*/



        private void button1_Click(object sender, EventArgs e)
        {
          //  Conexao objConexao = new Conexao();
            //objConexao.Conectar();
            MessageBox.Show("Conectado ao Banco de Dados");
            //objConexao.Desconectar();
        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            cliente = new BLL.BLLClienteSql();

            String nome = txtNome.Text;
            String razao = txtRazao.Text;
            String CNPJ = txtCNPJ.Text;
            String email = txtEmail.Text;
            String tel = txtTel.Text;
            String CPF = txtCPF.Text;
            String UF = txtUF.Text;
            String Numero = txtNumero.Text;
            String NomeRepresentate = txtNomeRepresentante.Text;
            String TelRepresentante = txtTelRepresentante.Text;
            String emailRepresentante = txtEmailRepresentante.Text;


            if (nome == "" || razao == "" || email == "" || tel == "(  )    -" || CPF == "   ,   ,   -" || UF == "" || Numero == "" || NomeRepresentate == "" || TelRepresentante == "(  )    -" || emailRepresentante == "")
            {

                MessageBox.Show("Dados Incompletos");
            }
            else
            {
                if (txtCPF.BackColor == Color.Tomato)
                {
                    MessageBox.Show("CPF inválido!");
                }
                else if (txtCNPJ.BackColor == Color.Tomato)
                {
                    MessageBox.Show("CNPJ inválido!");

                }
                else if (txtEmail.BackColor == Color.Tomato)
                {
                    MessageBox.Show("Email inválido!");
                }
                else if (txtEmail.BackColor == Color.Tomato)
                {
                    MessageBox.Show("Email inválido!");
                }
                else if (txtNome.BackColor == Color.Tomato)
                {
                    MessageBox.Show("Nome inválido!");

                }
                else
                {
                    txtCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    txtCNPJ.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    txtTel.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    txtTelRepresentante.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    txtCEP.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

                    cliente = new BLL.BLLClienteSql();
                    cliente.Atualizar(txtID.Text, txtNome.Text, txtRazao.Text, txtCNPJ.Text, txtEmail.Text, txtTel.Text, txtCEP.Text, txtLogradouro.Text, txtNumero.Text, txtComplemento.Text, txtBairro.Text, txtCidade.Text, txtUF.Text, txtNomeRepresentante.Text, txtCPF.Text, txtTelRepresentante.Text, txtEmail.Text,txtSenha.Text);
                    MessageBox.Show("Dados atualizados");

                    txtCPF.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                    txtCNPJ.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                    txtTel.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                    txtTelRepresentante.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                    txtCEP.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

                }
            }
        }



        private void btnVoltar_Click(object sender, EventArgs e)
        {
            
        }

        private void Cliente_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultarCliente_Click(object sender, EventArgs e)
        {
            cliente = new BLL.BLLClienteSql();

            DataTable t = cliente.SelecionarClienteCPF(txtCPF.Text);

            string Nome = t.Rows[0][1].ToString();
            string Razao = t.Rows[0][2].ToString();
            string CNPJ = t.Rows[0][3].ToString();
            string Email = t.Rows[0][4].ToString();
            string Telefone = t.Rows[0][5].ToString();
            string CEP = t.Rows[0][6].ToString();
            string Logradouro = t.Rows[0][7].ToString();
            string Numero = t.Rows[0][8].ToString();
            string Complemento = t.Rows[0][9].ToString();
            string Bairro = t.Rows[0][10].ToString();
            string Cidade = t.Rows[0][11].ToString();
            string UF = t.Rows[0][12].ToString();
            string NomeRepresentante = t.Rows[0][13].ToString();
            string CPF = t.Rows[0][14].ToString();
            string TelefoneRepresentante = t.Rows[0][15].ToString();
            string EmailRepresentate = t.Rows[0][16].ToString();


            txtNome.Text = Nome;
            txtRazao.Text = Razao;
            txtCNPJ.Text = CNPJ;
            txtEmail.Text = Email;
            txtTel.Text = Telefone;
            txtCEP.Text = CEP;
            txtLogradouro.Text = Logradouro;
            txtNumero.Text = Numero;
            txtComplemento.Text = Complemento;
            txtBairro.Text = Bairro;
            txtCidade.Text = Cidade;
            txtUF.Text = UF;
            txtNomeRepresentante.Text = NomeRepresentante;
            txtCPF.Text = CPF;
            txtTelRepresentante.Text = TelefoneRepresentante;
            txtEmailRepresentante.Text = EmailRepresentate;
           
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            cliente.Atualizar(txtID.Text,txtNome.Text, txtRazao.Text, txtCNPJ.Text, txtEmail.Text, txtTel.Text, txtCEP.Text, txtLogradouro.Text, txtNumero.Text, txtComplemento.Text, txtBairro.Text, txtCidade.Text, txtUF.Text, txtNomeRepresentante.Text, txtCPF.Text, txtTelRepresentante.Text, txtEmail.Text,txtSenha.Text);
            MessageBox.Show("Dados atualizados");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("Deseja realmente inativar o cliente ? ", "", MessageBoxButtons.YesNo);
            if (dialogo == DialogResult.Yes)
            {
                cliente.Inativar(txtCPF.Text);
                MessageBox.Show("Dados Inativados");
              
            }
            else if (dialogo == DialogResult.No)
            {         
        }
            
        }

        private void btnEncontrar_Click(object sender, EventArgs e)
        {
            BuscarCEP();
        }

        private void txtCPF_Leave(object sender, EventArgs e)
        {
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

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form f = new Inicial();
            this.Hide();
        }

        private void txtNomeRepresentante_TextChanged(object sender, EventArgs e)
        {
            Regex nomeValidado = new Regex(@"^[A-Z][a-z]* [A-Z][a-z]*");

            if (nomeValidado.IsMatch(txtNomeRepresentante.Text))
            {
                txtNomeRepresentante.BackColor = Color.White;
            }
            else
            {
                txtNomeRepresentante.BackColor = Color.Tomato;
            }
        }

        private void txtCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
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

        private void txtEmailRepresentante_TextChanged(object sender, EventArgs e)
        {
            Regex Email = new Regex(@"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$");
            if (Email.IsMatch(txtEmailRepresentante.Text))
            {
                txtEmailRepresentante.BackColor = Color.White;
            }
            else
            {
                txtEmailRepresentante.BackColor = Color.Tomato;
            }
        }

        private void txtCNPJ_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (DAO.validarCNPJ.ValidaCNPJ(txtCNPJ.Text))
            {
                txtCNPJ.BackColor = Color.White;
            }
            else
            {
                txtCNPJ.BackColor = Color.Tomato;
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

        /*private void SelecionarClienteFormCPF()
        {
            cliente = new BLL.BLLCliente();

            DataTable t = cliente.SelecionarClienteCPF(Convert.ToString(txtCPF.Text));

            string Empresa = t.Rows[0][1].ToString();
            string Nome = t.Rows[0][2].ToString();
            string Email = t.Rows[0][3].ToString();
            string Tel = t.Rows[0][4].ToString();
            string CPF = t.Rows[0][5].ToString();

            txtEmpresa.Text = Empresa;
            txtNome.Text = Nome;
            txtEmail.Text = Email;
            txtTel.Text = Tel;
            txtCPF.Text = CPF;

        }
        

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
           
            Atualizar();
        }

        private void Atualizar() 
        {
            String empresa = txtEmpresa.Text;
            String nome = txtNome.Text;
            String email = txtEmail.Text;
            String tel = txtTel.Text;
            String CPF = txtCPF.Text;

            if (empresa != "" && nome != "" && email != "" && tel != "(  )    -" && CPF != "   ,   ,   -")
            {
                cliente.AtualizarClienteCPF(txtEmpresa.Text, txtNome.Text, txtEmail.Text, txtTel.Text, txtCPF.Text);
                MessageBox.Show("Dados atualizados");
            }
            else
            {
                MessageBox.Show("Dados Incompletos");
            }
        }

        private void Excluir()
        {
            String empresa = txtEmpresa.Text;
            String nome = txtNome.Text;
            String email = txtEmail.Text;
            String tel = txtTel.Text;
            String CPF = txtCPF.Text;

            if (empresa != "" && nome != "" && email != "" && tel != "(  )    -" && CPF != "   ,   ,   -")
            {
            }
            else
            {
                MessageBox.Show("Dados Incompletos");
            }

            DialogResult dialogo = MessageBox.Show("Deseja realmente excluir este Cliente ? ", "", MessageBoxButtons.YesNo);
            if (dialogo == DialogResult.Yes)
            {
                cliente.ExcluirClienteCPF(txtCPF.Text);
                MessageBox.Show("Dados Excluídos");
            }
            else if (dialogo == DialogResult.No)
            {

            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnConsultarCliente_Click(object sender, EventArgs e)
        {
            SelecionarClienteFormCPF();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
         
            Excluir();
        }


    }*/
    }
}
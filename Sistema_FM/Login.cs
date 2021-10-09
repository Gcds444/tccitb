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
    public partial class Login : Form
    {
        private BLL.BLLFuncionarioSql funcionario;
        public int tentativas;
        private void SelecionarLoginForm()
        {
            funcionario = new BLL.BLLFuncionarioSql();
            DataTable t = funcionario.SelecionarFuncionarioCadastro(txtUsuario.Text, txtSenha.Text);

            if (t.Rows.Count > 0)
            {

                if (t.Rows[0][18].ToString() == "Inativo")
                {
                    MessageBox.Show("Usuario Inativo");
                    limpar();

                }
                else
                {
                    if (t.Rows[0][17].ToString() == "Administrador")
                    {
                        MessageBox.Show("Seja bem vindo(a)");
                        Inicial f = new Inicial();
                        InicialFunc g = new InicialFunc();
                        f.lblFucionarioNome.Text = t.Rows[0][1].ToString();
                 
                        this.Hide();
                        f.Show();
                    }
                    else
                    {
                        MessageBox.Show("Seja bem vindo(a)");
                        InicialFunc o = new InicialFunc();

                        o.lblFucionario.Text = t.Rows[0][1].ToString();
                      //  o.lblFucionario.Text = t.Rows[0][1].ToString();
                        this.Hide();
                        o.ShowDialog();
                    }

                }
            }
        }

        public void limpar() 
        {
            txtSenha.Clear();
            txtUsuario.Clear();
        }

        public Login()
        {
            InitializeComponent();
        }

        public void transferir()
        {
            
          
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {



            if ((txtUsuario.Text == "") && (txtSenha.Text == ""))
            {
                MessageBox.Show("Preencha os campos");
            }

            else
            {
                SelecionarLoginForm();
                transferir();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = '*';
        }
   

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("Deseja realmente sair ? ", "", MessageBoxButtons.YesNo);
            if (dialogo == DialogResult.Yes)
            {
                Application.Exit();
              
            }
            else if (dialogo == DialogResult.No)
            {

            }
        }

        private void checkBoxSenha_CheckedChanged(object sender, EventArgs e)
        {
            
            if (this.checkBoxSenha.Checked)
            {
                this.txtSenha.PasswordChar = '\0';
                             
            }
            else
            {
                this.txtSenha.PasswordChar = '*';
            }

        }
        public void ProximoControle(Object o, KeyPressEventArgs e) 
        {
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");

            }
        }

       
    }
}

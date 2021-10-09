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
    public partial class ConsultarFuncionario : Form
    {
        private BLL.BLLFuncionarioSql funcionario;

        public ConsultarFuncionario()
        {
            InitializeComponent();
        }


        private void btnMostrar_Click(object sender, EventArgs e)
        {
            pnlAtivar.SendToBack();
            funcionario = new BLL.BLLFuncionarioSql();
            dataGridConsultar.DataSource = funcionario.SelecionarFuncionarioInteiro();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form f = new Inicial();
            this.Hide();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            txtCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            funcionario = new BLL.BLLFuncionarioSql();
            DataTable m = funcionario.SelecionarFuncionarioCPF(txtCPF.Text);
            txtCPF.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

            if (m.Rows.Count == 0)
            {
                MessageBox.Show("CPF não encontrado");
            }
            else if (m.Rows[0][19].ToString() == "Ativo")
                {
                    pnlAtivar.SendToBack();
                    dataGridConsultar.DataSource = m;
                }
                else
                {
                    pnlAtivar.BringToFront();
                    dataGridConsultar.DataSource = m;
                }

            
        }
            
        private void btnMostrarInativo_Click(object sender, EventArgs e)
        {
            pnlAtivar.BringToFront();
            funcionario = new BLL.BLLFuncionarioSql();
            dataGridConsultar.DataSource = funcionario.SelecionarFuncionarioInativo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridConsultar.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum funcionario selecionado");
            }
            else
            {
                ATTFuncionario aa = new ATTFuncionario();

                aa.txtID.Text = dataGridConsultar.Rows[dataGridConsultar.CurrentRow.Index].Cells[0].Value.ToString();
                aa.txtNome.Text = dataGridConsultar.Rows[dataGridConsultar.CurrentRow.Index].Cells[1].Value.ToString();
                aa.txtDataNasc.Text = dataGridConsultar.Rows[dataGridConsultar.CurrentRow.Index].Cells[2].Value.ToString();
                aa.txtSexo.Text = dataGridConsultar.Rows[dataGridConsultar.CurrentRow.Index].Cells[3].Value.ToString();               
                aa.txtCPF.Text = dataGridConsultar.Rows[dataGridConsultar.CurrentRow.Index].Cells[4].Value.ToString();
                aa.txtEmail.Text = dataGridConsultar.Rows[dataGridConsultar.CurrentRow.Index].Cells[5].Value.ToString();
                aa.txtResidencial.Text = dataGridConsultar.Rows[dataGridConsultar.CurrentRow.Index].Cells[6].Value.ToString();
                aa.txtMovel.Text = dataGridConsultar.Rows[dataGridConsultar.CurrentRow.Index].Cells[7].Value.ToString();
                aa.txtCEP.Text = dataGridConsultar.Rows[dataGridConsultar.CurrentRow.Index].Cells[8].Value.ToString();
                aa.txtLogradouro.Text = dataGridConsultar.Rows[dataGridConsultar.CurrentRow.Index].Cells[9].Value.ToString();
                aa.txtNumero.Text = dataGridConsultar.Rows[dataGridConsultar.CurrentRow.Index].Cells[10].Value.ToString();
                aa.txtComplemento.Text = dataGridConsultar.Rows[dataGridConsultar.CurrentRow.Index].Cells[11].Value.ToString();
                aa.txtBairro.Text = dataGridConsultar.Rows[dataGridConsultar.CurrentRow.Index].Cells[12].Value.ToString();
                aa.txtCidade.Text = dataGridConsultar.Rows[dataGridConsultar.CurrentRow.Index].Cells[13].Value.ToString();
                aa.txtUF.Text = dataGridConsultar.Rows[dataGridConsultar.CurrentRow.Index].Cells[14].Value.ToString();
                aa.txtUsuario.Text = dataGridConsultar.Rows[dataGridConsultar.CurrentRow.Index].Cells[15].Value.ToString();
                aa.txtSenha.Text = dataGridConsultar.Rows[dataGridConsultar.CurrentRow.Index].Cells[16].Value.ToString();
                aa.txtFuncao.Text = dataGridConsultar.Rows[dataGridConsultar.CurrentRow.Index].Cells[17].Value.ToString();
                aa.Show();

                dataGridConsultar.DataSource = null;

            }

        }
        private void btnInativar_Click(object sender, EventArgs e)
        {
            if (dataGridConsultar.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum funcionario selecionado");
            }
            else
            {
                string m;
                m = dataGridConsultar.CurrentRow.Cells[0].Value.ToString();
                funcionario.Inativar(m);
                pnlAtivar.SendToBack();
                dataGridConsultar.DataSource = funcionario.SelecionarFuncionarioInteiro();
            }

        }

        private void ConsultarFuncionario_Load(object sender, EventArgs e)
        {
            funcionario = new BLL.BLLFuncionarioSql();
            dataGridConsultar.DataSource = funcionario.SelecionarFuncionarioInteiro();
        
        }

        private void btnAtivar_Click(object sender, EventArgs e)
        {
            if (dataGridConsultar.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum funcionario selecionado");
            }
            else
            {
                string m;
                m = dataGridConsultar.CurrentRow.Cells[0].Value.ToString();
                funcionario.Ativar(m);
                pnlAtivar.SendToBack();
                dataGridConsultar.DataSource = funcionario.SelecionarFuncionarioInteiro();
            }
        }

        }
    }


        /*private void btnMostrar_Click(object sender, EventArgs e)
        {
            funcionario = new BLL.BLLFuncionario();
            dataGridConsultar.DataSource = funcionario.SelecionarFuncionarioInteiro();
        }

        private void btnMostrarInativo_Click(object sender, EventArgs e)
        {
        
 
            funcionario = new BLL.BLLFuncionario();
            dataGridConsultar.DataSource = funcionario.SelecionarFuncionarioInativo();
        
        }
    }
}*/

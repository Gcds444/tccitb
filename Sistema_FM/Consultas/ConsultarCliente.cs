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
    
    public partial class ConsultarCliente : Form
    {

        private BLL.BLLClienteSql cliente;
        

        public ConsultarCliente()
        {
            InitializeComponent();
        }

        private void Consultar_Load(object sender, EventArgs e)
        {
            cliente = new BLL.BLLClienteSql();
            dataGridConsultar.DataSource = cliente.ConsultarCliente();
        }

        
         private void btnMostrar_Click(object sender, EventArgs e)
         {
             
         }

         private void btnVoltar_Click(object sender, EventArgs e)
         {
             
             
         }

         private void btnMostrarInativo_Click(object sender, EventArgs e)
         {
            
         }

         private void button2_Click(object sender, EventArgs e)
         {
             pnlAtivar.BringToFront(); 
             cliente = new BLL.BLLClienteSql();
             dataGridConsultar.DataSource = cliente.SelecionarClienteInativo();
         }

         private void button1_Click(object sender, EventArgs e)
         {
             txtCNPJ.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
             cliente = new BLL.BLLClienteSql();
            DataTable m = cliente.SelecionarClienteCNPJ(txtCNPJ.Text);
            txtCNPJ.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

            if (m.Rows.Count == 0)
            {
                MessageBox.Show("CNPJ não encontrado");
            }
            else if (m.Rows[0][17].ToString() == "Ativo")
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

         

         private void button3_Click(object sender, EventArgs e)
         {
             pnlAtivar.SendToBack();
             cliente = new BLL.BLLClienteSql();
             dataGridConsultar.DataSource = cliente.ConsultarCliente();
         }

         private void button4_Click(object sender, EventArgs e)
         {
             Form f = new Inicial();
             this.Hide();
         }

         private void btnAtualizar_Click(object sender, EventArgs e)
         {
             if (dataGridConsultar.Rows.Count == 0)
             {
                 MessageBox.Show("Nenhum cliente selecionado");
             }
             else
             {
                 ATTCliente aa = new ATTCliente();

                 aa.txtID.Text = dataGridConsultar.Rows[dataGridConsultar.CurrentRow.Index].Cells[0].Value.ToString();
                 aa.txtNome.Text = dataGridConsultar.Rows[dataGridConsultar.CurrentRow.Index].Cells[1].Value.ToString();
                 aa.txtRazao.Text = dataGridConsultar.Rows[dataGridConsultar.CurrentRow.Index].Cells[2].Value.ToString();
                 aa.txtCNPJ.Text = dataGridConsultar.Rows[dataGridConsultar.CurrentRow.Index].Cells[3].Value.ToString();
                 aa.txtEmail.Text = dataGridConsultar.Rows[dataGridConsultar.CurrentRow.Index].Cells[4].Value.ToString();
                 aa.txtTel.Text = dataGridConsultar.Rows[dataGridConsultar.CurrentRow.Index].Cells[5].Value.ToString();
                 aa.txtCEP.Text = dataGridConsultar.Rows[dataGridConsultar.CurrentRow.Index].Cells[6].Value.ToString();
                 aa.txtLogradouro.Text = dataGridConsultar.Rows[dataGridConsultar.CurrentRow.Index].Cells[7].Value.ToString();
                 aa.txtNumero.Text = dataGridConsultar.Rows[dataGridConsultar.CurrentRow.Index].Cells[8].Value.ToString();
                 aa.txtComplemento.Text = dataGridConsultar.Rows[dataGridConsultar.CurrentRow.Index].Cells[9].Value.ToString();
                 aa.txtBairro.Text = dataGridConsultar.Rows[dataGridConsultar.CurrentRow.Index].Cells[10].Value.ToString();
                 aa.txtCidade.Text = dataGridConsultar.Rows[dataGridConsultar.CurrentRow.Index].Cells[11].Value.ToString();
                 aa.txtUF.Text = dataGridConsultar.Rows[dataGridConsultar.CurrentRow.Index].Cells[12].Value.ToString();
                 aa.txtNomeRepresentante.Text = dataGridConsultar.Rows[dataGridConsultar.CurrentRow.Index].Cells[13].Value.ToString();
                 aa.txtCPF.Text = dataGridConsultar.Rows[dataGridConsultar.CurrentRow.Index].Cells[14].Value.ToString();
                 aa.txtTelRepresentante.Text = dataGridConsultar.Rows[dataGridConsultar.CurrentRow.Index].Cells[15].Value.ToString();
                 aa.txtEmailRepresentante.Text = dataGridConsultar.Rows[dataGridConsultar.CurrentRow.Index].Cells[16].Value.ToString();
                 aa.txtSenha.Text = dataGridConsultar.Rows[dataGridConsultar.CurrentRow.Index].Cells[18].Value.ToString();
                 aa.Show();

                 dataGridConsultar.DataSource = null;
             }
         }

         private void btnInativar_Click(object sender, EventArgs e)
         {
             if (dataGridConsultar.Rows.Count == 0)
             {
                 MessageBox.Show("Nenhum cliente selecionado");
             }
             else
             {
                 string m;
                 m = dataGridConsultar.CurrentRow.Cells[0].Value.ToString();
                 cliente.Inativar(m);
                 pnlAtivar.SendToBack();
                 dataGridConsultar.DataSource = cliente.ConsultarCliente();
             }
         }

         private void btnAtivar_Click(object sender, EventArgs e)
         {
             if (dataGridConsultar.Rows.Count == 0)
             {
                 MessageBox.Show("Nenhum cliente selecionado");
             }
             else
             {
                 string m;
                 m = dataGridConsultar.CurrentRow.Cells[0].Value.ToString();
                 cliente.Ativar(m);
                 pnlAtivar.SendToBack();
                 dataGridConsultar.DataSource = cliente.ConsultarCliente();
             }
         }
    }
}

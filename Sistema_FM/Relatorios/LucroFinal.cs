using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Oracle.DataAccess.Client;


namespace GUI
{
    public partial class LucroFinal : Form
    {
        

        private DAO.DAOLucroSql DAOLucro;
        private BLL.BLLLucroSql lucro;
        public LucroFinal()
        {
            InitializeComponent();
        }

        private void LucroFinal_Load(object sender, EventArgs e)
        {
            txtData.CustomFormat = ("MM/yyyy");
            txtData.MaxDate = System.DateTime.Now.Date;
           
        }
            /*
            string conexao = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=LOCALHOST)(PORT=1521)))(CONNECT_DATA=(SID=xe)));User ID=sys;Password=123456; DBA Privilege=SYSDBA;";
            string query = "Select * from admuser.lucro ";
            OracleConnection conDatabase = new OracleConnection(conexao);
            OracleCommand cdmDataBase = new OracleCommand(query, conDatabase);
            OracleDataReader myReader;


            try
            {
                conDatabase.Open();
                myReader = cdmDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    this.cht1.Series[0].Points.AddXY(myReader.GetDateTime(1), myReader.GetDouble(0));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
             

            lblDia.Text = Convert.ToString(System.DateTime.Now.Date.ToString("dd/mm/yyyy"));
            double Salario;
            double Valor;
            double Custo;
            double LucroMensal;
            lucro = new BLL.BLLLucroSql();
            DataTable m = lucro.FuncionarioSalario();
            DataTable p = lucro.EstoqueCusto();
            DataTable o = lucro.PedidoValor();

            if (m.Rows.Count == 0 || p.Rows.Count == 0 || o.Rows.Count == 0)
            {
                MessageBox.Show("Lucro do mês não gerado");
               

            }
            else
            {
                Salario = Convert.ToDouble(m.Rows[0][0].ToString());
                Valor = Convert.ToDouble(o.Rows[0][0].ToString());
                Custo = Convert.ToDouble(p.Rows[0][0].ToString());
                LucroMensal = Valor - (Salario + Custo);
                label1.Text = LucroMensal.ToString();
            }
        
        }
        */
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
       //     cht1.Series[0].Points.AddXY(m, o);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            lucro = new BLL.BLLLucroSql();
            //Vamos considerar que a data seja o dia de hoje, mas pode ser qualquer data.
            DateTime data = txtData.Value;
            int diasNoMes = DateTime.DaysInMonth(data.Year, data.Month);
            int mes = data.Month;
            int dia = data.Day;
            int ano = data.Year;

            DateTime ComecoDia = new DateTime(ano, mes, dia);
            DateTime ComecoFim = new DateTime(ano, mes, diasNoMes);

            DataTable CustoEstoque = lucro.EstoqueCusto(ComecoDia,ComecoFim);
            DataTable LucroVenda = lucro.LucroVenda(ComecoDia,ComecoFim);
            string estoque = CustoEstoque.Rows[0][0].ToString();
            string venda = LucroVenda.Rows[0][0].ToString();
            double estoquevalor = Convert.ToDouble(estoque);
            double vendavalor = Convert.ToDouble(venda);
            double lucroFim = vendavalor - estoquevalor;
            lblEstoque.Text = estoque;
            lblVenda.Text = venda;
            lblLucro.Text = Convert.ToString(lucroFim);
            if (lucroFim > 0)
            {
                lblLucro.ForeColor = Color.Green;
                label7.ForeColor = Color.Green;
            }
            else
            {
                lblLucro.ForeColor = Color.Red;
                label7.ForeColor = Color.Red;
            }

            btnTabela.Enabled = true;
            
        }
/*
            lucro = new BLL.BLLLucroSql();
            double lucroDia = Convert.ToDouble(label1.Text);
            lucro.InserirLucro(lucroDia);

            string conexao = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=LOCALHOST)(PORT=1521)))(CONNECT_DATA=(SID=xe)));User ID=sys;Password=123456; DBA Privilege=SYSDBA;";
            string query = "Select * from admuser.lucro ";
            OracleConnection conDatabase = new OracleConnection(conexao);
            OracleCommand cdmDataBase = new OracleCommand(query, conDatabase);
            OracleDataReader myReader;

           

            try
            {
                conDatabase.Open();
                myReader = cdmDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    this.cht1.Series[0].Points.AddXY(myReader.GetDateTime(1), myReader.GetDouble(0));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
            */
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form f = new Inicial();
            this.Hide();
        }

        private void txtData_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            lucro = new BLL.BLLLucroSql();
            //Vamos considerar que a data seja o dia de hoje, mas pode ser qualquer data.
            DateTime data = txtData.Value;
            int diasNoMes = DateTime.DaysInMonth(data.Year, data.Month);
            int mes = data.Month;
            int dia = data.Day;
            int ano = data.Year;

            DateTime ComecoDia = new DateTime(ano, mes, dia);
            DateTime ComecoFim = new DateTime(ano, mes, diasNoMes);

            DataTable CustoEstoque = lucro.EstoqueCusto(ComecoDia, ComecoFim);
            DataTable LucroVenda = lucro.LucroVenda(ComecoDia, ComecoFim);
            string estoque = CustoEstoque.Rows[0][0].ToString();
            string venda = LucroVenda.Rows[0][0].ToString();
            double estoquevalor = Convert.ToDouble(estoque);
            double vendavalor = Convert.ToDouble(venda);
            double lucroFim = vendavalor - estoquevalor;

            this.cht1.Series[0].Points.AddXY(txtData.Text, lucroFim);
            btnTabela.Enabled = false;

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace interface_wms
{
    public partial class frmAddCateg : Form
    {
        //método que vai executar a consulta. É necessário chamar o método onde deseja que ele seja executado passando o parâmetro de uma string que possui a consulta SQL desejada.
               //Importante: A string precisa ter o nome SQL pois o comando só executará a Query da string com nome de SQL.
        public void executaConsulta(string SQL)
        {
            string StrConexao = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + Application.StartupPath + @"\BDP2-WMSV2.mdb";
            OleDbConnection connect = new OleDbConnection(StrConexao);
            connect.Open();
            OleDbCommand comando = new OleDbCommand(SQL, connect);
            comando.ExecuteNonQuery();
            connect.Close();
        }

        public frmAddCateg()
        {
            InitializeComponent();
        }

        private void txtDescriptCateg_MouseUp(object sender, MouseEventArgs e)
        {
            if (txtDescriptCateg.Text == "Escreva uma breve descrição desta categoria")
            {
                txtDescriptCateg.Text = " ";
                txtDescriptCateg.ForeColor = Color.Black;
            }
        }

        private void txtNameCateg_MouseUp(object sender, MouseEventArgs e)
        {
            if (txtNameCateg.Text == "Insira o nome da nova categoria")
            {
                txtNameCateg.Text = " ";
                txtNameCateg.ForeColor = Color.Black;
            }
        }

        private void txtNameCateg_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try {
                Random cod = new Random();
                int randCod = cod.Next(00, 99);
                string SQL = "INSERT INTO g5_Categoria (CodCateg, Nome, Descricao) VALUES ('" + randCod + "','" + txtNameCateg.Text + "','" + txtDescriptCateg.Text + "')";
                executaConsulta(SQL);
                MessageBox.Show($"Categoria {txtNameCateg.Text} (Código {randCod}) adicionada com sucesso!", "FAWS WMS");
                this.Close();
            }
            catch (Exception erroCadastro)
            {
                MessageBox.Show(erroCadastro.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

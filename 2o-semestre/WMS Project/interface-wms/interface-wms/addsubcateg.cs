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
    public partial class frmAddSubCateg : Form
    {
        public void executaConsulta(string SQL)
        {
            string StrConexao = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + Application.StartupPath + @"\BDP2-WMSV2.mdb";
            OleDbConnection connect = new OleDbConnection(StrConexao);
            connect.Open();
            OleDbCommand comando = new OleDbCommand(SQL, connect);
            comando.ExecuteNonQuery();
            connect.Close();
        }

        public frmAddSubCateg()
        {
            InitializeComponent();
        }

        private void txtNameSubCateg_MouseUp(object sender, MouseEventArgs e)
        {
            if (txtNameSubCateg.Text == "Insira o nome da nova sub categoria")
            {
                txtNameSubCateg.Text = " ";
                txtNameSubCateg.ForeColor = Color.Black;
            }
        }

        private void txtDescriptSubCateg_MouseUp(object sender, MouseEventArgs e)
        {
            if (txtDescriptSubCateg.Text == "Escreva uma breve descrição desta sub categoria")
            {
                txtDescriptSubCateg.Text = " ";
                txtDescriptSubCateg.ForeColor = Color.Black;
            }
        }

        private void txtCateg_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                string StrConexao = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + Application.StartupPath + @"\BDP2-WMSV2.mdb";
                OleDbConnection connect = new OleDbConnection(StrConexao);
                connect.Open();

                System.Data.OleDb.OleDbDataAdapter cat = new System.Data.OleDb.OleDbDataAdapter("SELECT CodCateg,NOME FROM g5_Categoria", connect);
                DataTable categoria = new DataTable();
                cat.Fill(categoria);

                txtCateg.DataSource = categoria;
                txtCateg.ValueMember = "CodCateg";
                txtCateg.DisplayMember = "Nome";


            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Random codSub = new Random();
                int randCodSub = codSub.Next(00, 99);
                string SQL = "INSERT INTO G5_SUBCATEGORIA (NOME, CATEGORIA, CODSUBCATEG,DESCRICAO) VALUES ('"+ txtNameSubCateg.Text+"',"+txtCateg.SelectedValue+","+randCodSub+",'"+ txtDescriptSubCateg.Text+"')";
                executaConsulta(SQL);
                MessageBox.Show($"Sub categoria {txtNameSubCateg.Text} adicionada com sucesso!", "FAWS WMS");
                this.Close();
            }
            catch (Exception err) 
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCateg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNameSubCateg_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

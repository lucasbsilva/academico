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
using System.Data.SqlClient;

namespace schedule
{
    public partial class frmSchedule : Form
    {
        public frmSchedule()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string folder = Application.StartupPath + @"\scheduleDB.mdb";

                string StrConexao = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + folder;

                OleDbConnection connect = new OleDbConnection(StrConexao);

                connect.Open();

                int id = new Random().Next(1, 1000);
                string SQL;
                SQL = "Insert Into contacts(id, name, address, email, phone01, phone02) Values";
                SQL += "('" + id + "', '" + txtName.Text + "','" + txtAddress.Text + "','" + txtEmail.Text + "','" + txtPhone01.Text + "','" + txtPhone02.Text + "')";

                OleDbCommand comando = new OleDbCommand(SQL, connect);

                comando.ExecuteNonQuery();

                MessageBox.Show("Data successfully saved.");
                txtName.Clear();
                txtAddress.Clear();
                txtEmail.Clear();
                txtPhone01.Clear();
                txtPhone02.Clear();

                connect.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtPhone01.Clear();
            txtPhone02.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string folder = Application.StartupPath + @"\scheduleDB.mdb";

                string StrConexao = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + folder;

                OleDbConnection connect = new OleDbConnection(StrConexao);

                connect.Open();

                var cellvalue = dgvSearch.CurrentCell.Value;

                OleDbCommand comando = new OleDbCommand();
                comando.Connection = connect;

                comando.CommandText = "DELETE FROM contacts WHERE name = '" + cellvalue + "'";
                comando.ExecuteNonQuery();
                MessageBox.Show("Data deleted from the table successfully! Perform a search again.");
                comando.Dispose();

                txtName.Clear();
                txtAddress.Clear();
                txtEmail.Clear();
                txtPhone01.Clear();
                txtPhone02.Clear();
            }

            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }

        private void btnConsult_Click(object sender, EventArgs e)
        {
            dgvSearch.Rows.Clear();

            string folder = Application.StartupPath + @"\scheduleDB.mdb";
            string StrConexao = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + folder;

            OleDbConnection connect = new OleDbConnection(StrConexao);

            try
            {
                string consulta = "SELECT * FROM contacts";

                if (txtSearch.Text != "")
                {
                    consulta = "SELECT * FROM contacts WHERE name LIKE '" + txtSearch.Text + "'";
                }

                DataTable dados = new DataTable();
                OleDbDataAdapter adapt = new OleDbDataAdapter(consulta, StrConexao);

                connect.Open();

                adapt.Fill(dados);

                foreach (DataRow linha in dados.Rows)
                {
                    dgvSearch.Rows.Add(linha.ItemArray);
                }

            }
            catch (Exception er)
            {
                dgvSearch.Rows.Clear();
                MessageBox.Show("Erro " + er);
            }
            finally
            {
                connect.Close();
            }
        }

        private void frmSchedule_Load(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string folder = Application.StartupPath + @"\scheduleDB.mdb";
            string StrConexao = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + folder;

            OleDbConnection connect = new OleDbConnection(StrConexao);

            try
            {
                connect.Open();
                OleDbCommand comando = new OleDbCommand();
                comando.Connection = connect;

                var cellvalue = dgvSearch.CurrentCell.Value;
                string name = txtName.Text;
                string address = txtAddress.Text;
                string email = txtEmail.Text;
                string phone01 = txtPhone01.Text;
                string phone02 = txtPhone02.Text;

                string consult = "UPDATE contacts SET name = '" + name + "', address = '" + address + "', email = '" + email + "', phone01 = '" + phone01 + "', phone02 = '" + phone02 + "' WHERE name LIKE '" + cellvalue + "'";
                comando.CommandText = consult;
                comando.ExecuteNonQuery();
                
                MessageBox.Show("Successfully changed data! Perform a search again.");
                
                txtName.Clear();
                txtAddress.Clear();
                txtEmail.Clear();
                txtPhone01.Clear();
                txtPhone02.Clear();
                
                comando.Dispose();
            }
            catch (Exception er)
            {
                MessageBox.Show("Erro " + er);
            }
            finally
            {
                connect.Close();
            }
        }

        private void dgvSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_MouseHover(object sender, EventArgs e)
        {
            ToolTip hover = new ToolTip();
            hover.SetToolTip(this.btnDelete, "To delete a contact, click on its name and then Delete'.");
        }

        private void btnEdit_MouseHover_1(object sender, EventArgs e)
        {
            ToolTip hover = new ToolTip();
            hover.SetToolTip(this.btnEdit, "To edit a contact, click on its name, fill in the fields with the new information and click on 'Edit'.");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

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

namespace cadastro_bd
{
    public partial class formCadastro : Form
    {
        public formCadastro()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // monta o caminho até o arquivo do banco de dados
                string pasta = Application.StartupPath + @"\database\bd-teste.mdb";

                // monta a string de conexão com o banco de dados Access
                string StrConexao = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + pasta;

                // executa a conexão com o banco de dados
                OleDbConnection connec = new OleDbConnection(StrConexao);

                // abre a conexão
                connec.Open();

                // monta string SQL para a tabela Clientes
                string SQL;
                SQL = "Insert Into Clientes(CPF, nome, telefone) Values"; // comando SQL para inserir dados
                SQL += "('"+ tbCPF.Text + "','" + tbName.Text + "','" + tbTel.Text +"')";

                // cria o comando do SQL na conexão aberta
                OleDbCommand comando = new OleDbCommand(SQL, connec);

                // método para executar o comando SQL que não retorna dados
                comando.ExecuteNonQuery();

                MessageBox.Show("Dados gravados com sucesso.");
                tbCPF.Clear();
                tbName.Clear();
                tbTel.Clear();

                // fecha a conexão com o banco de dados
                connec.Close();
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        
        {
            try
            {
                string pasta = Application.StartupPath + @"\database\bd-teste.mdb";

                string StrConexao = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + pasta;

                OleDbConnection connec = new OleDbConnection(StrConexao);

                connec.Open();

                OleDbCommand comando = new OleDbCommand();
                comando.Connection = connec;

                string cons = "UPDATE Clientes SET nome = '" + tbName.Text + "',telefone = '" + tbTel.Text + "'WHERE cpf = '" + tbCPF.Text + "'";

                comando.CommandText = cons;

                comando.ExecuteNonQuery();

                MessageBox.Show("Dados atualizados com sucesso.");
                tbCPF.Clear();
                tbName.Clear();
                tbTel.Clear();

                connec.Dispose();
            }

            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }
                

    private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string pasta = Application.StartupPath + @"\database\bd-teste.mdb";

                string StrConexao = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + pasta;

                OleDbConnection connec = new OleDbConnection(StrConexao);

                connec.Open();

                OleDbCommand comando = new OleDbCommand();
                comando.Connection = connec;

                comando.CommandText = "DELETE FROM Clientes WHERE cpf = '" + tbCPF.Text + "'";

                comando.ExecuteNonQuery();

                MessageBox.Show("Dados excluidos com sucesso.");
                tbCPF.Clear();
                tbName.Clear();
                tbTel.Clear();

                connec.Dispose();
            }

            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                string pasta = Application.StartupPath + @"\database\bd-teste.mdb";

                string StrConexao = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + pasta;

                OleDbConnection connec = new OleDbConnection(StrConexao);

                string procura = "SELECT * FROM Clientes";

                if (tbCPF.Text != "")
                {
                    procura = "SELECT * FROM Clientes WHERE cpf LIKE'" + tbCPF.Text + "'";
                }

                DataTable dados = new DataTable();

                OleDbDataAdapter adpt = new OleDbDataAdapter(procura, connec);

                connec.Open();

                adpt.Fill(dados);

                tbName.Text = (string) dados.Rows[0][1];
                tbCPF.Text = (string)dados.Rows[0][2];
                tbTel.Text = (string)dados.Rows[0][3];
            }

            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}

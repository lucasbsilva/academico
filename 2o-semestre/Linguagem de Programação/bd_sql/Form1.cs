using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.IO;

namespace bd_sql
{
    public partial class sql_bd : Form
    {
        public sql_bd()
        {
            InitializeComponent();
        }

        private void BTNConnect_Click(object sender, EventArgs e)
        {
            string pathBD = Application.StartupPath + @"\DB\BancoSqlCe.sdf"; // retorna a pasta executável
            string strConnection = @"DataSource =" + pathBD + "; PassWord = '123'";
            SqlCeEngine bd = new SqlCeEngine(strConnection);
            
            if (!File.Exists(pathBD))
            {
                bd.CreateDatabase();
            }
            bd.Dispose();

            SqlCeConnection conexao = new SqlCeConnection(strConnection); // fazer a conexão com o banco de dados

            try
            {
                conexao.Open(); // abrir conexao
                MessageBox.Show("Connection established!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error establishing connection" + ex);
            }
            finally
            {
                conexao.Close(); // fechar a conexão
            }
        }

        private void BTNCreateTable_Click(object sender, EventArgs e)
        {
            string pathBD = Application.StartupPath + @"\DB\BancoSqlCe.sdf"; // retorna a pasta executável
            string strConnection = @"DataSource =" + pathBD + "; PassWord = '123'";

            SqlCeConnection conexao = new SqlCeConnection(strConnection); // fazer a conexão com o banco de dados

            try
            {
                conexao.Open();
                SqlCeCommand comando = new SqlCeCommand();
                comando.Connection = conexao;
                comando.CommandText = "CREATE TABLE pessoas (id INT NOT NULL PRIMARY KEY, nome NVARCHAR(50), email NVARCHAR(50))";
                comando.ExecuteNonQuery();
                MessageBox.Show("Table created successfully.");
                comando.Dispose();
            }
            catch (Exception er)
            {
                MessageBox.Show("Erro " + er);
            }
            finally
            {
                conexao.Close(); // fechar a conexão
            }
        }

        private void BTNCreate_Click(object sender, EventArgs e)
        {
            string pathBD = Application.StartupPath + @"\DB\BancoSqlCe.sdf"; // retorna a pasta executável
            string strConnection = @"DataSource =" + pathBD + "; PassWord = '123'";

            SqlCeConnection conexao = new SqlCeConnection(strConnection); // fazer a conexão com o banco de dados

            try
            {
                conexao.Open();
                SqlCeCommand comando = new SqlCeCommand();
                comando.Connection = conexao;

                int id = new Random().Next(0, 1000);
                string nome = TBName.Text;
                string email = TBEmail.Text;

                comando.CommandText = "INSERT INTO pessoas VALUES (" + id + ", '" + nome + "' , '" + email + "')";
                comando.ExecuteNonQuery();
                MessageBox.Show("Data inserted in the table created successfully! Perform a search again.");
                
                TBName.Clear();
                TBEmail.Clear();

                comando.Dispose();
            }
            catch (Exception er)
            {
                MessageBox.Show("Erro " + er);
            }
            finally
            {
                conexao.Close(); // fechar a conexão
            }

        }

        private void BTNSearch_Click(object sender, EventArgs e)
        {
            DGridData.Rows.Clear();
            
            string pathBD = Application.StartupPath + @"\DB\BancoSqlCe.sdf"; // retorna a pasta executável
            string strConnection = @"DataSource =" + pathBD + "; PassWord = '123'";

            SqlCeConnection conexao = new SqlCeConnection(strConnection); // fazer a conexão com o banco de dados

            try
            {
                string consulta = "SELECT * FROM pessoas"; // criação da string consulta

                if (TBName.Text != "")
                {
                    consulta = "SELECT * FROM pessoas WHERE nome LIKE '" + TBName.Text + "'";
                }

                DataTable dados = new DataTable(); // criação da tabela de dados
                SqlCeDataAdapter adapt = new SqlCeDataAdapter(consulta, strConnection); // criação do adaptador para preencher a tabela

                conexao.Open();

                adapt.Fill(dados); // preenche tabela de dados

                foreach(DataRow linha in dados.Rows) // linha a linha para mostrar na lista
                {
                    DGridData.Rows.Add(linha.ItemArray);
                }

            }
            catch (Exception er)
            {
                DGridData.Rows.Clear();
                MessageBox.Show("Erro " + er);
            }
            finally
            {
                conexao.Close(); // fechar a conexão
            }
        }

        private void BTNDelete_Click(object sender, EventArgs e)
        {
            string pathBD = Application.StartupPath + @"\DB\BancoSqlCe.sdf"; // retorna a pasta executável
            string strConnection = @"DataSource =" + pathBD + "; PassWord = '123'";

            SqlCeConnection conexao = new SqlCeConnection(strConnection); // fazer a conexão com o banco de dados

            try
            {
                conexao.Open();
                SqlCeCommand comando = new SqlCeCommand();
                comando.Connection = conexao;

                int id = (int)DGridData.SelectedRows[0].Cells[0].Value;

                comando.CommandText = "DELETE FROM pessoas WHERE id = '" + id + "'";
                comando.ExecuteNonQuery();
                MessageBox.Show("Data deleted from the table successfully! Perform a search again.");
                comando.Dispose();

            }
            catch (Exception er)
            {
                MessageBox.Show("Erro " + er);
            }
            finally
            {
                conexao.Close(); // fechar a conexão
            }
        }

        private void BTNEdit_Click(object sender, EventArgs e)
        {
            string pathBD = Application.StartupPath + @"\DB\BancoSqlCe.sdf"; // retorna a pasta executável
            string strConnection = @"DataSource =" + pathBD + "; PassWord = '123'";

            SqlCeConnection conexao = new SqlCeConnection(strConnection); // fazer a conexão com o banco de dados

            try
            {
                conexao.Open();
                SqlCeCommand comando = new SqlCeCommand();
                comando.Connection = conexao;

                int id = (int)DGridData.SelectedRows[0].Cells[0].Value;
                string nome = TBName.Text;
                string email = TBEmail.Text;

                string consulta = "UPDATE pessoas SET nome = '" + nome + "', email = '" + email + "' WHERE id LIKE '" + id + "'";

                comando.CommandText = consulta;
                comando.ExecuteNonQuery();
                MessageBox.Show("Successfully changed data! Perform a search again.");
                TBName.Clear();
                TBEmail.Clear();
                comando.Dispose();

            }
            catch (Exception er)
            {
                MessageBox.Show("Erro " + er);
            }
            finally
            {
                conexao.Close(); // fechar a conexão
            }
        }

        private void DGridData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

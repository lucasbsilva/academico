using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class calculator : Form
    {
        public calculator()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
            //System.Diagnostics.Process.Start("chrome", "https://www.matematica.pt/util/calculadora-cientifica.php");
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("excel");
        }

        private void chromeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("chrome");
        }

        private void blocoDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad");
        }

        private void tbPNum_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbPNum_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                tbPNum.ForeColor = Color.LightGreen;
            }
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(tbPNum.Text);
            double num2 = Convert.ToDouble(tbSNum.Text);
            tbResult.Text = Convert.ToString(num1 + num2);
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(tbPNum.Text);
            double num2 = Convert.ToDouble(tbSNum.Text);
            tbResult.Text = Convert.ToString(num1 - num2);
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(tbPNum.Text);
            double num2 = Convert.ToDouble(tbSNum.Text);
            tbResult.Text = Convert.ToString(num1 / num2);
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(tbPNum.Text);
            double num2 = Convert.ToDouble(tbSNum.Text);
            tbResult.Text = Convert.ToString(num1 * num2);
        }

        private void salvarComoToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

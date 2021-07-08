using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listbox
{
    public partial class ListBox : Form
    {
        public ListBox()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbItens.Items.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lbItens.Items.Add(tbAddItens.Text);
            tbAddItens.Clear();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lbItens.Items.RemoveAt(lbItens.SelectedIndex);
        }
    }
}

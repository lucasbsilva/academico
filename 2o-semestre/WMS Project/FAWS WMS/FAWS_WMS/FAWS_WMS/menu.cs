using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FAWS_WMS
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void tmrDataHora_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("dd/MM/yyyy, HH:mm");
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login frm = new login();
            Hide();
            frm.Show();
        }

        private void suporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para informações e suporte do sistema, entre em contato através de um dos e-mails abaixo:\n\n" +
                "Cássia Yaisa e Lucas Bezerra - Responsáveis pelo módulo de Produtos.\n(cassia.souza2@fatec.sp.gov.br)\n(lucas.silva776@fatec.sp.gov.br)\n\n" +
                "Danielle de Oliveira - Responsável pelo módulo de Expedição.\n(danielle.cabral@fatec.sp.gov.br)\n\n" +
                "Gabriel Soares - Responsável pelo módulo de Armazém.\n(gabriel.gomes13@fatec.sp.gov.br)\n\n" +
                "Lucas Aparecido - Responsável pelo módulo de Recebimento.\n(lucas.marcuzo@fatec.sp.gov.br)\n\n" +
                "Netivan Florentino - Responsável pelo módulo de Clientes e Fornecedores.\n(netivan.rocha@fatec.sp.gov.br)", "FAWS WMS - Suporte");
        }
    }
}

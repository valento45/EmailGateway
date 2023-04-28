using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Email
{
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void btsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btconfiguraremail_Click(object sender, EventArgs e)
        {
            frmConfiguraEmail configura= new frmConfiguraEmail();
            configura.ShowDialog();
        }

        private void btenviaremail_Click(object sender, EventArgs e)
        {
            frmEnviaEmail envia;
            envia = new frmEnviaEmail();
            envia.ShowDialog();
        }
    }
}

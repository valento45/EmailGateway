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
    public partial class anexosEmail : UserControl
    {
        public string caminho { get; set; }
        public anexosEmail()
        {
            InitializeComponent();
        }
        public void selecionaimagem()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Multiselect = false;
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                caminho = openFile.FileName;
                txtcaminho.Text = caminho;
            }
        }

        private void btnselecionarimagem_Click(object sender, EventArgs e)
        {
            selecionaimagem();
        }

        private void btremove_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmailGateway;
namespace Email
{
    public partial class frmEnviaEmail : Form
    {
        public frmEnviaEmail()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Add(new anexosEmail());
        }

        private void btcancela_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btenvia_Click(object sender, EventArgs e)
        {
            enviaremail();

        }
        private void enviaremail()
        {
            string assunto = txtassunto.Text;
            string[] destinos = txtdestinos.Text.Split(';');
            List<string> anexos = new List<string>();
            string conteudo = txtconteudo.Text;
            string mensagemreturno = "";
            foreach (Control ctrl in flowLayoutPanel1.Controls)
            {
                if(ctrl.Name == "anexosEmail")
                {
                    if((ctrl as anexosEmail).caminho != string.Empty)
                    {
                        anexos.Add((ctrl as anexosEmail).caminho);
                    }
                }
            }
            foreach(string destino in destinos)
            {
              mensagemreturno =   EmailBE.EnviaEmailComAnexoStatic(destino, assunto, conteudo, anexos);
            }
            MessageBox.Show(mensagemreturno);
        }
    }
}

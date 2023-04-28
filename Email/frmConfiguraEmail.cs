using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Email
{
    public partial class frmConfiguraEmail : Form
    {
        public frmConfiguraEmail()
        {
            InitializeComponent();


        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarCredenciais(); 
        }

        private void SalvarCredenciais()
        {
            if (!validacampos())
            {
                return;
            }
           
            


               
            string caminho = AppDomain.CurrentDomain.BaseDirectory;


            string Arquivo = "config.txt";
            if (File.Exists(Path.Combine(caminho, Arquivo)))
            {
                File.Delete(Path.Combine(caminho, Arquivo));
            }


            string Credenciais = $"{txtEmail.Text}, {txtSenha.Text}, smtp.gmail.com, 587";

            File.WriteAllText(Path.Combine(caminho, Arquivo), Credenciais);




        }

        /// <summary>
        /// esse metado valida os campos obrigatorios do email.
        /// </summary>
        /// <returns></returns>
        private bool validacampos()
        {
            if(txtEmail.Text == string.Empty|| txtSenha.Text == string.Empty||label.Text==string.Empty)
            {
                MessageBox.Show("por favor verifique o preenchimento dos campos", "validaçao de campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// metado responsavel por ler dados de email.
        /// </summary>
        /// <returns></returns>
        public static string[] ledadodemail()
        {
            string caminho = AppDomain.CurrentDomain.BaseDirectory;
            string Arquivo = "config.txt";
            string[] result = null;
            if (File.Exists(Path.Combine(caminho, Arquivo)))
            {
                result = File.ReadAllText(Path.Combine(caminho, Arquivo)).Split(',');
            }
            return result;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            pctConfirmaSenha.Visible = true;
            if(txtSenha.Text == txtConfirmaSenha.Text)
            {
                pctConfirmaSenha.BackgroundImage = Properties.Resources.kisspng_information_jason_dunne_organization_font_confirm_5b22415c889197_7817530315289716125594;
            }
            else
            {
                pctConfirmaSenha.BackgroundImage = Properties.Resources.png_transparent_cancel_icon_icons_matt_symbol;
            }
        }
    }
}

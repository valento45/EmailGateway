
namespace Email
{
    partial class frmEnviaEmail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEnviaEmail));
            this.pnlfundo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.ll = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtassunto = new System.Windows.Forms.TextBox();
            this.txtdestinos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ljlj = new System.Windows.Forms.Label();
            this.pnlcorpo = new System.Windows.Forms.Panel();
            this.txtconteudo = new System.Windows.Forms.RichTextBox();
            this.btenvia = new System.Windows.Forms.Button();
            this.btcancela = new System.Windows.Forms.Button();
            this.pnlfundo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlcorpo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlfundo
            // 
            this.pnlfundo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlfundo.BackColor = System.Drawing.SystemColors.Control;
            this.pnlfundo.Controls.Add(this.panel1);
            this.pnlfundo.Controls.Add(this.pnlcorpo);
            this.pnlfundo.Location = new System.Drawing.Point(12, 12);
            this.pnlfundo.Name = "pnlfundo";
            this.pnlfundo.Size = new System.Drawing.Size(776, 315);
            this.pnlfundo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.ll);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.txtassunto);
            this.panel1.Controls.Add(this.txtdestinos);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ljlj);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(769, 179);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Email.Properties.Resources.add;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(39, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 38);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ll
            // 
            this.ll.AutoSize = true;
            this.ll.Location = new System.Drawing.Point(39, 84);
            this.ll.Name = "ll";
            this.ll.Size = new System.Drawing.Size(42, 13);
            this.ll.TabIndex = 5;
            this.ll.Text = "Anexos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(94, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Separe os email com ponto e virgula.\r\n";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(97, 84);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(657, 80);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // txtassunto
            // 
            this.txtassunto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtassunto.Location = new System.Drawing.Point(88, 14);
            this.txtassunto.Name = "txtassunto";
            this.txtassunto.Size = new System.Drawing.Size(657, 20);
            this.txtassunto.TabIndex = 0;
            // 
            // txtdestinos
            // 
            this.txtdestinos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdestinos.Location = new System.Drawing.Point(88, 44);
            this.txtdestinos.Name = "txtdestinos";
            this.txtdestinos.Size = new System.Drawing.Size(657, 20);
            this.txtdestinos.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Destinatarios";
            // 
            // ljlj
            // 
            this.ljlj.AutoSize = true;
            this.ljlj.Location = new System.Drawing.Point(38, 17);
            this.ljlj.Name = "ljlj";
            this.ljlj.Size = new System.Drawing.Size(45, 13);
            this.ljlj.TabIndex = 0;
            this.ljlj.Text = "Assunto";
            // 
            // pnlcorpo
            // 
            this.pnlcorpo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlcorpo.Controls.Add(this.txtconteudo);
            this.pnlcorpo.Location = new System.Drawing.Point(3, 189);
            this.pnlcorpo.Name = "pnlcorpo";
            this.pnlcorpo.Size = new System.Drawing.Size(769, 123);
            this.pnlcorpo.TabIndex = 4;
            // 
            // txtconteudo
            // 
            this.txtconteudo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtconteudo.Location = new System.Drawing.Point(3, 3);
            this.txtconteudo.Name = "txtconteudo";
            this.txtconteudo.Size = new System.Drawing.Size(763, 120);
            this.txtconteudo.TabIndex = 0;
            this.txtconteudo.Text = "";
            // 
            // btenvia
            // 
            this.btenvia.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btenvia.Location = new System.Drawing.Point(309, 334);
            this.btenvia.Name = "btenvia";
            this.btenvia.Size = new System.Drawing.Size(75, 23);
            this.btenvia.TabIndex = 5;
            this.btenvia.Text = "enviar";
            this.btenvia.UseVisualStyleBackColor = true;
            this.btenvia.Click += new System.EventHandler(this.btenvia_Click);
            // 
            // btcancela
            // 
            this.btcancela.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btcancela.Location = new System.Drawing.Point(399, 334);
            this.btcancela.Name = "btcancela";
            this.btcancela.Size = new System.Drawing.Size(75, 23);
            this.btcancela.TabIndex = 6;
            this.btcancela.Text = "cancelar";
            this.btcancela.UseVisualStyleBackColor = true;
            this.btcancela.Click += new System.EventHandler(this.btcancela_Click);
            // 
            // frmEnviaEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 360);
            this.Controls.Add(this.btcancela);
            this.Controls.Add(this.btenvia);
            this.Controls.Add(this.pnlfundo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEnviaEmail";
            this.Text = "Envio de email";
            this.pnlfundo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlcorpo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlfundo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pnlcorpo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtassunto;
        private System.Windows.Forms.TextBox txtdestinos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ljlj;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ll;
        private System.Windows.Forms.RichTextBox txtconteudo;
        private System.Windows.Forms.Button btenvia;
        private System.Windows.Forms.Button btcancela;
    }
}
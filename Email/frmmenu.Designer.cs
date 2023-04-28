
namespace Email
{
    partial class frmmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmenu));
            this.btenviaremail = new System.Windows.Forms.Button();
            this.btconfiguraremail = new System.Windows.Forms.Button();
            this.btsair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btenviaremail
            // 
            this.btenviaremail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btenviaremail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btenviaremail.Location = new System.Drawing.Point(12, 12);
            this.btenviaremail.Name = "btenviaremail";
            this.btenviaremail.Size = new System.Drawing.Size(328, 38);
            this.btenviaremail.TabIndex = 7;
            this.btenviaremail.Text = "Enviar email";
            this.btenviaremail.UseVisualStyleBackColor = true;
            this.btenviaremail.Click += new System.EventHandler(this.btenviaremail_Click);
            // 
            // btconfiguraremail
            // 
            this.btconfiguraremail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btconfiguraremail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btconfiguraremail.Location = new System.Drawing.Point(12, 59);
            this.btconfiguraremail.Name = "btconfiguraremail";
            this.btconfiguraremail.Size = new System.Drawing.Size(328, 38);
            this.btconfiguraremail.TabIndex = 8;
            this.btconfiguraremail.Text = "Configurar email";
            this.btconfiguraremail.UseVisualStyleBackColor = true;
            this.btconfiguraremail.Click += new System.EventHandler(this.btconfiguraremail_Click);
            // 
            // btsair
            // 
            this.btsair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btsair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsair.Location = new System.Drawing.Point(12, 105);
            this.btsair.Name = "btsair";
            this.btsair.Size = new System.Drawing.Size(328, 38);
            this.btsair.TabIndex = 9;
            this.btsair.Text = "Sair";
            this.btsair.UseVisualStyleBackColor = true;
            this.btsair.Click += new System.EventHandler(this.btsair_Click);
            // 
            // frmmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(352, 155);
            this.Controls.Add(this.btsair);
            this.Controls.Add(this.btconfiguraremail);
            this.Controls.Add(this.btenviaremail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmmenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btenviaremail;
        private System.Windows.Forms.Button btconfiguraremail;
        private System.Windows.Forms.Button btsair;
    }
}
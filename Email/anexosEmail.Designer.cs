
namespace Email
{
    partial class anexosEmail
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtcaminho = new System.Windows.Forms.TextBox();
            this.btnselecionarimagem = new System.Windows.Forms.Button();
            this.btremove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtcaminho
            // 
            this.txtcaminho.Location = new System.Drawing.Point(3, 7);
            this.txtcaminho.Name = "txtcaminho";
            this.txtcaminho.Size = new System.Drawing.Size(304, 20);
            this.txtcaminho.TabIndex = 0;
            // 
            // btnselecionarimagem
            // 
            this.btnselecionarimagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnselecionarimagem.Location = new System.Drawing.Point(313, 5);
            this.btnselecionarimagem.Name = "btnselecionarimagem";
            this.btnselecionarimagem.Size = new System.Drawing.Size(75, 22);
            this.btnselecionarimagem.TabIndex = 1;
            this.btnselecionarimagem.Text = "selecionar";
            this.btnselecionarimagem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnselecionarimagem.UseVisualStyleBackColor = true;
            this.btnselecionarimagem.Click += new System.EventHandler(this.btnselecionarimagem_Click);
            // 
            // btremove
            // 
            this.btremove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btremove.Location = new System.Drawing.Point(394, 5);
            this.btremove.Name = "btremove";
            this.btremove.Size = new System.Drawing.Size(49, 22);
            this.btremove.TabIndex = 2;
            this.btremove.Text = "X";
            this.btremove.UseVisualStyleBackColor = true;
            this.btremove.Click += new System.EventHandler(this.btremove_Click);
            // 
            // anexosEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btremove);
            this.Controls.Add(this.btnselecionarimagem);
            this.Controls.Add(this.txtcaminho);
            this.Name = "anexosEmail";
            this.Size = new System.Drawing.Size(446, 33);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcaminho;
        private System.Windows.Forms.Button btnselecionarimagem;
        private System.Windows.Forms.Button btremove;
    }
}

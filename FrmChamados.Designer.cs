namespace WinFormsApp
{
    partial class FrmChamados
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
            crownGroupBox1 = new ReaLTaiizor.Controls.CrownGroupBox();
            btnVoltar = new ReaLTaiizor.Controls.CrownButton();
            crownGroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // crownGroupBox1
            // 
            crownGroupBox1.BorderColor = Color.FromArgb(51, 51, 51);
            crownGroupBox1.Controls.Add(btnVoltar);
            crownGroupBox1.Location = new Point(12, 12);
            crownGroupBox1.Name = "crownGroupBox1";
            crownGroupBox1.Size = new Size(605, 426);
            crownGroupBox1.TabIndex = 0;
            crownGroupBox1.TabStop = false;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(112, 99);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Padding = new Padding(5);
            btnVoltar.Size = new Size(400, 225);
            btnVoltar.TabIndex = 1;
            btnVoltar.Text = "Voltar";
            btnVoltar.Click += btnVoltar_Click;
            // 
            // FrmChamados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(629, 450);
            Controls.Add(crownGroupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmChamados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmChamados";
            crownGroupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.CrownGroupBox crownGroupBox1;
        private ReaLTaiizor.Controls.CrownButton btnVoltar;
    }
}
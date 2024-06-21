namespace WinFormsApp
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            crownGroupBox1 = new ReaLTaiizor.Controls.CrownGroupBox();
            btnFechar = new ReaLTaiizor.Controls.CrownButton();
            btnChamados = new ReaLTaiizor.Controls.CrownButton();
            btnUsuarios = new ReaLTaiizor.Controls.CrownButton();
            crownGroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // crownGroupBox1
            // 
            crownGroupBox1.BorderColor = Color.FromArgb(51, 51, 51);
            crownGroupBox1.Controls.Add(btnFechar);
            crownGroupBox1.Controls.Add(btnChamados);
            crownGroupBox1.Controls.Add(btnUsuarios);
            crownGroupBox1.Location = new Point(12, 12);
            crownGroupBox1.Name = "crownGroupBox1";
            crownGroupBox1.Size = new Size(605, 426);
            crownGroupBox1.TabIndex = 0;
            crownGroupBox1.TabStop = false;
            // 
            // btnFechar
            // 
            btnFechar.AccessibleDescription = "btnFechar";
            btnFechar.Location = new Point(247, 351);
            btnFechar.Name = "btnFechar";
            btnFechar.Padding = new Padding(5);
            btnFechar.Size = new Size(110, 45);
            btnFechar.TabIndex = 2;
            btnFechar.Text = "Sair";
            btnFechar.Click += btnFechar_Click;
            // 
            // btnChamados
            // 
            btnChamados.AccessibleDescription = "btnChamados";
            btnChamados.AccessibleName = "btnChamados";
            btnChamados.Location = new Point(357, 100);
            btnChamados.Name = "btnChamados";
            btnChamados.Padding = new Padding(5);
            btnChamados.Size = new Size(174, 121);
            btnChamados.TabIndex = 1;
            btnChamados.Text = "Chamados";
            btnChamados.Click += btnChamados_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.AccessibleDescription = "btnUsuarios";
            btnUsuarios.AccessibleName = "btnUsuarios";
            btnUsuarios.Location = new Point(74, 100);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Padding = new Padding(5);
            btnUsuarios.Size = new Size(174, 121);
            btnUsuarios.TabIndex = 0;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(629, 450);
            Controls.Add(crownGroupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPrincipal";
            crownGroupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.CrownGroupBox crownGroupBox1;
        private ReaLTaiizor.Controls.CrownButton btnChamados;
        private ReaLTaiizor.Controls.CrownButton btnUsuarios;
        private ReaLTaiizor.Controls.CrownButton btnFechar;
    }
}

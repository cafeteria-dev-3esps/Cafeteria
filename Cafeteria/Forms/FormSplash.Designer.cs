namespace Cafeteria.Forms
{
    partial class FormSplash
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblIcone = new Label();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            pnlBarraFundo = new Panel();
            pnlBarraProgresso = new Panel();
            lblStatus = new Label();
            lblVersao = new Label();
            timerCarregamento = new System.Windows.Forms.Timer(components);
            pnlBarraFundo.SuspendLayout();
            SuspendLayout();
            //
            // lblIcone
            //
            lblIcone.Font = new Font("Segoe UI Symbol", 42F, FontStyle.Regular, GraphicsUnit.Point);
            lblIcone.ForeColor = Color.FromArgb(198, 134, 66);
            lblIcone.Location = new Point(0, 25);
            lblIcone.Name = "lblIcone";
            lblIcone.Size = new Size(580, 85);
            lblIcone.TabIndex = 0;
            lblIcone.Text = "☕";
            lblIcone.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblTitulo
            //
            lblTitulo.Font = new Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.FromArgb(245, 235, 224);
            lblTitulo.Location = new Point(0, 110);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(580, 55);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Cafeteria Dev";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblSubtitulo
            //
            lblSubtitulo.Font = new Font("Segoe UI", 11F, FontStyle.Italic, GraphicsUnit.Point);
            lblSubtitulo.ForeColor = Color.FromArgb(198, 134, 66);
            lblSubtitulo.Location = new Point(0, 165);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(580, 25);
            lblSubtitulo.TabIndex = 2;
            lblSubtitulo.Text = "Código bem passado, café bem tirado.";
            lblSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
            //
            // pnlBarraFundo
            //
            pnlBarraFundo.BackColor = Color.FromArgb(109, 76, 65);
            pnlBarraFundo.Controls.Add(pnlBarraProgresso);
            pnlBarraFundo.Location = new Point(60, 235);
            pnlBarraFundo.Name = "pnlBarraFundo";
            pnlBarraFundo.Size = new Size(460, 10);
            pnlBarraFundo.TabIndex = 3;
            //
            // pnlBarraProgresso
            //
            pnlBarraProgresso.BackColor = Color.FromArgb(198, 134, 66);
            pnlBarraProgresso.Location = new Point(0, 0);
            pnlBarraProgresso.Name = "pnlBarraProgresso";
            pnlBarraProgresso.Size = new Size(0, 10);
            pnlBarraProgresso.TabIndex = 0;
            //
            // lblStatus
            //
            lblStatus.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatus.ForeColor = Color.FromArgb(245, 235, 224);
            lblStatus.Location = new Point(60, 252);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(460, 25);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Iniciando...";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblVersao
            //
            lblVersao.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblVersao.ForeColor = Color.FromArgb(160, 140, 130);
            lblVersao.Location = new Point(0, 300);
            lblVersao.Name = "lblVersao";
            lblVersao.Size = new Size(580, 20);
            lblVersao.TabIndex = 5;
            lblVersao.Text = "v1.0.0  •  FIAP 3ESPS  •  C# Development";
            lblVersao.TextAlign = ContentAlignment.MiddleCenter;
            //
            // timerCarregamento
            //
            timerCarregamento.Interval = 40;
            timerCarregamento.Tick += timerCarregamento_Tick;
            //
            // FormSplash
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(62, 39, 35);
            ClientSize = new Size(580, 330);
            Controls.Add(lblVersao);
            Controls.Add(lblStatus);
            Controls.Add(pnlBarraFundo);
            Controls.Add(lblSubtitulo);
            Controls.Add(lblTitulo);
            Controls.Add(lblIcone);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormSplash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cafeteria Dev";
            pnlBarraFundo.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblIcone;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private Panel pnlBarraFundo;
        private Panel pnlBarraProgresso;
        private Label lblStatus;
        private Label lblVersao;
        private System.Windows.Forms.Timer timerCarregamento;
    }
}

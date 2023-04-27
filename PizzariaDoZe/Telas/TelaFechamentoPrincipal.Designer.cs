namespace PizzariaDoZe.Telas
{
    partial class TelaFechamentoPrincipal
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
            LabelFechamentoPrincipal = new Label();
            btnContinuar = new Button();
            btnSair = new Button();
            btnEnviarParaBandeija = new Button();
            SuspendLayout();
            // 
            // LabelFechamentoPrincipal
            // 
            LabelFechamentoPrincipal.AutoSize = true;
            LabelFechamentoPrincipal.BackColor = Color.Transparent;
            LabelFechamentoPrincipal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LabelFechamentoPrincipal.ForeColor = SystemColors.ActiveCaptionText;
            LabelFechamentoPrincipal.Location = new Point(115, 48);
            LabelFechamentoPrincipal.Name = "LabelFechamentoPrincipal";
            LabelFechamentoPrincipal.Size = new Size(217, 56);
            LabelFechamentoPrincipal.TabIndex = 1;
            LabelFechamentoPrincipal.Text = "Tem certeza que deseja \r\nfechar essa tela?";
            LabelFechamentoPrincipal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnContinuar
            // 
            btnContinuar.DialogResult = DialogResult.OK;
            btnContinuar.Location = new Point(44, 150);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(113, 64);
            btnContinuar.TabIndex = 2;
            btnContinuar.Text = "Continuar";
            btnContinuar.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            btnSair.DialogResult = DialogResult.Cancel;
            btnSair.Location = new Point(170, 150);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(113, 64);
            btnSair.TabIndex = 3;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            // 
            // btnEnviarParaBandeija
            // 
            btnEnviarParaBandeija.DialogResult = DialogResult.Yes;
            btnEnviarParaBandeija.Location = new Point(296, 150);
            btnEnviarParaBandeija.Name = "btnEnviarParaBandeija";
            btnEnviarParaBandeija.Size = new Size(113, 64);
            btnEnviarParaBandeija.TabIndex = 4;
            btnEnviarParaBandeija.Text = "Enviar para a bandeija";
            btnEnviarParaBandeija.UseVisualStyleBackColor = true;
            // 
            // TelaFechamentoPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 241);
            Controls.Add(btnEnviarParaBandeija);
            Controls.Add(btnSair);
            Controls.Add(btnContinuar);
            Controls.Add(LabelFechamentoPrincipal);
            Name = "TelaFechamentoPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaFechamentoPrincipal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelFechamentoPrincipal;
        private Button btnContinuar;
        private Button btnSair;
        private Button btnEnviarParaBandeija;
    }
}
namespace PizzariaDoZe.Telas
{
    partial class TelaDeFechamento
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
            LabelFechamento = new Label();
            btnSim = new Button();
            btnNao = new Button();
            SuspendLayout();
            // 
            // LabelFechamento
            // 
            LabelFechamento.AutoSize = true;
            LabelFechamento.BackColor = Color.Transparent;
            LabelFechamento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LabelFechamento.ForeColor = SystemColors.ActiveCaptionText;
            LabelFechamento.Location = new Point(54, 33);
            LabelFechamento.Name = "LabelFechamento";
            LabelFechamento.Size = new Size(217, 56);
            LabelFechamento.TabIndex = 0;
            LabelFechamento.Text = "Tem certeza que deseja \r\nfechar essa tela?";
            LabelFechamento.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSim
            // 
            btnSim.DialogResult = DialogResult.OK;
            btnSim.Location = new Point(33, 117);
            btnSim.Name = "btnSim";
            btnSim.Size = new Size(101, 39);
            btnSim.TabIndex = 0;
            btnSim.Text = "Sim";
            btnSim.UseVisualStyleBackColor = true;
            // 
            // btnNao
            // 
            btnNao.DialogResult = DialogResult.Cancel;
            btnNao.Location = new Point(195, 117);
            btnNao.Name = "btnNao";
            btnNao.Size = new Size(101, 39);
            btnNao.TabIndex = 1;
            btnNao.Text = "Não";
            btnNao.UseVisualStyleBackColor = true;
            // 
            // TelaDeFechamento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(319, 187);
            Controls.Add(btnNao);
            Controls.Add(btnSim);
            Controls.Add(LabelFechamento);
            ForeColor = SystemColors.ActiveCaptionText;
            KeyPreview = true;
            Name = "TelaDeFechamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaDeFechamento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelFechamento;
        private Button btnSim;
        private Button btnNao;
    }
}
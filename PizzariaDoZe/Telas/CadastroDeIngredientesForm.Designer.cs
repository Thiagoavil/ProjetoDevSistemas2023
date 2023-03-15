namespace PizzariaDoZe.Telas
{
    partial class CadastroDeIngredientesForm
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
            txtNome = new TextBox();
            labelNome = new Label();
            btnLimpar = new Button();
            btnSalvar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(88, 115);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(162, 23);
            txtNome.TabIndex = 9;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(42, 118);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(40, 15);
            labelNome.TabIndex = 8;
            labelNome.Text = "Nome";
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(115, 180);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(74, 51);
            btnLimpar.TabIndex = 34;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(220, 180);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(74, 51);
            btnSalvar.TabIndex = 33;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(10, 180);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(74, 51);
            btnCancelar.TabIndex = 32;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // CadastroDeIngredientesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(308, 254);
            Controls.Add(btnLimpar);
            Controls.Add(btnSalvar);
            Controls.Add(btnCancelar);
            Controls.Add(txtNome);
            Controls.Add(labelNome);
            Name = "CadastroDeIngredientesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaCadastroDeIngredientesForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private Label labelNome;
        private Button btnLimpar;
        private Button btnSalvar;
        private Button btnCancelar;
    }
}
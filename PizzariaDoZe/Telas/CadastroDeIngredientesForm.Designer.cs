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
            components = new System.ComponentModel.Container();
            txtNome = new TextBox();
            labelNome = new Label();
            btnLimpar = new Button();
            btnSalvar = new Button();
            btnCancelar = new Button();
            errorProviderIngredientes = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProviderIngredientes).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(101, 153);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(185, 27);
            txtNome.TabIndex = 0;
            txtNome.Validating += txtNome_Validating;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(48, 157);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(50, 20);
            labelNome.TabIndex = 8;
            labelNome.Text = "Nome";
            // 
            // btnLimpar
            // 
            btnLimpar.CausesValidation = false;
            btnLimpar.Location = new Point(131, 240);
            btnLimpar.Margin = new Padding(3, 4, 3, 4);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(85, 68);
            btnLimpar.TabIndex = 2;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(251, 240);
            btnSalvar.Margin = new Padding(3, 4, 3, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(85, 68);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += ButtonSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.CausesValidation = false;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(11, 240);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(85, 68);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // errorProviderIngredientes
            // 
            errorProviderIngredientes.ContainerControl = this;
            // 
            // CadastroDeIngredientesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(352, 339);
            Controls.Add(btnLimpar);
            Controls.Add(btnSalvar);
            Controls.Add(btnCancelar);
            Controls.Add(txtNome);
            Controls.Add(labelNome);
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "CadastroDeIngredientesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaCadastroDeIngredientesForm";
            FormClosing += CadastroDeIngredientesForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)errorProviderIngredientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private Label labelNome;
        private Button btnLimpar;
        private Button btnSalvar;
        private Button btnCancelar;
        public ErrorProvider errorProviderIngredientes;
    }
}
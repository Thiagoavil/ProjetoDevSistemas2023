namespace PizzariaDoZe.Telas
{
    partial class CadastroDeValorForm
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
            ListTamanho = new CheckedListBox();
            labelTamanho = new Label();
            labelValorTradicional = new Label();
            LabelValorEspecial = new Label();
            labelValorBorda = new Label();
            btnLimpar = new Button();
            btnSalvar = new Button();
            btnCancelar = new Button();
            maskedTextBoxValorTradicional = new MaskedTextBox();
            maskedTextBoxValorEspecial = new MaskedTextBox();
            maskedTextBoValorBorda = new MaskedTextBox();
            SuspendLayout();
            // 
            // ListTamanho
            // 
            ListTamanho.FormattingEnabled = true;
            ListTamanho.Items.AddRange(new object[] { "Pequeno", "Medio", "Grande", "Familia" });
            ListTamanho.Location = new Point(22, 32);
            ListTamanho.Name = "ListTamanho";
            ListTamanho.Size = new Size(129, 92);
            ListTamanho.TabIndex = 0;
            // 
            // labelTamanho
            // 
            labelTamanho.AutoSize = true;
            labelTamanho.Location = new Point(22, 9);
            labelTamanho.Name = "labelTamanho";
            labelTamanho.Size = new Size(69, 20);
            labelTamanho.TabIndex = 1;
            labelTamanho.Text = "Tamanho";
            // 
            // labelValorTradicional
            // 
            labelValorTradicional.AutoSize = true;
            labelValorTradicional.Location = new Point(22, 133);
            labelValorTradicional.Name = "labelValorTradicional";
            labelValorTradicional.Size = new Size(120, 20);
            labelValorTradicional.TabIndex = 2;
            labelValorTradicional.Text = "Valor Tradicional";
            // 
            // LabelValorEspecial
            // 
            LabelValorEspecial.AutoSize = true;
            LabelValorEspecial.Location = new Point(22, 198);
            LabelValorEspecial.Name = "LabelValorEspecial";
            LabelValorEspecial.Size = new Size(101, 20);
            LabelValorEspecial.TabIndex = 3;
            LabelValorEspecial.Text = "Valor Especial";
            // 
            // labelValorBorda
            // 
            labelValorBorda.AutoSize = true;
            labelValorBorda.Location = new Point(22, 263);
            labelValorBorda.Name = "labelValorBorda";
            labelValorBorda.Size = new Size(87, 20);
            labelValorBorda.TabIndex = 7;
            labelValorBorda.Text = "Valor Borda";
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(153, 352);
            btnLimpar.Margin = new Padding(3, 4, 3, 4);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(125, 76);
            btnLimpar.TabIndex = 4;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(295, 352);
            btnSalvar.Margin = new Padding(3, 4, 3, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(125, 76);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(11, 352);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(125, 76);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxValorTradicional
            // 
            maskedTextBoxValorTradicional.Location = new Point(22, 156);
            maskedTextBoxValorTradicional.Mask = "$000,00";
            maskedTextBoxValorTradicional.Name = "maskedTextBoxValorTradicional";
            maskedTextBoxValorTradicional.Size = new Size(125, 27);
            maskedTextBoxValorTradicional.TabIndex = 1;
            // 
            // maskedTextBoxValorEspecial
            // 
            maskedTextBoxValorEspecial.Location = new Point(22, 221);
            maskedTextBoxValorEspecial.Mask = "$000,00";
            maskedTextBoxValorEspecial.Name = "maskedTextBoxValorEspecial";
            maskedTextBoxValorEspecial.Size = new Size(125, 27);
            maskedTextBoxValorEspecial.TabIndex = 2;
            // 
            // maskedTextBoValorBorda
            // 
            maskedTextBoValorBorda.Location = new Point(22, 286);
            maskedTextBoValorBorda.Mask = "$000,00";
            maskedTextBoValorBorda.Name = "maskedTextBoValorBorda";
            maskedTextBoValorBorda.Size = new Size(125, 27);
            maskedTextBoValorBorda.TabIndex = 3;
            maskedTextBoValorBorda.MaskInputRejected += maskedTextBoValorBorda_MaskInputRejected;
            // 
            // CadastroDeValorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(447, 450);
            Controls.Add(maskedTextBoValorBorda);
            Controls.Add(maskedTextBoxValorEspecial);
            Controls.Add(maskedTextBoxValorTradicional);
            Controls.Add(btnLimpar);
            Controls.Add(btnSalvar);
            Controls.Add(btnCancelar);
            Controls.Add(labelValorBorda);
            Controls.Add(LabelValorEspecial);
            Controls.Add(labelValorTradicional);
            Controls.Add(labelTamanho);
            Controls.Add(ListTamanho);
            KeyPreview = true;
            Name = "CadastroDeValorForm";
            Text = "CadastroDeValores";
            FormClosing += CadastroDeValorForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox ListTamanho;
        private Label labelTamanho;
        private Label labelValorTradicional;
        private Label LabelValorEspecial;
        private Label labelValorBorda;
        private Button btnLimpar;
        private Button btnSalvar;
        private Button btnCancelar;
        private MaskedTextBox maskedTextBoxValorTradicional;
        private MaskedTextBox maskedTextBoxValorEspecial;
        private MaskedTextBox maskedTextBoValorBorda;
    }
}
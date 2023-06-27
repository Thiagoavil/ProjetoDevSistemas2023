namespace PizzariaDoZe.Telas
{
    partial class CadastroDePizzaForm
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
            labelBorda = new Label();
            comboBoxBorda = new ComboBox();
            labelSabores = new Label();
            checkedListBoxSabores = new CheckedListBox();
            labelTamanho = new Label();
            comboBox1 = new ComboBox();
            btnLimpar = new Button();
            btnSalvar = new Button();
            btnCancelar = new Button();
            maskedTextBoxValorTotal = new MaskedTextBox();
            labelValorTotal = new Label();
            SuspendLayout();
            // 
            // labelBorda
            // 
            labelBorda.AutoSize = true;
            labelBorda.Location = new Point(200, 21);
            labelBorda.Name = "labelBorda";
            labelBorda.Size = new Size(49, 20);
            labelBorda.TabIndex = 42;
            labelBorda.Text = "Borda";
            // 
            // comboBoxBorda
            // 
            comboBoxBorda.FormattingEnabled = true;
            comboBoxBorda.Items.AddRange(new object[] { "Não", "Catupiry", "Cheddar", "Requeijão", "Chocolate Branco", "Chocolate Preto" });
            comboBoxBorda.Location = new Point(200, 44);
            comboBoxBorda.Name = "comboBoxBorda";
            comboBoxBorda.Size = new Size(124, 28);
            comboBoxBorda.TabIndex = 41;
            // 
            // labelSabores
            // 
            labelSabores.AutoSize = true;
            labelSabores.Location = new Point(12, 100);
            labelSabores.Name = "labelSabores";
            labelSabores.Size = new Size(62, 20);
            labelSabores.TabIndex = 40;
            labelSabores.Text = "Sabores";
            // 
            // checkedListBoxSabores
            // 
            checkedListBoxSabores.FormattingEnabled = true;
            checkedListBoxSabores.Location = new Point(12, 123);
            checkedListBoxSabores.Name = "checkedListBoxSabores";
            checkedListBoxSabores.Size = new Size(192, 224);
            checkedListBoxSabores.TabIndex = 39;
            // 
            // labelTamanho
            // 
            labelTamanho.AutoSize = true;
            labelTamanho.Location = new Point(12, 21);
            labelTamanho.Name = "labelTamanho";
            labelTamanho.Size = new Size(128, 20);
            labelTamanho.TabIndex = 38;
            labelTamanho.Text = "Tamanho da Pizza";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Pequena", "Média", "Grande", "Familia " });
            comboBox1.Location = new Point(12, 44);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(124, 28);
            comboBox1.TabIndex = 37;
            // 
            // btnLimpar
            // 
            btnLimpar.CausesValidation = false;
            btnLimpar.Location = new Point(132, 369);
            btnLimpar.Margin = new Padding(3, 4, 3, 4);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(85, 68);
            btnLimpar.TabIndex = 44;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(252, 369);
            btnSalvar.Margin = new Padding(3, 4, 3, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(85, 68);
            btnSalvar.TabIndex = 45;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.CausesValidation = false;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(12, 369);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(85, 68);
            btnCancelar.TabIndex = 43;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxValorTotal
            // 
            maskedTextBoxValorTotal.Location = new Point(216, 320);
            maskedTextBoxValorTotal.Mask = "$000,00";
            maskedTextBoxValorTotal.Name = "maskedTextBoxValorTotal";
            maskedTextBoxValorTotal.Size = new Size(125, 27);
            maskedTextBoxValorTotal.TabIndex = 47;
            maskedTextBoxValorTotal.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // labelValorTotal
            // 
            labelValorTotal.AutoSize = true;
            labelValorTotal.Location = new Point(216, 297);
            labelValorTotal.Name = "labelValorTotal";
            labelValorTotal.Size = new Size(42, 20);
            labelValorTotal.TabIndex = 46;
            labelValorTotal.Text = "Total";
            // 
            // CadastroDePizzaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(367, 450);
            Controls.Add(maskedTextBoxValorTotal);
            Controls.Add(labelValorTotal);
            Controls.Add(btnLimpar);
            Controls.Add(btnSalvar);
            Controls.Add(btnCancelar);
            Controls.Add(labelBorda);
            Controls.Add(comboBoxBorda);
            Controls.Add(labelSabores);
            Controls.Add(checkedListBoxSabores);
            Controls.Add(labelTamanho);
            Controls.Add(comboBox1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "CadastroDePizzaForm";
            Text = "CadastroDePizzaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelBorda;
        private ComboBox comboBoxBorda;
        private Label labelSabores;
        private CheckedListBox checkedListBoxSabores;
        private Label labelTamanho;
        private ComboBox comboBox1;
        private Button btnLimpar;
        private Button btnSalvar;
        private Button btnCancelar;
        private MaskedTextBox maskedTextBoxValorTotal;
        private Label labelValorTotal;
    }
}
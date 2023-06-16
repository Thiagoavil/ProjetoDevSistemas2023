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
            labelTamanho = new Label();
            labelValor = new Label();
            labelValorBorda = new Label();
            btnLimpar = new Button();
            btnSalvar = new Button();
            btnCancelar = new Button();
            maskedTextBoxValor = new MaskedTextBox();
            maskedTextBoValorBorda = new MaskedTextBox();
            labelCategoria = new Label();
            listBoxTamanho = new ListBox();
            listBoxCategoria = new ListBox();
            SuspendLayout();
            // 
            // labelTamanho
            // 
            labelTamanho.AutoSize = true;
            labelTamanho.Location = new Point(22, 3);
            labelTamanho.Name = "labelTamanho";
            labelTamanho.Size = new Size(69, 20);
            labelTamanho.TabIndex = 1;
            labelTamanho.Text = "Tamanho";
            // 
            // labelValor
            // 
            labelValor.AutoSize = true;
            labelValor.Location = new Point(22, 133);
            labelValor.Name = "labelValor";
            labelValor.Size = new Size(43, 20);
            labelValor.TabIndex = 2;
            labelValor.Text = "Valor";
            // 
            // labelValorBorda
            // 
            labelValorBorda.AutoSize = true;
            labelValorBorda.Location = new Point(22, 212);
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
            btnSalvar.Click += btnSalvar_Click;
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
            // maskedTextBoxValor
            // 
            maskedTextBoxValor.Location = new Point(22, 156);
            maskedTextBoxValor.Mask = "$000,00";
            maskedTextBoxValor.Name = "maskedTextBoxValor";
            maskedTextBoxValor.Size = new Size(125, 27);
            maskedTextBoxValor.TabIndex = 1;
            maskedTextBoxValor.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskedTextBoValorBorda
            // 
            maskedTextBoValorBorda.Location = new Point(22, 235);
            maskedTextBoValorBorda.Mask = "$000,00";
            maskedTextBoValorBorda.Name = "maskedTextBoValorBorda";
            maskedTextBoValorBorda.Size = new Size(125, 27);
            maskedTextBoValorBorda.TabIndex = 3;
            maskedTextBoValorBorda.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            maskedTextBoValorBorda.MaskInputRejected += maskedTextBoValorBorda_MaskInputRejected;
            // 
            // labelCategoria
            // 
            labelCategoria.AutoSize = true;
            labelCategoria.Location = new Point(200, 3);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(74, 20);
            labelCategoria.TabIndex = 8;
            labelCategoria.Text = "Categoria";
            // 
            // listBoxTamanho
            // 
            listBoxTamanho.FormattingEnabled = true;
            listBoxTamanho.ItemHeight = 20;
            listBoxTamanho.Location = new Point(22, 26);
            listBoxTamanho.Name = "listBoxTamanho";
            listBoxTamanho.Size = new Size(150, 104);
            listBoxTamanho.TabIndex = 9;
            // 
            // listBoxCategoria
            // 
            listBoxCategoria.FormattingEnabled = true;
            listBoxCategoria.ItemHeight = 20;
            listBoxCategoria.Location = new Point(200, 26);
            listBoxCategoria.Name = "listBoxCategoria";
            listBoxCategoria.Size = new Size(150, 104);
            listBoxCategoria.TabIndex = 10;
            // 
            // CadastroDeValorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(447, 450);
            Controls.Add(listBoxCategoria);
            Controls.Add(listBoxTamanho);
            Controls.Add(labelCategoria);
            Controls.Add(maskedTextBoValorBorda);
            Controls.Add(maskedTextBoxValor);
            Controls.Add(btnLimpar);
            Controls.Add(btnSalvar);
            Controls.Add(btnCancelar);
            Controls.Add(labelValorBorda);
            Controls.Add(labelValor);
            Controls.Add(labelTamanho);
            KeyPreview = true;
            Name = "CadastroDeValorForm";
            Text = "Valores";
            FormClosing += CadastroDeValorForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelTamanho;
        private Label labelValor;
        private Label labelValorBorda;
        private Button btnLimpar;
        private Button btnSalvar;
        private Button btnCancelar;
        private MaskedTextBox maskedTextBoxValor;
        private MaskedTextBox maskedTextBoValorBorda;
        private Label labelCategoria;
        private ListBox listBoxTamanho;
        private ListBox listBoxCategoria;
    }
}
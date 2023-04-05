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
            txtValorTradicional = new TextBox();
            TxtValorEspecial = new TextBox();
            textBox1 = new TextBox();
            labelValorBorda = new Label();
            btnLimpar = new Button();
            btnSalvar = new Button();
            btnCancelar = new Button();
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
            // txtValorTradicional
            // 
            txtValorTradicional.Location = new Point(22, 156);
            txtValorTradicional.Name = "txtValorTradicional";
            txtValorTradicional.Size = new Size(125, 27);
            txtValorTradicional.TabIndex = 4;
            // 
            // TxtValorEspecial
            // 
            TxtValorEspecial.Location = new Point(22, 221);
            TxtValorEspecial.Name = "TxtValorEspecial";
            TxtValorEspecial.Size = new Size(125, 27);
            TxtValorEspecial.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(22, 286);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 6;
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
            btnLimpar.TabIndex = 40;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(295, 352);
            btnSalvar.Margin = new Padding(3, 4, 3, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(125, 76);
            btnSalvar.TabIndex = 39;
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
            btnCancelar.TabIndex = 38;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // CadastroDeValorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(447, 450);
            Controls.Add(btnLimpar);
            Controls.Add(btnSalvar);
            Controls.Add(btnCancelar);
            Controls.Add(labelValorBorda);
            Controls.Add(textBox1);
            Controls.Add(TxtValorEspecial);
            Controls.Add(txtValorTradicional);
            Controls.Add(LabelValorEspecial);
            Controls.Add(labelValorTradicional);
            Controls.Add(labelTamanho);
            Controls.Add(ListTamanho);
            Name = "CadastroDeValorForm";
            Text = "CadastroDeValores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox ListTamanho;
        private Label labelTamanho;
        private Label labelValorTradicional;
        private Label LabelValorEspecial;
        private TextBox txtValorTradicional;
        private TextBox TxtValorEspecial;
        private TextBox textBox1;
        private Label labelValorBorda;
        private Button btnLimpar;
        private Button btnSalvar;
        private Button btnCancelar;
    }
}
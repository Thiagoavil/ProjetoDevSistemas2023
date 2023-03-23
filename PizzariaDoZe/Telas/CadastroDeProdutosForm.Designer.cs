namespace PizzariaDoZe.Telas
{
    partial class CadastroDeProdutosForm
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
            LabelValor = new Label();
            txtValor = new TextBox();
            ListTipo = new ListBox();
            LabelTipo = new Label();
            LabelMl = new Label();
            listBox1 = new ListBox();
            btnLimpar = new Button();
            btnSalvar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(16, 41);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(185, 27);
            txtNome.TabIndex = 11;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(16, 17);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(50, 20);
            labelNome.TabIndex = 10;
            labelNome.Text = "Nome";
            // 
            // LabelValor
            // 
            LabelValor.AutoSize = true;
            LabelValor.Location = new Point(16, 103);
            LabelValor.Name = "LabelValor";
            LabelValor.Size = new Size(43, 20);
            LabelValor.TabIndex = 12;
            LabelValor.Text = "Valor";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(16, 127);
            txtValor.Margin = new Padding(3, 4, 3, 4);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(185, 27);
            txtValor.TabIndex = 13;
            // 
            // ListTipo
            // 
            ListTipo.FormattingEnabled = true;
            ListTipo.ItemHeight = 20;
            ListTipo.Items.AddRange(new object[] { "Refrigerante", "Cerveja", "Suco", "Agua", "Outros" });
            ListTipo.Location = new Point(18, 195);
            ListTipo.Name = "ListTipo";
            ListTipo.Size = new Size(160, 144);
            ListTipo.TabIndex = 14;
            // 
            // LabelTipo
            // 
            LabelTipo.AutoSize = true;
            LabelTipo.Location = new Point(18, 172);
            LabelTipo.Name = "LabelTipo";
            LabelTipo.Size = new Size(39, 20);
            LabelTipo.TabIndex = 15;
            LabelTipo.Text = "Tipo";
            // 
            // LabelMl
            // 
            LabelMl.AutoSize = true;
            LabelMl.Location = new Point(222, 172);
            LabelMl.Name = "LabelMl";
            LabelMl.Size = new Size(26, 20);
            LabelMl.TabIndex = 17;
            LabelMl.Text = "ml";
            LabelMl.Click += label1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Items.AddRange(new object[] { "150", "300", "600", "1000", "1500", "2000" });
            listBox1.Location = new Point(222, 195);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(160, 144);
            listBox1.TabIndex = 16;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(161, 368);
            btnLimpar.Margin = new Padding(3, 4, 3, 4);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(125, 76);
            btnLimpar.TabIndex = 37;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(303, 368);
            btnSalvar.Margin = new Padding(3, 4, 3, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(125, 76);
            btnSalvar.TabIndex = 36;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(19, 368);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(125, 76);
            btnCancelar.TabIndex = 35;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // CadastroDeProdutosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(473, 467);
            Controls.Add(btnLimpar);
            Controls.Add(btnSalvar);
            Controls.Add(btnCancelar);
            Controls.Add(LabelMl);
            Controls.Add(listBox1);
            Controls.Add(LabelTipo);
            Controls.Add(ListTipo);
            Controls.Add(txtValor);
            Controls.Add(LabelValor);
            Controls.Add(txtNome);
            Controls.Add(labelNome);
            Name = "CadastroDeProdutosForm";
            Text = "CadastroDeProdutosForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private Label labelNome;
        private Label LabelValor;
        private TextBox txtValor;
        private ListBox ListTipo;
        private Label LabelTipo;
        private Label LabelMl;
        private ListBox listBox1;
        private Button btnLimpar;
        private Button btnSalvar;
        private Button btnCancelar;
    }
}
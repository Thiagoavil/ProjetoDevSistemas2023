namespace PizzariaDoZe.Telas
{
    partial class CadastroDeSaboresForm
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
            labelCategoria = new Label();
            CbCategoria = new ComboBox();
            PBFotoPizza = new PictureBox();
            CheckListIngredientes = new CheckedListBox();
            labelIngredientes = new Label();
            CBTipo = new ComboBox();
            labelTipo = new Label();
            btnLimpar = new Button();
            btnSalvar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)PBFotoPizza).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(334, 23);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(161, 27);
            txtNome.TabIndex = 9;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(261, 27);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(50, 20);
            labelNome.TabIndex = 8;
            labelNome.Text = "Nome";
            // 
            // labelCategoria
            // 
            labelCategoria.AutoSize = true;
            labelCategoria.Location = new Point(261, 88);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(74, 20);
            labelCategoria.TabIndex = 10;
            labelCategoria.Text = "Categoria";
            // 
            // CbCategoria
            // 
            CbCategoria.FormattingEnabled = true;
            CbCategoria.Location = new Point(334, 84);
            CbCategoria.Margin = new Padding(3, 4, 3, 4);
            CbCategoria.Name = "CbCategoria";
            CbCategoria.Size = new Size(161, 28);
            CbCategoria.TabIndex = 11;
            CbCategoria.SelectedIndexChanged += CbCategoria_SelectedIndexChanged;
            // 
            // PBFotoPizza
            // 
            PBFotoPizza.Location = new Point(26, 16);
            PBFotoPizza.Margin = new Padding(3, 4, 3, 4);
            PBFotoPizza.Name = "PBFotoPizza";
            PBFotoPizza.Size = new Size(199, 175);
            PBFotoPizza.TabIndex = 12;
            PBFotoPizza.TabStop = false;
            // 
            // CheckListIngredientes
            // 
            CheckListIngredientes.FormattingEnabled = true;
            CheckListIngredientes.Location = new Point(26, 251);
            CheckListIngredientes.Margin = new Padding(3, 4, 3, 4);
            CheckListIngredientes.Name = "CheckListIngredientes";
            CheckListIngredientes.Size = new Size(198, 224);
            CheckListIngredientes.TabIndex = 13;
            // 
            // labelIngredientes
            // 
            labelIngredientes.AutoSize = true;
            labelIngredientes.Location = new Point(26, 212);
            labelIngredientes.Name = "labelIngredientes";
            labelIngredientes.Size = new Size(91, 20);
            labelIngredientes.TabIndex = 14;
            labelIngredientes.Text = "Ingredientes";
            // 
            // CBTipo
            // 
            CBTipo.FormattingEnabled = true;
            CBTipo.Location = new Point(334, 145);
            CBTipo.Margin = new Padding(3, 4, 3, 4);
            CBTipo.Name = "CBTipo";
            CBTipo.Size = new Size(161, 28);
            CBTipo.TabIndex = 16;
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Location = new Point(261, 149);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(39, 20);
            labelTipo.TabIndex = 15;
            labelTipo.Text = "Tipo";
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(261, 328);
            btnLimpar.Margin = new Padding(3, 4, 3, 4);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(125, 76);
            btnLimpar.TabIndex = 34;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(261, 420);
            btnSalvar.Margin = new Padding(3, 4, 3, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(125, 76);
            btnSalvar.TabIndex = 33;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(261, 236);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(125, 76);
            btnCancelar.TabIndex = 32;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // CadastroDeSaboresForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(557, 520);
            Controls.Add(btnLimpar);
            Controls.Add(btnSalvar);
            Controls.Add(btnCancelar);
            Controls.Add(CBTipo);
            Controls.Add(labelTipo);
            Controls.Add(labelIngredientes);
            Controls.Add(CheckListIngredientes);
            Controls.Add(PBFotoPizza);
            Controls.Add(CbCategoria);
            Controls.Add(labelCategoria);
            Controls.Add(txtNome);
            Controls.Add(labelNome);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CadastroDeSaboresForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadastroDeSaboresForm";
            ((System.ComponentModel.ISupportInitialize)PBFotoPizza).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private Label labelNome;
        private Label labelCategoria;
        private ComboBox CbCategoria;
        private PictureBox PBFotoPizza;
        private CheckedListBox CheckListIngredientes;
        private Label labelIngredientes;
        private ComboBox CBTipo;
        private Label labelTipo;
        private Button btnLimpar;
        private Button btnSalvar;
        private Button btnCancelar;
    }
}
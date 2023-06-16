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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroDeSaboresForm));
            txtNome = new TextBox();
            labelNome = new Label();
            labelCategoria = new Label();
            PBFotoPizza = new PictureBox();
            CheckListIngredientes = new CheckedListBox();
            labelIngredientes = new Label();
            labelTipo = new Label();
            btnLimpar = new Button();
            btnSalvar = new Button();
            btnCancelar = new Button();
            listBoxCategoria = new ListBox();
            listBoxTipo = new ListBox();
            ((System.ComponentModel.ISupportInitialize)PBFotoPizza).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(334, 23);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(161, 27);
            txtNome.TabIndex = 0;
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
            labelCategoria.Location = new Point(237, 84);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(74, 20);
            labelCategoria.TabIndex = 10;
            labelCategoria.Text = "Categoria";
            // 
            // PBFotoPizza
            // 
            PBFotoPizza.BackgroundImage = (Image)resources.GetObject("PBFotoPizza.BackgroundImage");
            PBFotoPizza.BackgroundImageLayout = ImageLayout.Center;
            PBFotoPizza.InitialImage = (Image)resources.GetObject("PBFotoPizza.InitialImage");
            PBFotoPizza.Location = new Point(26, 16);
            PBFotoPizza.Margin = new Padding(3, 4, 3, 4);
            PBFotoPizza.Name = "PBFotoPizza";
            PBFotoPizza.Size = new Size(199, 175);
            PBFotoPizza.TabIndex = 12;
            PBFotoPizza.TabStop = false;
            PBFotoPizza.UseWaitCursor = true;
            PBFotoPizza.Click += PBFotoPizza_Click;
            // 
            // CheckListIngredientes
            // 
            CheckListIngredientes.FormattingEnabled = true;
            CheckListIngredientes.Location = new Point(26, 251);
            CheckListIngredientes.Margin = new Padding(3, 4, 3, 4);
            CheckListIngredientes.Name = "CheckListIngredientes";
            CheckListIngredientes.Size = new Size(198, 224);
            CheckListIngredientes.TabIndex = 3;
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
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Location = new Point(406, 84);
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
            btnLimpar.TabIndex = 5;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(261, 420);
            btnSalvar.Margin = new Padding(3, 4, 3, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(125, 76);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(261, 236);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(125, 76);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // listBoxCategoria
            // 
            listBoxCategoria.FormattingEnabled = true;
            listBoxCategoria.ItemHeight = 20;
            listBoxCategoria.Location = new Point(237, 107);
            listBoxCategoria.Name = "listBoxCategoria";
            listBoxCategoria.Size = new Size(150, 104);
            listBoxCategoria.TabIndex = 16;
            // 
            // listBoxTipo
            // 
            listBoxTipo.FormattingEnabled = true;
            listBoxTipo.ItemHeight = 20;
            listBoxTipo.Location = new Point(406, 107);
            listBoxTipo.Name = "listBoxTipo";
            listBoxTipo.Size = new Size(150, 104);
            listBoxTipo.TabIndex = 17;
            // 
            // CadastroDeSaboresForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(557, 520);
            Controls.Add(listBoxTipo);
            Controls.Add(listBoxCategoria);
            Controls.Add(btnLimpar);
            Controls.Add(btnSalvar);
            Controls.Add(btnCancelar);
            Controls.Add(labelTipo);
            Controls.Add(labelIngredientes);
            Controls.Add(CheckListIngredientes);
            Controls.Add(PBFotoPizza);
            Controls.Add(labelCategoria);
            Controls.Add(txtNome);
            Controls.Add(labelNome);
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "CadastroDeSaboresForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sabores";
            FormClosing += CadastroDeSaboresForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)PBFotoPizza).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private Label labelNome;
        private Label labelCategoria;
        private PictureBox PBFotoPizza;
        private CheckedListBox CheckListIngredientes;
        private Label labelIngredientes;
        private Label labelTipo;
        private Button btnLimpar;
        private Button btnSalvar;
        private Button btnCancelar;
        private ListBox listBoxCategoria;
        private ListBox listBoxTipo;
    }
}
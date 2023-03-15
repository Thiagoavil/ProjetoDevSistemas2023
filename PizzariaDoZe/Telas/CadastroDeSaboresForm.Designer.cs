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
            label1 = new Label();
            CbCategoria = new ComboBox();
            PBFotoPizza = new PictureBox();
            CheckListIngredientes = new CheckedListBox();
            label2 = new Label();
            CBTipo = new ComboBox();
            label3 = new Label();
            btnLimpar = new Button();
            btnSalvar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)PBFotoPizza).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(292, 17);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(141, 23);
            txtNome.TabIndex = 9;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(228, 20);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(40, 15);
            labelNome.TabIndex = 8;
            labelNome.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(228, 66);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 10;
            label1.Text = "Categoria";
            // 
            // CbCategoria
            // 
            CbCategoria.FormattingEnabled = true;
            CbCategoria.Location = new Point(292, 63);
            CbCategoria.Name = "CbCategoria";
            CbCategoria.Size = new Size(141, 23);
            CbCategoria.TabIndex = 11;
            CbCategoria.SelectedIndexChanged += CbCategoria_SelectedIndexChanged;
            // 
            // PBFotoPizza
            // 
            PBFotoPizza.Location = new Point(23, 12);
            PBFotoPizza.Name = "PBFotoPizza";
            PBFotoPizza.Size = new Size(174, 131);
            PBFotoPizza.TabIndex = 12;
            PBFotoPizza.TabStop = false;
            // 
            // CheckListIngredientes
            // 
            CheckListIngredientes.FormattingEnabled = true;
            CheckListIngredientes.Location = new Point(23, 188);
            CheckListIngredientes.Name = "CheckListIngredientes";
            CheckListIngredientes.Size = new Size(174, 184);
            CheckListIngredientes.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 159);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 14;
            label2.Text = "Ingredientes";
            // 
            // CBTipo
            // 
            CBTipo.FormattingEnabled = true;
            CBTipo.Location = new Point(292, 109);
            CBTipo.Name = "CBTipo";
            CBTipo.Size = new Size(141, 23);
            CBTipo.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(228, 112);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 15;
            label3.Text = "Tipo";
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(228, 246);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(109, 57);
            btnLimpar.TabIndex = 34;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(228, 315);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(109, 57);
            btnSalvar.TabIndex = 33;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(228, 177);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(109, 57);
            btnCancelar.TabIndex = 32;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // CadastroDeSaboresForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(487, 390);
            Controls.Add(btnLimpar);
            Controls.Add(btnSalvar);
            Controls.Add(btnCancelar);
            Controls.Add(CBTipo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(CheckListIngredientes);
            Controls.Add(PBFotoPizza);
            Controls.Add(CbCategoria);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Controls.Add(labelNome);
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
        private Label label1;
        private ComboBox CbCategoria;
        private PictureBox PBFotoPizza;
        private CheckedListBox CheckListIngredientes;
        private Label label2;
        private ComboBox CBTipo;
        private Label label3;
        private Button btnLimpar;
        private Button btnSalvar;
        private Button btnCancelar;
    }
}
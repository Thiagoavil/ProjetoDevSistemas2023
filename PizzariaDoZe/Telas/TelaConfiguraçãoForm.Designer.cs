namespace PizzariaDoZe.Telas
{
    partial class TelaConfiguraçãoForm
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
            ConfiguracaoTab = new TabControl();
            IdiomaTab = new TabPage();
            Idioma = new GroupBox();
            comboBoxIdioma = new ComboBox();
            CheckBoxReinicio = new CheckBox();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            ConfiguracaoTab.SuspendLayout();
            IdiomaTab.SuspendLayout();
            Idioma.SuspendLayout();
            SuspendLayout();
            // 
            // ConfiguracaoTab
            // 
            ConfiguracaoTab.Controls.Add(IdiomaTab);
            ConfiguracaoTab.Location = new Point(10, 35);
            ConfiguracaoTab.Name = "ConfiguracaoTab";
            ConfiguracaoTab.SelectedIndex = 0;
            ConfiguracaoTab.Size = new Size(775, 289);
            ConfiguracaoTab.TabIndex = 0;
            // 
            // IdiomaTab
            // 
            IdiomaTab.Controls.Add(Idioma);
            IdiomaTab.Location = new Point(4, 29);
            IdiomaTab.Name = "IdiomaTab";
            IdiomaTab.Padding = new Padding(3);
            IdiomaTab.Size = new Size(767, 256);
            IdiomaTab.TabIndex = 0;
            IdiomaTab.Text = "Idioma/Região";
            IdiomaTab.UseVisualStyleBackColor = true;
            // 
            // Idioma
            // 
            Idioma.Controls.Add(CheckBoxReinicio);
            Idioma.Controls.Add(comboBoxIdioma);
            Idioma.Location = new Point(17, 28);
            Idioma.Name = "Idioma";
            Idioma.Size = new Size(530, 96);
            Idioma.TabIndex = 0;
            Idioma.TabStop = false;
            Idioma.Text = "Idioma/Região";
            // 
            // comboBoxIdioma
            // 
            comboBoxIdioma.FormattingEnabled = true;
            comboBoxIdioma.Items.AddRange(new object[] { "pt-BR", "en-US", "es" });
            comboBoxIdioma.Location = new Point(16, 26);
            comboBoxIdioma.Name = "comboBoxIdioma";
            comboBoxIdioma.Size = new Size(151, 28);
            comboBoxIdioma.TabIndex = 0;
            // 
            // CheckBoxReinicio
            // 
            CheckBoxReinicio.AutoSize = true;
            CheckBoxReinicio.Location = new Point(210, 30);
            CheckBoxReinicio.Name = "CheckBoxReinicio";
            CheckBoxReinicio.Size = new Size(242, 24);
            CheckBoxReinicio.TabIndex = 1;
            CheckBoxReinicio.Text = "Reiniciar para aplicar o idioma?";
            CheckBoxReinicio.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(160, 348);
            btnConfirmar.Margin = new Padding(3, 4, 3, 4);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(125, 76);
            btnConfirmar.TabIndex = 40;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(29, 348);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(125, 76);
            btnCancelar.TabIndex = 41;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaConfiguraçãoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(ConfiguracaoTab);
            Name = "TelaConfiguraçãoForm";
            Text = "TelaConfiguraçãoForm";
            ConfiguracaoTab.ResumeLayout(false);
            IdiomaTab.ResumeLayout(false);
            Idioma.ResumeLayout(false);
            Idioma.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl ConfiguracaoTab;
        private TabPage IdiomaTab;
        private GroupBox Idioma;
        private CheckBox CheckBoxReinicio;
        private ComboBox comboBoxIdioma;
        private Button btnConfirmar;
        private Button btnCancelar;
    }
}
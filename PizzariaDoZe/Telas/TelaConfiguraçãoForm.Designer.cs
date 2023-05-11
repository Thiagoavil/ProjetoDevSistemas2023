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
            BtnCancelarIdioma = new Button();
            BtnConfirmarIdioma = new Button();
            IdiomaGroup = new GroupBox();
            CheckBoxReinicio = new CheckBox();
            comboBoxIdioma = new ComboBox();
            BancoDadosTab = new TabPage();
            btnCancelarBancoDados = new Button();
            groupBoxBancoDados = new GroupBox();
            textBoxStringConnection = new TextBox();
            labelStringConnection = new Label();
            LabelProvider = new Label();
            comboBoxProvider = new ComboBox();
            btnConfirmarBancoDados = new Button();
            ConfiguracaoTab.SuspendLayout();
            IdiomaTab.SuspendLayout();
            IdiomaGroup.SuspendLayout();
            BancoDadosTab.SuspendLayout();
            groupBoxBancoDados.SuspendLayout();
            SuspendLayout();
            // 
            // ConfiguracaoTab
            // 
            ConfiguracaoTab.Controls.Add(IdiomaTab);
            ConfiguracaoTab.Controls.Add(BancoDadosTab);
            ConfiguracaoTab.Location = new Point(10, 35);
            ConfiguracaoTab.Name = "ConfiguracaoTab";
            ConfiguracaoTab.SelectedIndex = 0;
            ConfiguracaoTab.Size = new Size(775, 389);
            ConfiguracaoTab.TabIndex = 0;
            // 
            // IdiomaTab
            // 
            IdiomaTab.Controls.Add(BtnCancelarIdioma);
            IdiomaTab.Controls.Add(BtnConfirmarIdioma);
            IdiomaTab.Controls.Add(IdiomaGroup);
            IdiomaTab.Location = new Point(4, 29);
            IdiomaTab.Name = "IdiomaTab";
            IdiomaTab.Padding = new Padding(3);
            IdiomaTab.Size = new Size(767, 356);
            IdiomaTab.TabIndex = 0;
            IdiomaTab.Text = "Idioma/Região";
            IdiomaTab.UseVisualStyleBackColor = true;
            // 
            // BtnCancelarIdioma
            // 
            BtnCancelarIdioma.DialogResult = DialogResult.Cancel;
            BtnCancelarIdioma.Location = new Point(17, 255);
            BtnCancelarIdioma.Margin = new Padding(3, 4, 3, 4);
            BtnCancelarIdioma.Name = "BtnCancelarIdioma";
            BtnCancelarIdioma.Size = new Size(125, 76);
            BtnCancelarIdioma.TabIndex = 5;
            BtnCancelarIdioma.Text = "Cancelar";
            BtnCancelarIdioma.UseVisualStyleBackColor = true;
            // 
            // BtnConfirmarIdioma
            // 
            BtnConfirmarIdioma.Location = new Point(148, 255);
            BtnConfirmarIdioma.Margin = new Padding(3, 4, 3, 4);
            BtnConfirmarIdioma.Name = "BtnConfirmarIdioma";
            BtnConfirmarIdioma.Size = new Size(125, 76);
            BtnConfirmarIdioma.TabIndex = 6;
            BtnConfirmarIdioma.Text = "Confirmar";
            BtnConfirmarIdioma.UseVisualStyleBackColor = true;
            BtnConfirmarIdioma.Click += BtnConfirmarIdioma_Click;
            // 
            // IdiomaGroup
            // 
            IdiomaGroup.Controls.Add(CheckBoxReinicio);
            IdiomaGroup.Controls.Add(comboBoxIdioma);
            IdiomaGroup.Location = new Point(17, 93);
            IdiomaGroup.Name = "IdiomaGroup";
            IdiomaGroup.Size = new Size(530, 96);
            IdiomaGroup.TabIndex = 0;
            IdiomaGroup.TabStop = false;
            IdiomaGroup.Text = "Idioma/Região";
            // 
            // CheckBoxReinicio
            // 
            CheckBoxReinicio.AutoSize = true;
            CheckBoxReinicio.Location = new Point(210, 30);
            CheckBoxReinicio.Name = "CheckBoxReinicio";
            CheckBoxReinicio.Size = new Size(242, 24);
            CheckBoxReinicio.TabIndex = 2;
            CheckBoxReinicio.Text = "Reiniciar para aplicar o idioma?";
            CheckBoxReinicio.UseVisualStyleBackColor = true;
            // 
            // comboBoxIdioma
            // 
            comboBoxIdioma.FormattingEnabled = true;
            comboBoxIdioma.Items.AddRange(new object[] { "pt-BR", "en-US", "es" });
            comboBoxIdioma.Location = new Point(16, 26);
            comboBoxIdioma.Name = "comboBoxIdioma";
            comboBoxIdioma.Size = new Size(151, 28);
            comboBoxIdioma.TabIndex = 1;
            // 
            // BancoDadosTab
            // 
            BancoDadosTab.Controls.Add(btnCancelarBancoDados);
            BancoDadosTab.Controls.Add(groupBoxBancoDados);
            BancoDadosTab.Controls.Add(btnConfirmarBancoDados);
            BancoDadosTab.Location = new Point(4, 29);
            BancoDadosTab.Name = "BancoDadosTab";
            BancoDadosTab.Size = new Size(767, 356);
            BancoDadosTab.TabIndex = 1;
            BancoDadosTab.Text = "Banco de Dados";
            BancoDadosTab.UseVisualStyleBackColor = true;
            // 
            // btnCancelarBancoDados
            // 
            btnCancelarBancoDados.DialogResult = DialogResult.Cancel;
            btnCancelarBancoDados.Location = new Point(15, 254);
            btnCancelarBancoDados.Margin = new Padding(3, 4, 3, 4);
            btnCancelarBancoDados.Name = "btnCancelarBancoDados";
            btnCancelarBancoDados.Size = new Size(125, 76);
            btnCancelarBancoDados.TabIndex = 3;
            btnCancelarBancoDados.Text = "Cancelar";
            btnCancelarBancoDados.UseVisualStyleBackColor = true;
            // 
            // groupBoxBancoDados
            // 
            groupBoxBancoDados.Controls.Add(textBoxStringConnection);
            groupBoxBancoDados.Controls.Add(labelStringConnection);
            groupBoxBancoDados.Controls.Add(LabelProvider);
            groupBoxBancoDados.Controls.Add(comboBoxProvider);
            groupBoxBancoDados.Location = new Point(28, 30);
            groupBoxBancoDados.Name = "groupBoxBancoDados";
            groupBoxBancoDados.Size = new Size(617, 189);
            groupBoxBancoDados.TabIndex = 1;
            groupBoxBancoDados.TabStop = false;
            groupBoxBancoDados.Text = "Banco De Dados";
            // 
            // textBoxStringConnection
            // 
            textBoxStringConnection.Location = new Point(139, 116);
            textBoxStringConnection.Name = "textBoxStringConnection";
            textBoxStringConnection.Size = new Size(350, 27);
            textBoxStringConnection.TabIndex = 4;
            textBoxStringConnection.Text = "data source=(LocalDB)\\MSSqlLocalDB;";
            // 
            // labelStringConnection
            // 
            labelStringConnection.AutoSize = true;
            labelStringConnection.Location = new Point(6, 116);
            labelStringConnection.Name = "labelStringConnection";
            labelStringConnection.Size = new Size(127, 20);
            labelStringConnection.TabIndex = 3;
            labelStringConnection.Text = "String Connection";
            // 
            // LabelProvider
            // 
            LabelProvider.AutoSize = true;
            LabelProvider.Location = new Point(69, 32);
            LabelProvider.Name = "LabelProvider";
            LabelProvider.Size = new Size(64, 20);
            LabelProvider.TabIndex = 2;
            LabelProvider.Text = "Provider";
            // 
            // comboBoxProvider
            // 
            comboBoxProvider.FormattingEnabled = true;
            comboBoxProvider.Items.AddRange(new object[] { "pt-BR", "en-US", "es" });
            comboBoxProvider.Location = new Point(139, 29);
            comboBoxProvider.Name = "comboBoxProvider";
            comboBoxProvider.Size = new Size(198, 28);
            comboBoxProvider.TabIndex = 1;
            // 
            // btnConfirmarBancoDados
            // 
            btnConfirmarBancoDados.Location = new Point(146, 254);
            btnConfirmarBancoDados.Margin = new Padding(3, 4, 3, 4);
            btnConfirmarBancoDados.Name = "btnConfirmarBancoDados";
            btnConfirmarBancoDados.Size = new Size(125, 76);
            btnConfirmarBancoDados.TabIndex = 4;
            btnConfirmarBancoDados.Text = "Confirmar";
            btnConfirmarBancoDados.UseVisualStyleBackColor = true;
            btnConfirmarBancoDados.Click += btnConfirmar_Click;
            // 
            // TelaConfiguraçãoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(800, 450);
            Controls.Add(ConfiguracaoTab);
            KeyPreview = true;
            Name = "TelaConfiguraçãoForm";
            Text = "TelaConfiguraçãoForm";
            FormClosing += TelaConfiguraçãoForm_FormClosing;
            ConfiguracaoTab.ResumeLayout(false);
            IdiomaTab.ResumeLayout(false);
            IdiomaGroup.ResumeLayout(false);
            IdiomaGroup.PerformLayout();
            BancoDadosTab.ResumeLayout(false);
            groupBoxBancoDados.ResumeLayout(false);
            groupBoxBancoDados.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl ConfiguracaoTab;
        private TabPage IdiomaTab;
        private GroupBox IdiomaGroup;
        private CheckBox CheckBoxReinicio;
        private ComboBox comboBoxIdioma;
        private Button btnConfirmarBancoDados;
        private Button btnCancelarBancoDados;
        private TabPage BancoDadosTab;
        private GroupBox groupBoxBancoDados;
        private TextBox textBoxStringConnection;
        private Label labelStringConnection;
        private Label LabelProvider;
        private ComboBox comboBoxProvider;
        private Button BtnCancelarIdioma;
        private Button BtnConfirmarIdioma;
    }
}
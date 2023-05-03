using PizzariaDoZe.Properties;

namespace PizzariaDoZe.Telas
{
    public partial class TelaPrincipalForm : Form
    {
        public TelaPrincipalForm()
        {
            InitializeComponent();
            #region idioma/região interface - satellite assembly
            // com base no idioma/região escolhido pelo usuário,
            // ajusta as propriedades dos componentes da tela com base no conteúdo do arquivo
            //resources
            Funcoes.AjustaResourcesControl(this);
            //ajuste manual de campos ou mensagens para o usuário que não puderam ser
            //automatizadas acima
            this.Text = Properties.Resources.ResourceManager.GetString("txtTituloPrincipal");
            #endregion
            #region configuração idioma - MenuStrip 
            Funcoes.AjustaResourcesItem(contextMenuStripPrincipal);
            #endregion
            #region Configuração De Botões no Foco
            //adiciona eventos em geral, exemplo: ganhar e perder o foco
            Funcoes.EventoFocoCampos(this);
            #endregion
            #region Enter Como Tab
            //Evento em Funcoes que congifura a tecla enter como o tab
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown);
            #endregion
            #region Configuração MenuStrip
            //inicioToolStripMenuItem.Click += new EventHandler(bt!);
            ClienteStripMenuItem.Click += new EventHandler(btnCadastrarCliente_Click!);
            funcionariosToolStripMenuItem.Click += new EventHandler(btnCadastroDeFuncionarios_Click!);
            saboresToolStripMenuItem.Click += new EventHandler(btnCadastroDeSabores_Click!);
            ingredientesToolStripMenuItem.Click += new EventHandler(btnCadastroDeIngredientes_Click!);
            valoresToolStripMenuItem.Click += new EventHandler(btnCadastroValores_Click!);
            produtosToolStripMenuItem.Click += new EventHandler(btnCadastrarProduto_Click!);
            configuraçõesToolStripMenuItem.Click += new EventHandler(ConfiguraçõesBtn_Click!);
            //sairToolStripMenuItem.Click += new EventHandler(TelaPrincipalForm_FormClosing!);
            #endregion
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            CadastroDeClientesForm TelaCadastroCliente = new CadastroDeClientesForm();
            TelaCadastroCliente.ShowDialog();
        }

        private void btnCadastroDeFuncionarios_Click(object sender, EventArgs e)
        {
            CadastroDeFuncionariosForm TelaCadastroFuncionario = new CadastroDeFuncionariosForm();
            TelaCadastroFuncionario.ShowDialog();
        }

        private void btnCadastroDeSabores_Click(object sender, EventArgs e)
        {
            CadastroDeSaboresForm TelaCadastroFuncionario = new CadastroDeSaboresForm();
            TelaCadastroFuncionario.ShowDialog();
        }

        private void btnCadastroDeIngredientes_Click(object sender, EventArgs e)
        {
            CadastroDeIngredientesForm TelaCadastroIngrediente = new CadastroDeIngredientesForm();
            TelaCadastroIngrediente.ShowDialog();
        }

        private void btnCadastroValores_Click(object sender, EventArgs e)
        {
            CadastroDeValorForm TelaCadastroValores = new CadastroDeValorForm();
            TelaCadastroValores.ShowDialog();
        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            CadastroDeProdutosForm TelaCadastroProduto = new CadastroDeProdutosForm();
            TelaCadastroProduto.ShowDialog();
        }

        private void ConfiguraçõesBtn_Click(object sender, EventArgs e)
        {
            TelaConfiguraçãoForm telaConfiguração = new TelaConfiguraçãoForm();
            telaConfiguração.ShowDialog();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            notifyIconSystemTray.Visible = false;
        }

        private void TelaPrincipalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                TelaFechamentoPrincipal telaFechamento = new TelaFechamentoPrincipal();
                DialogResult resultado = telaFechamento.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    e.Cancel = true;
                }
                else if (resultado == DialogResult.Cancel)
                {

                }
                else if (resultado == DialogResult.Yes)
                {
                    e.Cancel = true;
                    this.WindowState = FormWindowState.Minimized;
                    notifyIconSystemTray.ShowBalloonTip(1000);
                }
            }

        }

        private void TelaPrincipalForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIconSystemTray.Visible = true;
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIconSystemTray.Visible = false;
                notifyIconSystemTray.ShowBalloonTip(1000);
            }
        }

        private void abrirAplicaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void encerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
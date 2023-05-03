using PizzariaDoZe.Properties;

namespace PizzariaDoZe.Telas
{
    public partial class TelaPrincipalForm : Form
    {
        public TelaPrincipalForm()
        {
            InitializeComponent();
            #region idioma/regi�o interface - satellite assembly
            // com base no idioma/regi�o escolhido pelo usu�rio,
            // ajusta as propriedades dos componentes da tela com base no conte�do do arquivo
            //resources
            Funcoes.AjustaResourcesControl(this);
            //ajuste manual de campos ou mensagens para o usu�rio que n�o puderam ser
            //automatizadas acima
            this.Text = Properties.Resources.ResourceManager.GetString("txtTituloPrincipal");
            #endregion
            #region configura��o idioma - MenuStrip 
            Funcoes.AjustaResourcesItem(contextMenuStripPrincipal);
            #endregion
            #region Configura��o De Bot�es no Foco
            //adiciona eventos em geral, exemplo: ganhar e perder o foco
            Funcoes.EventoFocoCampos(this);
            #endregion
            #region Enter Como Tab
            //Evento em Funcoes que congifura a tecla enter como o tab
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown);
            #endregion
            #region Configura��o MenuStrip
            //inicioToolStripMenuItem.Click += new EventHandler(bt!);
            ClienteStripMenuItem.Click += new EventHandler(btnCadastrarCliente_Click!);
            funcionariosToolStripMenuItem.Click += new EventHandler(btnCadastroDeFuncionarios_Click!);
            saboresToolStripMenuItem.Click += new EventHandler(btnCadastroDeSabores_Click!);
            ingredientesToolStripMenuItem.Click += new EventHandler(btnCadastroDeIngredientes_Click!);
            valoresToolStripMenuItem.Click += new EventHandler(btnCadastroValores_Click!);
            produtosToolStripMenuItem.Click += new EventHandler(btnCadastrarProduto_Click!);
            configura��esToolStripMenuItem.Click += new EventHandler(Configura��esBtn_Click!);
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

        private void Configura��esBtn_Click(object sender, EventArgs e)
        {
            TelaConfigura��oForm telaConfigura��o = new TelaConfigura��oForm();
            telaConfigura��o.ShowDialog();
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

        private void abrirAplica��oToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void encerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
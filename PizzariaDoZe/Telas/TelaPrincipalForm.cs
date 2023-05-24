using PizzariaDoZe.Properties;
using PizzariaDoZe_DAO.PastaEndereco;
using PizzariaDoZe_DAO.PastaIngredientes;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace PizzariaDoZe.Telas
{
    public partial class TelaPrincipalForm : Form
    {
        private IngredientesDAO ingredienteDAO;
        private EnderecoDAO enderecoDAO;
        // pega os dados do banco de dados
        string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
        string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;

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
            #region configuração idioma - MenuStrip 
            Funcoes.AjustaResourcesItem(contextMenuStripPrincipal);
            #endregion
            #region DAO
            // cria a instancia da classe da model
            ingredienteDAO = new IngredientesDAO(provider, strConnection);
            enderecoDAO = new EnderecoDAO(provider, strConnection);
            #endregion
            #region Atualizar Views
            AtualizarViews();
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
            AtualizarTelaIngredientes();
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
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIconSystemTray.Visible = false;
        }

        private void encerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AtualizarViews()
        {
            AtualizarTelaIngredientes();
            AtualizarTelaEndereco();
        }

        private void AtualizarTelaIngredientes()
        {
            //Instância e Preenche o objeto com os dados da view
            var ingrediente = new Ingrediente();
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = ingredienteDAO.Buscar(ingrediente);
                // seta o datasouce do dataGridView com os dados retornados
                dataGridViewIngredientes.Columns.Clear();
                dataGridViewIngredientes.AutoGenerateColumns = true;
                dataGridViewIngredientes.DataSource = linhas;
                dataGridViewIngredientes.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AtualizarTelaEndereco()
        {
            //Instância e Preenche o objeto com os dados da view
            var endereco = new Endereco();
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = enderecoDAO.Buscar(endereco);
                // seta o datasouce do dataGridView com os dados retornados
                dataGridViewEndereco.Columns.Clear();
                dataGridViewEndereco.AutoGenerateColumns = true;
                dataGridViewEndereco.DataSource = linhas;
                dataGridViewEndereco.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tabControlCadastros_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
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
            #region Configuração De Botões no Foco
            //adiciona eventos em geral, exemplo: ganhar e perder o foco
            Funcoes.EventoFocoCampos(this);
            #endregion
            #region Enter Como Tab
            //Evento em Funcoes que congifura a tecla enter como o tab
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown);
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
    }
}
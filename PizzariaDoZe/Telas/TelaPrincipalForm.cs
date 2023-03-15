namespace PizzariaDoZe.Telas
{
    public partial class TelaPrincipalForm : Form
    {
        public TelaPrincipalForm()
        {
            InitializeComponent();
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
    }
}
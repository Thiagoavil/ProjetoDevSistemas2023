using PizzariaDoZe_DAO.PastaIngredientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PizzariaDoZe.Telas
{
    public partial class CadastroDeIngredientesForm : Form
    {
        private readonly IngredientesDAO dao;
        public CadastroDeIngredientesForm()
        {
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
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
            dao = new IngredientesDAO(provider, strConnection);
        }

        private void ButtonSalvar_Click(object? sender, EventArgs e)
        {

           
            try
            {
                //Instância e Preenche o objeto com os dados da view
                var ingrediente = new Ingredientes
                {
                    IdIngrediente = 0,
                    Nome = txtNome.Text,
                };

                // chama o método para inserir da camada model
                dao.InserirDbProvider(ingrediente);
                MessageBox.Show("Dados inseridos com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CadastroDeIngredientesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                e.Cancel = false;
            }
            catch (Exception ex)
            {
                //errorProviderIngredientes.HandleError(ex);
            }
        }

        private void txtNome_Validating(object sender, CancelEventArgs e)
        {
            try
            {

                if (txtNome.Text.Trim().Length < 0)
                {
                    errorProviderIngredientes.SetError(txtNome, "Informe o nome do Ingrediente");
                }
                else if (txtNome.Text.Trim().Length > 30)
                {
                    errorProviderIngredientes.SetError(txtNome, "Deve ter no máximo 30 caracteres");
                }
                else
                {
                    errorProviderIngredientes.SetError(txtNome, "");
                }
            }
            catch (Exception ex)
            {
                //Errors.HandleError(ex);
            }
        }
    }
}

using PizzariaDoZe.PastaEnums;
using PizzariaDoZe_DAO.PastaIngredientes;
using PizzariaDoZe_DAO.PastaSabores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaDoZe.Telas
{
    public partial class CadastroDeSaboresForm : Form
    {
        private IngredientesDAO ingredienteDAO;
        private SaborDAO saborDAO;
        public CadastroDeSaboresForm()
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
            // pega os dados do banco de dados
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instancia da classe da model
            ingredienteDAO = new IngredientesDAO(provider, strConnection);
            saborDAO = new SaborDAO(provider, strConnection);
            CarregaEnumListBox();
            CarregaIngredientesCheckedListBox();

        }

        private void CarregaEnumListBox()
        {
            //popular listBoxCategoria
            listBoxCategoria.Items.Clear();
            listBoxCategoria.DataSource = Enum.GetValues(typeof(EnumSaborCategoria));
            //popular listBoxTipo
            listBoxTipo.Items.Clear();
            listBoxTipo.DataSource = Enum.GetValues(typeof(EnumSaborTipo));
        }

        private void CarregaIngredientesCheckedListBox()
        {
            //Instância e Preenche o objeto com os dados da view
            var ingrediente = new Ingredientes();
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = ingredienteDAO.Buscar(ingrediente);
                // carrega os dados, como objeto, no checkedListBox
                CheckListIngredientes.Items.Clear();
                foreach (DataRow row in linhas.Rows)
                {
                    CheckListIngredientes.Items.Add(new Ingredientes(int.Parse(row["ID"].ToString()), row["Nome"].ToString()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CadastroDeSaboresForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void PBFotoPizza_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogImagem = new()
            {
                Title = "Imagem do produto",
                Filter = "Images (*.JPEG;*.BMP;*.JPG;*.GIF;*.PNG;*.)|*.JPEG;*.BMP;*.JPG;*.GIF;*.PNG;*.icon;*.JFIF"
            };
            if (openFileDialogImagem.ShowDialog() == DialogResult.OK)
            {
                //pega a imagem escolhida e adiciona na tela
                PBFotoPizza.Image = Image.FromFile(openFileDialogImagem.FileName);
                //redimensiona a imagem
                PBFotoPizza.Image = (Image)(new Bitmap(PBFotoPizza.Image, new Size(130, 98)));
                //ajusta a visualização no tamanho do pictureBoxImagem na tela
                PBFotoPizza.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Instância e Preenche o objeto com os dados da view
            var sabor = new Sabor
            {
                Id = 0,
                Descricao = txtNome.Text,
                Foto = Funcoes.ConverteImagemParaByteArray(PBFotoPizza.Image),
                Categoria = (char)(EnumSaborCategoria)Enum.Parse(typeof(EnumSaborCategoria), listBoxCategoria.Text),
                Tipo = (char)(EnumSaborTipo)Enum.Parse(typeof(EnumSaborTipo), listBoxTipo.Text),
                SaborIngredientes = CheckListIngredientes.CheckedItems.OfType<Ingredientes>().ToList(),
            };
            try
            {
                // chama o método para inserir da camada model
                saborDAO.Inserir(sabor);
                MessageBox.Show("Dados inseridos com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

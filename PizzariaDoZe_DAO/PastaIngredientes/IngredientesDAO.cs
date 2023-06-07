using System.Data;
using System.Data.Common;

namespace PizzariaDoZe_DAO.PastaIngredientes
{
    public class IngredientesDAO
    {
        /// <summary>
        /// Utilização de mais do que um provider com o mesmo script (MySQL, SQLServer, Firebird...)
        /// </summary>
        private readonly DbProviderFactory factory;
        private string Provider { get; set; }
        private string StringConexao { get; set; }
        public IngredientesDAO(string provider, string stringConexao)
        {
            Provider = provider;
            StringConexao = stringConexao;
            factory = DbProviderFactories.GetFactory(Provider);
        }

        public void InserirDbProvider(Ingredientes ingrediente)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //Adiciona parâmetro (@campo e valor)
            var nome = comando.CreateParameter(); nome.ParameterName = "@descricao_ingrediente";
            nome.Value = ingrediente.Nome; comando.Parameters.Add(nome);

            conexao.Open();

            comando.CommandText = @"INSERT INTO cad_ingredientes(descricao_ingrediente) VALUES (@descricao_ingrediente)";
            //Executa o script na conexão e retorna o número de linhas afetadas.
            var linhas = comando.ExecuteNonQuery();
            //using faz o Close() automático quando fecha o seu escopo
        }
        public DataTable Buscar(Ingredientes ingrediente)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //verifica se tem filtro e personaliza o SQL do filtro
            string auxSqlFiltro = "";
            if (ingrediente.IdIngrediente > 0)
            {
                auxSqlFiltro = "WHERE i.id_ingrediente = " + ingrediente.IdIngrediente + " ";
            }
            else if (ingrediente.Nome.Length > 0)
            {
                auxSqlFiltro = "WHERE i.descricao_ingrediente like '%" + ingrediente.Nome + "%' ";
            }
            conexao.Open();
            comando.CommandText = @" " +
            "SELECT i.id_ingrediente AS ID, i.descricao_ingrediente AS Nome " +
            "FROM cad_ingredientes AS i " +
            auxSqlFiltro +
            "ORDER BY i.descricao_ingrediente;";
            //Executa o script na conexão e retorna as linhas afetadas.
            var sdr = comando.ExecuteReader();
            DataTable linhas = new();
            linhas.Load(sdr);
            return linhas;
        }
    }

}
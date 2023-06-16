using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe_DAO.PastaIngredientes
{
    public class Ingredientes
    {
        public int IdIngrediente { get; set; }
        public string Nome { get; set; }

        public Ingredientes(int id = 0, string nome = "")
        {
            IdIngrediente = id;
            Nome = nome;
        }

        public override string ToString()
        {
            return Nome;
        }
    }
}

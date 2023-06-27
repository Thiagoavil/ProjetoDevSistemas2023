using PizzariaDoZe_DAO.PastaIngredientes;
using PizzariaDoZe_DAO.PastaSabores;
using PizzariaDoZe_DAO.PastaValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe_DAO.PastaPizza
{
    public class Pizza
    {
        public int IdPizza { get; set; } 
        public decimal Valor { get; set; }
        public char Tipo { get; set; }
        public char Tamanho { get; set; }
        public int Borda { get; set; }
        public List<Sabor> Sabores { get; set; }

        public Pizza(decimal valor,char tipo,char tamanho,int borda ,List<Sabor> sabores = null) 
        { 
            Valor = valor;
            Tipo = tipo;
            Tamanho = tamanho;
            Borda = borda;
            this.Sabores = sabores;
        }

    }
}

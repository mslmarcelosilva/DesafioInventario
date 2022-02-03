
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoInventario.Models
{
    public class Produtos
    {
        public int Id { get; set; }
        public string CodigoDeBarra { get; set; }
        public string Nome { get; set; }
        public string Unidade { get; set; }
        public double Quantidade { get; set; }
        public int Status { get; set; }

        public Produtos(int id, string codigoDeBarra, string nome, string unidade, int status)
        {
            Id = id;
            CodigoDeBarra = codigoDeBarra;
            Nome = nome;
            Unidade = unidade;
            Status = status;
        }
    }
}

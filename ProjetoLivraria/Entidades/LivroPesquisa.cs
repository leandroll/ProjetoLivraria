using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProjetoLivraria.Tipos.Tipos;

namespace ProjetoLivraria.Entidades
{
    public class LivroPesquisa
    {
        public Ordenacao Ordenacao { get; set; }
        public Pesquisa Pesquisa { get; set; }
        public string ValorPesquisa { get; set; }
    }
}

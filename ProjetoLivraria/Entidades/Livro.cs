using ProjetoLivraria.Validacoes;
using System;

namespace ProjetoLivraria.Entidades

{
    public class Livro
    {
        public int LivroId { get; set; }

        public string ISBN { get; set; }

        public string Nome { get; set; }

        public decimal Preco { get; set; }

        public byte[] ImagemCapa { get; set; }

        public string Autor { get; set; }

        public DateTime DataPublicacao { get; set; }

        public DateTime DataCadastro { get; set; }

    }
}

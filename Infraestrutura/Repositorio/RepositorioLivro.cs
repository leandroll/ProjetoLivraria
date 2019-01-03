using ProjetoLivraria.Entidades;
using ProjetoLivraria.Interface.Generica;
using ProjetoLivraria.Interface.InterfaceEntidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Repositorio
{
    public class RepositorioLivro : RepositorioGenerico<Livro>, ILivroRepositorio
    {
        public IEnumerable<Livro> BuscarPorDataPublicacao(DateTime dataPublicacao)
        {
            return contexto.DbSetLivro.Where(p => p.DataPublicacao == dataPublicacao);
        }

        public IEnumerable<Livro> BuscarPorISBN(string isbn)
        {
            return contexto.DbSetLivro.Where(p => p.ISBN == isbn);
        }

        public IEnumerable<Livro> BuscarPorNome(string nome)
        {
            return contexto.DbSetLivro.Where(p => p.Nome == nome);
        }

        public IEnumerable<Livro> BuscarPorPreco(decimal preco)
        {
            return contexto.DbSetLivro.Where(p => p.Preco == preco);
        }

        public IEnumerable<Livro> BuscarPorAutor(string autor)
        {
            return contexto.DbSetLivro.Where(p => p.Autor == autor);
        }
    }
}

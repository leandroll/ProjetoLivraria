using ProjetoLivraria.Entidades;
using ProjetoLivraria.Interface.Generica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLivraria.Interface.InterfaceEntidade
{
    public interface ILivroRepositorio: InterfaceGenerica<Livro>
    {
        IEnumerable<Livro> BuscarPorNome(string nome);
        IEnumerable<Livro> BuscarPorISBN(string isbn);
        IEnumerable<Livro> BuscarPorDataPublicacao(DateTime dataPublicacao);
        IEnumerable<Livro> BuscarPorPreco(decimal preco);
        IEnumerable<Livro> BuscarPorAutor(string autor);
    }
}

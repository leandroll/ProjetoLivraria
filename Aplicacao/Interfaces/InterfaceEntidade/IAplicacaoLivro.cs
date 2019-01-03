using ProjetoLivraria.Entidades;
using ProjetoLivraria.Interface.InterfaceEntidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.Interfaces.InterfaceEntidade
{
    public interface IAplicacaoLivro: IAplicacaoGenerica<Livro>
    {
        IEnumerable<Livro> BuscarPor(LivroPesquisa livroPesquisa);
        //IEnumerable<Livro> BuscarPorNome(string nome);
        //IEnumerable<Livro> BuscarPorISBN(string isbn);
        //IEnumerable<Livro> BuscarPorDataPublicacao(DateTime dataPublicacao);
        //IEnumerable<Livro> BuscarPorPreco(decimal preco);
        //IEnumerable<Livro> BuscarPorAutor(string autor);
    }
}

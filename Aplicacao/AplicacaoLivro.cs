using Aplicacao.Interfaces;
using Aplicacao.Interfaces.InterfaceEntidade;
using ProjetoLivraria.Entidades;
using ProjetoLivraria.Interface.InterfaceEntidade;
using ProjetoLivraria.Tipos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao
{
    public class AplicacaoLivro : IAplicacaoGenerica<Livro>, IAplicacaoLivro
    {
        ILivroRepositorio _livroRepositorio;

        public AplicacaoLivro(ILivroRepositorio livroRepositorio)
        {
            this._livroRepositorio = livroRepositorio;
        }
        
        public void Adicionar(Livro obj)
        {
            _livroRepositorio.Adicionar(obj);
        }

        public void Atualizar(Livro obj)
        {
            _livroRepositorio.Atualizar(obj);
        }

        public void Deletar(int id)
        {
            _livroRepositorio.Deletar(id);
        }

        public List<Livro> ListarTodos()
        {
            return _livroRepositorio.ListarTodos();
        }

        public Livro ObterPorId(int id)
        {
            return _livroRepositorio.ObterPorId(id);
        }

        public IEnumerable<Livro> BuscarPor(LivroPesquisa livroPesquisa)
        {
            IEnumerable<Livro> Ret;

            switch (livroPesquisa.Pesquisa)
            {
                case Tipos.Pesquisa.Isbn:
                    Ret = _livroRepositorio.BuscarPorISBN(livroPesquisa.ValorPesquisa);
                    break;

                case Tipos.Pesquisa.Autor:
                    Ret = _livroRepositorio.BuscarPorAutor(livroPesquisa.ValorPesquisa);
                    break;

                case Tipos.Pesquisa.Nome:
                    Ret = _livroRepositorio.BuscarPorNome(livroPesquisa.ValorPesquisa);
                    break;

                case Tipos.Pesquisa.Valor:
                    Ret = _livroRepositorio.BuscarPorPreco(int.Parse(livroPesquisa.ValorPesquisa));
                    break;

                case Tipos.Pesquisa.DataPublicacao:
                    Ret = _livroRepositorio.BuscarPorDataPublicacao(DateTime.Parse(livroPesquisa.ValorPesquisa));
                    break;

                default:
                    Ret = _livroRepositorio.ListarTodos();
                    break;
            }

            return OrdernarPor(Ret, livroPesquisa);
        }

        public IEnumerable<Livro> OrdernarPor(IEnumerable<Livro> Livros, LivroPesquisa livroPesquisa)
        {
            switch (livroPesquisa.Pesquisa)
            {
                case Tipos.Pesquisa.Isbn:
                    return Livros.OrderBy(x => x.ISBN);

                case Tipos.Pesquisa.Autor:
                    return Livros.OrderBy(x => x.Autor);

                case Tipos.Pesquisa.Nome:
                    return Livros.OrderBy(x => x.Nome);

                case Tipos.Pesquisa.Valor:
                    return Livros.OrderBy(x => x.Preco);

                case Tipos.Pesquisa.DataPublicacao:
                    return Livros.OrderBy(x => x.DataPublicacao);

                default:
                    return Livros;
            }
        }
    }
}

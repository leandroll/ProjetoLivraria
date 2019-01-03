using Aplicacao;
using Infraestrutura.Repositorio;
using ProjetoLivraria.Entidades;
using ProjetoLivraria.Tipos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiLivraria.Controllers
{
    [RoutePrefix("api/Livro")]
    public class LivroController : ApiController
    {
        // GET: api/Livro
        public IEnumerable<Livro> Get()
        {
            return new AplicacaoLivro(new RepositorioLivro()).ListarTodos();
        }

        // GET: api/Livro/5
        public Livro Get(int id)
        {
            return new AplicacaoLivro(new RepositorioLivro()).ObterPorId(id);
        }

        [AcceptVerbs("POST")]
        [Route("BuscarPor")]
        public IEnumerable<Livro> BuscarPor(LivroPesquisa livroPesquisa)
        {
            //return new AplicacaoLivro(new RepositorioLivro()).ListarTodos();
            return new AplicacaoLivro(new RepositorioLivro()).BuscarPor(livroPesquisa);
        }

        // POST: api/Livro
        public void Post([FromBody]Livro livro)
        {
            new AplicacaoLivro(new RepositorioLivro()).Adicionar(livro);
        }

        // PUT: api/Livro/5
        public void Put([FromBody]Livro livro)
        {
            new AplicacaoLivro(new RepositorioLivro()).Atualizar(livro);
        }

        // DELETE: api/Livro/5
        public void Delete(int id)
        {
            new AplicacaoLivro(new RepositorioLivro()).Deletar(id);
        }

        //[AcceptVerbs("GET")]
        //[Route("BuscarPorISBN/{val}")]
        //public IEnumerable<Livro> BuscarPorISBN(string val)
        //{
        //    return new AplicacaoLivro(new RepositorioLivro()).BuscarPorISBN(val);
        //}

        //[AcceptVerbs("GET")]
        //[Route("BuscarPorNome/{val}")]
        //public IEnumerable<Livro> BuscarPorNome(string val)
        //{
        //    return new AplicacaoLivro(new RepositorioLivro()).BuscarPorNome(val);
        //}

        //[AcceptVerbs("GET")]
        //[Route("BuscarPorAutor/{val}")]
        //public IEnumerable<Livro> BuscarPorAutor(string val)
        //{
        //    return new AplicacaoLivro(new RepositorioLivro()).BuscarPorAutor(val);
        //}

        //[AcceptVerbs("GET")]
        //[Route("BuscarPorPreco/{val}")]
        //public IEnumerable<Livro> BuscarPorPreco(string val)
        //{
        //    return new AplicacaoLivro(new RepositorioLivro()).BuscarPorPreco(int.Parse(val));
        //}

        //[AcceptVerbs("GET")]
        //[Route("BuscarPorDataPublicacao/{val}")]
        //public IEnumerable<Livro> BuscarPorDataPublicacao(string val)
        //{
        //    return new AplicacaoLivro(new RepositorioLivro()).BuscarPorDataPublicacao(DateTime.Parse(val));
        //}
    }
}

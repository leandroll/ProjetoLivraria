using Infraestrutura.Config;
using ProjetoLivraria.Interface.Generica;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Repositorio
{
    public class RepositorioGenerico<T> : InterfaceGenerica<T>, IDisposable where T : class
    {
        public readonly DbContexto contexto = new DbContexto();

        public RepositorioGenerico()
        {
            //contexto = new DbContexto();
        }

        public void Adicionar(T obj)
        {
            contexto.Set<T>().Add(obj);
            contexto.SaveChanges();
        }

        public void Atualizar(T obj)
        {
            contexto.Entry(obj).State = EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Deletar(int id)
        {
            var obj = contexto.Set<T>().Find(id);

            if(obj != null)
            {
                contexto.Set<T>().Remove(obj);
                contexto.SaveChanges();
            }
        }

        public List<T> ListarTodos()
        {
            return contexto.Set<T>().ToList();
        }

        public T ObterPorId(int id)
        {
            return contexto.Set<T>().Find(id);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool val)
        {
            if (!val) return;
            if (contexto == null) return;
            contexto.Dispose();
        }

        ~RepositorioGenerico()
        {
            Dispose(false);
        }
    }
}

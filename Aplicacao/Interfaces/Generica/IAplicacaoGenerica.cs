using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.Interfaces
{
    public interface IAplicacaoGenerica<T> where T: class
    {
        void Adicionar(T obj);
        void Atualizar(T obj);
        void Deletar(int id);
        T ObterPorId(int id);
        List<T> ListarTodos();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLivraria.Validacoes
{
    class ValidarRegraException<T>: ValidarExcecao
    {
        internal void AdicionarErroPara<TPropriedade>(Expression<Func<T, TPropriedade>> propriedade, string mensagem)
        {
            _Erros.Add(new ValidarViolacao { Propriedade = propriedade, Menssagem = mensagem});
        }
    }
}

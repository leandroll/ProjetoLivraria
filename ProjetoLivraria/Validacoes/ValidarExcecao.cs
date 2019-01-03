using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLivraria.Validacoes
{
    public class ValidarExcecao: Exception
    {
        public List<ValidarViolacao> _Erros = new List<ValidarViolacao>();
        public readonly Expression<Func<object, object>> _objeto = x => x;

        protected void AdicionarMenssagemErro(string Menssagem)
        {
            _Erros.Add(new ValidarViolacao { Propriedade = _objeto, Menssagem = Menssagem});
        }
    }
}

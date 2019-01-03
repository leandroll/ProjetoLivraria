using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLivraria.Validacoes
{
    public class ValidarViolacao
    {
        public LambdaExpression Propriedade { get; set; }

        public string Menssagem { get; set; }
    }
}

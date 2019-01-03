using ProjetoLivraria.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Mapa
{
    class LivroMapa: EntityTypeConfiguration<Livro>
    {
        public LivroMapa()
        {
            HasKey(x => x.LivroId);
            Property(x => x.Nome).HasMaxLength(150).IsRequired();
            Property(x => x.ISBN).HasMaxLength(13).IsRequired();
            Property(x => x.ImagemCapa);
            Property(x => x.Preco).IsRequired();
            Property(x => x.Autor).IsRequired();
            Property(x => x.DataPublicacao);
            Property(x => x.DataCadastro);
            HasIndex(x => x.ISBN).IsUnique();
        }
    }
}

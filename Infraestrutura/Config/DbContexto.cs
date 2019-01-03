using Infraestrutura.Mapa;
using ProjetoLivraria.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Config
{
    public class DbContexto: DbContext
    {
        private const string StringDeConexao = "Data Source =.\\SQLEXPRESS;Initial Catalog = LivrariaBD; user id=sa; password=2341113";
       
        public DbContexto(): base(StringDeConexao)
        {

        }


        //LLL - Para constumizar o banco de dados
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //LLL - Não pluralizar nome das tabelas
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //LLL - Evitar deleções em cascatas
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            //LLL - garantir que as propriedades da minha classe POCO cuja o nome termine com 'ID' seja também um campo id na tabela
            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            //LLL - forçar criação de campo string como varchar ao invés do padrão nchar
            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            //LLL - Se não informar o tamanho vai assuir que seja 100
            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

           //LLL - Carrega o mapeamento da Tabela de Livro
           modelBuilder.Configurations.Add(new LivroMapa());
            
        }

        public DbSet<Livro> DbSetLivro { get; set; }

    }
           
}

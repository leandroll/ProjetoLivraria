namespace Infraestrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Livro",
                c => new
                    {
                        LivroId = c.Int(nullable: false, identity: true),
                        ISBN = c.String(nullable: false, maxLength: 13, unicode: false),
                        Nome = c.String(nullable: false, maxLength: 150, unicode: false),
                        Preco = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ImagemCapa = c.Binary(),
                        Autor = c.String(nullable: false, maxLength: 100, unicode: false),
                        DataPublicacao = c.DateTime(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.LivroId)
                .Index(t => t.ISBN, unique: true);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Livro", new[] { "ISBN" });
            DropTable("dbo.Livro");
        }
    }
}

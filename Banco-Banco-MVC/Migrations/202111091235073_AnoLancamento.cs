namespace Banco_Banco_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AnoLancamento : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ano_de_Lancamento",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Ano = c.DateTime(nullable: false),
                        MovieId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Ano_de_Lancamento");
        }
    }
}

namespace RegistroDeVisitantes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TablaVisitantes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Visitantes",
                c => new
                    {
                        VisitanteID = c.Int(nullable: false, identity: true),
                        Nombres = c.String(nullable: false),
                        Apellidos = c.String(nullable: false),
                        fechaVisita = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.VisitanteID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Visitantes");
        }
    }
}

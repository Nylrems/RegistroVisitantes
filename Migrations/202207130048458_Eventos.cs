namespace RegistroDeVisitantes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Eventos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Eventos",
                c => new
                    {
                        EventosId = c.Int(nullable: false, identity: true),
                        NombreDelEvento = c.String(nullable: false),
                        Detalles = c.String(nullable: false),
                        fechaEvento = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.EventosId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Eventos");
        }
    }
}

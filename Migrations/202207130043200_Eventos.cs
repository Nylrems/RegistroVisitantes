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
                    EventoID = c.Int(nullable: false, identity: true),
                    NombreDelEvento = c.String(nullable: false),
                    Detalles = c.String(nullable: false),
                    fechaDelEvento = c.DateTime(nullable: false),
                    historialVisitas_HistorialId = c.Int(),
                })
                .PrimaryKey(t => t.EventoID);

            CreateIndex("dbo.Eventos", "historialVisitas_HistorialId");
            AddForeignKey("dbo.Eventos", "historialVisitas_HistorialId", "dbo.HistorialVisitas", "HistorialId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Eventos", "historialVisitas_HistorialId", "dbo.HistorialVisitas");
            DropIndex("dbo.Eventos", new[] { "historialVisitas_HistorialId" });
            DropTable("dbo.Eventos");
            
        }
    }
}

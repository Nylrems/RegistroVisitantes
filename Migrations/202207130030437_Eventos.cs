namespace RegistroDeVisitantes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Eventos : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Eventos", "historialVisitas_HistorialId", "dbo.HistorialVisitas");
            DropIndex("dbo.Eventos", new[] { "historialVisitas_HistorialId" });
            AddColumn("dbo.Eventos", "VisitanteId", c => c.Int(nullable: false));
            AddColumn("dbo.Eventos", "visitantes_VisitanteID", c => c.Int());
            AddColumn("dbo.Visitantes", "Eventos_EventoID", c => c.Int());
            CreateIndex("dbo.Eventos", "visitantes_VisitanteID");
            CreateIndex("dbo.Visitantes", "Eventos_EventoID");
            AddForeignKey("dbo.Eventos", "visitantes_VisitanteID", "dbo.Visitantes", "VisitanteID");
            AddForeignKey("dbo.Visitantes", "Eventos_EventoID", "dbo.Eventos", "EventoID");
            DropColumn("dbo.Eventos", "historialVisitas_HistorialId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Eventos", "historialVisitas_HistorialId", c => c.Int());
            DropForeignKey("dbo.Visitantes", "Eventos_EventoID", "dbo.Eventos");
            DropForeignKey("dbo.Eventos", "visitantes_VisitanteID", "dbo.Visitantes");
            DropIndex("dbo.Visitantes", new[] { "Eventos_EventoID" });
            DropIndex("dbo.Eventos", new[] { "visitantes_VisitanteID" });
            DropColumn("dbo.Visitantes", "Eventos_EventoID");
            DropColumn("dbo.Eventos", "visitantes_VisitanteID");
            DropColumn("dbo.Eventos", "VisitanteId");
            CreateIndex("dbo.Eventos", "historialVisitas_HistorialId");
            AddForeignKey("dbo.Eventos", "historialVisitas_HistorialId", "dbo.HistorialVisitas", "HistorialId");
        }
    }
}

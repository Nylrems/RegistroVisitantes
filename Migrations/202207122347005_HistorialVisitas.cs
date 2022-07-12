namespace RegistroDeVisitantes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HistorialVisitas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HistorialVisitas",
                c => new
                    {
                        HistorialId = c.Int(nullable: false, identity: true),
                        HoraDeEntrada = c.DateTime(nullable: false),
                        HoraDeSalida = c.DateTime(nullable: false),
                        VisitanteId = c.Int(nullable: false),
                        historialVisitas_HistorialId = c.Int(),
                    })
                .PrimaryKey(t => t.HistorialId)
                .ForeignKey("dbo.HistorialVisitas", t => t.historialVisitas_HistorialId)
                .Index(t => t.historialVisitas_HistorialId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HistorialVisitas", "historialVisitas_HistorialId", "dbo.HistorialVisitas");
            DropIndex("dbo.HistorialVisitas", new[] { "historialVisitas_HistorialId" });
            DropTable("dbo.HistorialVisitas");
        }
    }
}

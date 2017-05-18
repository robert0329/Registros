namespace Registros.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BeautyBaseDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Citas",
                c => new
                    {
                        CitaId = c.Int(nullable: false, identity: true),
                        ClienteId = c.Int(nullable: false),
                        ServicioId = c.Int(nullable: false),
                        NombreCliente = c.String(),
                        Fecha = c.DateTime(nullable: false),
                        Hora = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CitaId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Citas");
        }
    }
}

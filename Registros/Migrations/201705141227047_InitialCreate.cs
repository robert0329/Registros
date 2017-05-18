namespace Registros.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ClienteID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 100),
                        Telefono = c.String(nullable: false, maxLength: 100),
                        Direccion = c.String(nullable: false, maxLength: 100),
                        FechaNacimiento = c.DateTime(nullable: false),
                        Email = c.String(nullable: false, maxLength: 100),
                        Cedula = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.ClienteID);
            
            CreateTable(
                "dbo.Empleados",
                c => new
                    {
                        EmpleadosID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 100),
                        FechaDeEntrada = c.DateTime(nullable: false),
                        SueldoFijo = c.String(nullable: false, maxLength: 100),
                        Telefono = c.String(nullable: false, maxLength: 100),
                        Direccion = c.String(nullable: false, maxLength: 100),
                        FechaNacimiento = c.DateTime(nullable: false),
                        Email = c.String(nullable: false, maxLength: 100),
                        Cedula = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.EmpleadosID);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        UsuariosId = c.Int(nullable: false, identity: true),
                        Nombres = c.String(),
                        Usuario = c.String(),
                        Clave = c.String(),
                    })
                .PrimaryKey(t => t.UsuariosId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Usuarios");
            DropTable("dbo.Empleados");
            DropTable("dbo.Clientes");
        }
    }
}

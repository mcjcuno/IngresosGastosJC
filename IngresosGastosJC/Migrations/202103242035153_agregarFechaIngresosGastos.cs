namespace IngresosGastosJC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class agregarFechaIngresosGastos : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.IngresosGastosJCLs", "FechaIngreso", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.IngresosGastosJCLs", "FechaIngreso");
        }
    }
}

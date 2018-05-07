namespace SMS_Sender.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModificarCampoFechaEnTablaClienteParaAceptarValorDefault : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Cliente", "Fecha");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cliente", "Fecha", c => c.DateTime(nullable: false, defaultValueSql: "GetDate()"));
        }
    }
}

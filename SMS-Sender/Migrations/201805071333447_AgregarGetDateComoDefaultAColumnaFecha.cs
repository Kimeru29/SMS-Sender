namespace SMS_Sender.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgregarGetDateComoDefaultAColumnaFecha : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cliente", "Fecha", c => c.DateTime(nullable: false, defaultValueSql: "GetDate()"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cliente", "Fecha");
        }
    }
}

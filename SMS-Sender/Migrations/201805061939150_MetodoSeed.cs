namespace SMS_Sender.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MetodoSeed : DbMigration
    {
        public override void Up()
        {
            //Suponiendo que subiéramos datos aprobados para producción usaríamos el helper method Sql
            //Sql("INSERT INTO dbo.[Tabla Equis] VALUES("blabla", 1)");
        }
        
        public override void Down()
        {
            //Sql("TRUNCATE TABLE dbo.[Tabla Equis]");
        }
    }
}

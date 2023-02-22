namespace FrameworkDotNetGLSI_C.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataToTableMovie : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MOVIES Values ('MovieFromMigration')");

        }
        
        public override void Down()
        {
        }
    }
}

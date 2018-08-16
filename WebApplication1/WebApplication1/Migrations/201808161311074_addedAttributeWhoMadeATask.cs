namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedAttributeWhoMadeATask : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Notepad", "MachineName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Notepad", "MachineName");
        }
    }
}

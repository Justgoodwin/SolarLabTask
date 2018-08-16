namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateNotepadClass : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Notepad", "TimeWhenTaskCreated", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Notepad", "TimeWhenTaskCreated");
        }
    }
}

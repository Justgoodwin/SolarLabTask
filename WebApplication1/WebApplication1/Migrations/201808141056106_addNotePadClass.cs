namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addNotePadClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Notepad",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Task = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Notepad");
        }
    }
}

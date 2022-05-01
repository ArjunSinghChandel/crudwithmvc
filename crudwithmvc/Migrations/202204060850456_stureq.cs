namespace crudwithmvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class stureq : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.students", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.students", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.students", "email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.students", "email", c => c.String());
            AlterColumn("dbo.students", "Address", c => c.String());
            AlterColumn("dbo.students", "Name", c => c.String());
        }
    }
}

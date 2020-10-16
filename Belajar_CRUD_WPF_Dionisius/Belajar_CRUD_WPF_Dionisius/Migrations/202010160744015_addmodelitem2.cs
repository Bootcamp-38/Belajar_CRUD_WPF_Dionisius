namespace Belajar_CRUD_WPF_Dionisius.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addmodelitem2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TB_M_Item", "Stock", c => c.Int(nullable: false));
            AddColumn("dbo.TB_M_Item", "Price", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TB_M_Item", "Price");
            DropColumn("dbo.TB_M_Item", "Stock");
        }
    }
}

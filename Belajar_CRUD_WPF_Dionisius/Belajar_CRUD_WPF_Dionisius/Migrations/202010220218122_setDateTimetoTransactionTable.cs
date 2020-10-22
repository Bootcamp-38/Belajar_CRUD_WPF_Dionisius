namespace Belajar_CRUD_WPF_Dionisius.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class setDateTimetoTransactionTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TB_M_Transaction", "OrderDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.TB_M_Transaction", "Date");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TB_M_Transaction", "Date", c => c.String());
            DropColumn("dbo.TB_M_Transaction", "OrderDate");
        }
    }
}

namespace Belajar_CRUD_WPF_Dionisius.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTableTransactionItem : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TB_M_Transaction",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TB_M_Transaction");
        }
    }
}

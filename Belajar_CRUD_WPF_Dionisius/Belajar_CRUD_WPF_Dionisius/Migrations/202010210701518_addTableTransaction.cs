namespace Belajar_CRUD_WPF_Dionisius.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTableTransaction : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TB_S_TransactionItem",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.Int(nullable: false),
                        Supplier_Id = c.Int(),
                        Transaction_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TB_M_Supplier", t => t.Supplier_Id)
                .ForeignKey("dbo.TB_M_Transaction", t => t.Transaction_Id)
                .Index(t => t.Supplier_Id)
                .Index(t => t.Transaction_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TB_S_TransactionItem", "Transaction_Id", "dbo.TB_M_Transaction");
            DropForeignKey("dbo.TB_S_TransactionItem", "Supplier_Id", "dbo.TB_M_Supplier");
            DropIndex("dbo.TB_S_TransactionItem", new[] { "Transaction_Id" });
            DropIndex("dbo.TB_S_TransactionItem", new[] { "Supplier_Id" });
            DropTable("dbo.TB_S_TransactionItem");
        }
    }
}

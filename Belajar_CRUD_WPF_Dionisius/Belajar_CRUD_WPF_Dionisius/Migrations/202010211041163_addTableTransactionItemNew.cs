namespace Belajar_CRUD_WPF_Dionisius.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTableTransactionItemNew : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TB_S_TransactionItem", "Supplier_Id", "dbo.TB_M_Supplier");
            DropIndex("dbo.TB_S_TransactionItem", new[] { "Supplier_Id" });
            AddColumn("dbo.TB_S_TransactionItem", "Item_Id", c => c.Int());
            CreateIndex("dbo.TB_S_TransactionItem", "Item_Id");
            AddForeignKey("dbo.TB_S_TransactionItem", "Item_Id", "dbo.TB_M_Item", "Id");
            DropColumn("dbo.TB_S_TransactionItem", "Supplier_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TB_S_TransactionItem", "Supplier_Id", c => c.Int());
            DropForeignKey("dbo.TB_S_TransactionItem", "Item_Id", "dbo.TB_M_Item");
            DropIndex("dbo.TB_S_TransactionItem", new[] { "Item_Id" });
            DropColumn("dbo.TB_S_TransactionItem", "Item_Id");
            CreateIndex("dbo.TB_S_TransactionItem", "Supplier_Id");
            AddForeignKey("dbo.TB_S_TransactionItem", "Supplier_Id", "dbo.TB_M_Supplier", "Id");
        }
    }
}

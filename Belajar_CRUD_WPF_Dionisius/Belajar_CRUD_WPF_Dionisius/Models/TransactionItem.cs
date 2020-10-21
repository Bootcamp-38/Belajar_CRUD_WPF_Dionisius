using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belajar_CRUD_WPF_Dionisius.Models
{
    [Table("TB_S_TransactionItem")]
    public class TransactionItem
    {
        [Key]
        public int Id { get; set; }
        public int Number { get; set; }
        public Supplier Supplier { get; set; }
        public Transaction Transaction { get; set; }

        public TransactionItem() { }
        public TransactionItem(int number, Supplier supplier, Transaction transaction)
        {
            this.Number = number;
            this.Supplier = supplier;
            this.Transaction = transaction;
        }
    }
}

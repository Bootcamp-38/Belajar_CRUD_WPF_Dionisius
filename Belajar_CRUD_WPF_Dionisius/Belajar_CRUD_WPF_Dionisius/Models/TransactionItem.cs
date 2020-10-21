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
        public Item Item { get; set; }
        public Transaction Transaction { get; set; }

        public TransactionItem() { }
        public TransactionItem(int number, Item item, Transaction transaction)
        {
            this.Number = number;
            this.Item = item;
            this.Transaction = transaction;
        }
    }
}

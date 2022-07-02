using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Models
{
    [Table("transaction_categories")]
    public class TransactionCategory : BaseEntity
    {
        [Key]
        public int id { get; set; }
        public string type { get; set; } // expense | receipt
        public string name { get; set; }
        public int? expense_group_id { get; set; }

        [ForeignKey("expense_group_id")]
        public ExpenseGroup expense_group { get; set; }
    }
}
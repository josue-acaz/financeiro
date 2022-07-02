using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Models
{
    [Table("expense_groups")]
    public class ExpenseGroup : BaseEntity
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public ICollection<TransactionCategory> transaction_categories { get; set; }
    }
}
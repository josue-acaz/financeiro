using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Models
{
    [Table("splits")]
    public class Split : BaseEntity
    {
        [Key]
        public int id { get; set; }
        public bool paid { get; set; }
        public string description { get; set; }
        public float value { get; set; }
        public DateTime date { get; set; }
        public int transaction_id { get; set; }

        [ForeignKey("transaction_id")]
        public Transaction transaction { get; set; }
        public int transaction_category_id { get; set; }

        [ForeignKey("transaction_category_id")]
        public TransactionCategory transaction_category { get; set; }
        public int contact_id { get; set; }

        [ForeignKey("contact_id")]
        public Contact contact { get; set; }
    }
}
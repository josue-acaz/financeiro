using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Models
{
    [Table("installments")]
    public class Installment : BaseEntity
    {
        [Key]
        public int id { get; set; }
        public string number { get; set; }
        public float value { get; set; }
        public bool paid { get; set; }
        public DateTime due_date { get; set; }
        public int transaction_id { get; set; }

        [ForeignKey("transaction_id")]
        public Transaction transaction { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Models
{
    [Table("attachments")]
    public class Attachment : BaseEntity
    {
        [Key]
        public int id { get; set; }
        public int transaction_id { get; set; }

        [ForeignKey("transaction_id")]
        public Transaction transaction { get; set; }
    }
}
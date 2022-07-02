using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Models
{
    [Table("card_operators")]
    public class CardOperator : BaseEntity
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
    }
}
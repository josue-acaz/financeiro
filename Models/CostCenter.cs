using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Models
{
    [Table("cost_centers")]
    public class CostCenter : BaseEntity
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public ICollection<Transaction> transactions { get; set; }
    }
}
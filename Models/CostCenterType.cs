using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Models
{
    [Table("cost_center_types")]
    public class CostCenterType : BaseEntity
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public ICollection<Account> accounts { get; set; }
    }
}

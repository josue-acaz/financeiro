using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Models
{
    [Table("accounts")]
    public class Account : BaseEntity
    {
        [Key]
        public int id { get; set; }
        public bool active { get; set; }
        public string name { get; set; }
        public float balance { get; set; }
        public float initial_balance { get; set; }
        public bool _default { get; set; } // Conta Principal
        public int cost_center_type_id { get; set; }

        [ForeignKey("cost_center_type_id")]
        public CostCenterType cost_center_type { get; set; }
        public ICollection<Transaction> transactions { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Models
{
    [Table("cities")]
    public class City : BaseEntity
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public int state_id { get; set; }

        [ForeignKey("state_id")]
        public State state { get; set; }
        public ICollection<ContactAddress> contact_addresses { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Models
{
    [Table("states")]
    public class State : BaseEntity
    {
        [Key]
        public int id { get; set; }
        public string prefix { get; set; }
        public ICollection<City> cities { get; set; }
    }
}
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Models
{
    [Table("system_logs")]
    public class SystemLog : BaseEntity
    {
        [Key]
        public int id { get; set; }
        public string action { get; set; }
        public string _object { get; set; }
        public string description { get; set; }
        public int user_id { get; set; }

        [ForeignKey("user_id")]
        public User user { get; set; }
    }
}
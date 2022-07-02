using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Models
{
    [Table("permissions")]
    public class Permisson : BaseEntity
    {
        [Key]
        public int id { get; set; }
        public bool create { get; set; }
        public bool read { get; set; }
        public bool update { get; set; }
        public bool delete { get; set; }
        public string resource { get; set; }
        public int user_id { get; set; }

        [ForeignKey("user_id")]
        public User user { get; set; }
    }
}

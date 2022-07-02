using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Models
{
    [Table("users")]
    public class User : BaseEntity
    {
        [Key]
        public int id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string password_hash { get; set; }
        public ICollection<Permisson> permissons { get; set; }
        public ICollection<SystemLog> system_logs { get; set; }
        public UserSetting user_setting { get; set; }
    }
}
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Models
{
    [Table("contact_pfs")]
    public class ContactPf : BaseEntity
    {
        [Key]
        public int id { get; set; }
        public string cpf { get; set; }
        public int contact_id { get; set; }

        [ForeignKey("contact_id")]
        public Contact contact { get; set; }
    }
}
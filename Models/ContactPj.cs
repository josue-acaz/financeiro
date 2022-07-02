using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Models
{
    [Table("contact_pjs")]
    public class ContactPj : BaseEntity
    {
        [Key]
        public int id { get; set; }
        public string cnpj { get; set; }
        public string company_name { get; set; }
        public string state_registration { get; set; }
        public int contact_id { get; set; }

        [ForeignKey("contact_id")]
        public Contact contact { get; set; }
    }
}
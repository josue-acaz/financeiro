using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Models
{
    [Table("contacts")]
    public class Contact : BaseEntity
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string category_type { get; set; }
        public string notes { get; set; }
        public ContactPf contact_pf { get; set; }
        public ContactPj contact_pj { get; set; }
        public ContactAddress contact_address { get; set; }
        public ContactInformation contact_information { get; set; }
        public DateTime birthday { get; set; }
    }
}
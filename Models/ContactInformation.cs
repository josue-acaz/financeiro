using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Models
{
    [Table("contact_informations")]
    public class ContactInformation : BaseEntity
    {
        [Key]
        public int id { get; set; }
        public string company_contact_name { get; set; }
        public string work_email { get; set; }
        public string personal_email { get; set; }
        public string phone { get; set; }
        public string mobile { get; set; }
        public int contact_id { get; set; }

        [ForeignKey("contact_id")]
        public Contact contact { get; set; }
    }
}

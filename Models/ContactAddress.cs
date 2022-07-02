using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Models 
{
    [Table("contact_addresses")]
    public class ContactAddress : BaseEntity
    {
        [Key]
        public int id { get; set; }
        public string cep { get; set; }
        public string street { get; set; }
        public string neighborhood { get; set; }
        public string number { get; set; }
        public string complement { get; set; }
        public int? city_id { get; set; }

        [ForeignKey("city_id")]
        public City city { get; set; }
        public int ContactId { get; set; }
        public Contact Contact { get; set; }
    }
}

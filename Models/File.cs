using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Models
{
    [Table("files")]
    public class File : BaseEntity
    {
        [Key]
        public int id { get; set; }
        public long size { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string url { get; set; }
        public string mimetype { get; set; }
        public string resource { get; set; }
        public int resource_id { get; set; }
    }
}
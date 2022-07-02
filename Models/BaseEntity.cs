using System;

namespace Api.Models
{
    public class BaseEntity
    {
        public bool deleted { get; set; }
        public DateTime? created_at { get; set; }
        public DateTime? updated_at { get; set; }
    }
}
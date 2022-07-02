using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Models
{
    [Table("user_settings")]
    public class UserSetting : BaseEntity
    {
        [Key]
        public int id { get; set; }
        public bool is_owner { get; set; }
        public bool has_mei_access { get; set; }
        public bool has_transactions { get; set; }
        public bool show_question_update_date_after_pay { get; set; }
        public bool update_paydate_after_payment { get; set; }
        public bool view_all_cost_centers { get; set; }
        public int user_id { get; set; }

        [ForeignKey("user_id")]
        public User user { get; set; }
    }
}
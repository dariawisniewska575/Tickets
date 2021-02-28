using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tickets.Models
{
    [Table("Tickets")]
    public class TicketModel
    {
        [Key]
        [DisplayName("ID")]
        public int ID { get; set; }
        [DisplayName("Title")]
        [Required(ErrorMessage = "The 'title' field is required ")]
        [MaxLength(50)]
        public string Title { get; set; }
        [MaxLength(2000)]
        [DisplayName("Description")]
        public string Description { get; set; }
        [DisplayName("Date")]
        public DateTime Date { get; set; }
        [DisplayName("Status")]
        public string Status { get; set; }
    }
}

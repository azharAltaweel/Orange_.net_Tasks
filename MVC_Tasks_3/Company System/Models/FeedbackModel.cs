using System.ComponentModel.DataAnnotations;

namespace Company_System.Models
{
    public class FeedbackModel
    {
        public int Id { get; set; }

        [Required]
        public string Email { get; set; }

        public string Message { get; set; }

        public DateTime DateSent { get; set; }


    }
}

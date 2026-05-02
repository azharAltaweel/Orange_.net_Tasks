using System.ComponentModel.DataAnnotations;

namespace Company_System.Models
{
    public class EmployeeTaskModel
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime DueDate { get; set; }

        public string Description { get; set; }

        public string ImportanceLevel { get; set; }

        // العلاقة مع Employee
        public int EmployeeId { get; set; }
        public EmployeeModel Emp { get; set; }
    }
}

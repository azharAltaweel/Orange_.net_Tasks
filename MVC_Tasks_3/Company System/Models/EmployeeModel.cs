using System.ComponentModel.DataAnnotations;

namespace Company_System.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public string PhoneNumber { get; set; }

        public string NationalId { get; set; }

        public string Nationality { get; set; }

        public string MaritalStatus { get; set; }

        public string PersonalPhoto { get; set; }

        public DateTime EntryDate { get; set; }

        [Required]
        public string Password { get; set; }

        // العلاقة مع Department
        public int DepartmentId { get; set; }
        public DepartmentModel Dept { get; set; }

        // العلاقة مع Tasks
        public ICollection<EmployeeTaskModel> Tasks { get; set; }
    }
}

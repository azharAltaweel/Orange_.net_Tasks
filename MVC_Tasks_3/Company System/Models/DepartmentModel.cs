using System.ComponentModel.DataAnnotations;

namespace Company_System.Models
{
    public class DepartmentModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<EmployeeModel> Employees { get; set; }




    }
}

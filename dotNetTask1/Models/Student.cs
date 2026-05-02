using System.ComponentModel.DataAnnotations;


namespace dotNetTask1.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Age is required")]
        [Range(1,int.MaxValue,ErrorMessage ="Age must be greater than 0")]
        public int Age { get; set; }


    }
}

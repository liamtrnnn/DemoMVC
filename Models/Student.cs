using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models
{
    public class Student
    {
        [Required]
        public string FullName { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string University { get; set; }
    }
}
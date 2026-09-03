using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage = " nhập họ tên")]
        public string FullName { get; set; }

        [Required(ErrorMessage = " nhập địa chỉ")]
        public string Address { get; set; }

        [Required(ErrorMessage = " chọn trường đại học")]
        public string University { get; set; }
    }
}
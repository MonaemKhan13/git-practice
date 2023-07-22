using System.ComponentModel.DataAnnotations;

namespace DemoProjectMVC.Models
{
    public class Student:Base
    {
        [Required]
        [MaxLength(30)]
        public string? StudentName { set; get; }

        [Required]
        public DateTimeOffset? StudentDoB { set; get; }

        [Required]
        [MaxLength(30)]
        public string? StudentDepartmentName { set; get; }

    }
}

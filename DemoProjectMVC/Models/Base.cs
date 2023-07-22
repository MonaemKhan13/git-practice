using System.ComponentModel.DataAnnotations;

namespace DemoProjectMVC.Models
{
    public class Base
    {
        [Required]
        public int Id { get; set; }

        public int CreateBy { get; set; }

        public int UpdateBy { get; set; }

        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.Now;

        public DateTimeOffset? UpdatedAt { get; set; }
    }
}

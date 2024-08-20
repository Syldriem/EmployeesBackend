using System.ComponentModel.DataAnnotations;

namespace EmployeesAPI.Models
{
    public class TodoItem
    {
        [Required]
        public long Id { get; set; }
        [Required]
        public string Title { get; set; }
        public bool IsComplete { get; set; }
        public int TimeStamp { get; set; }
        [Required]
        public string Author { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;

namespace OvertimeCop
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        public string PersonNo { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        [Range(0, 9999999)]
        public double HourlyRate { get; set; }
        public int? DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}

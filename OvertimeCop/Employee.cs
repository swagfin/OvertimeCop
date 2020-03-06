using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OvertimeCop
{
    public class Employee
    {
        [Key]
        public int PersonNo { get; set; }
        public string FullName { get; set; }
        public double HourlyRate { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}

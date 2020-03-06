using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OvertimeCop
{
    public class Overtime
    {
        public int Id { get; set; }
        [Required]
        public int EmployeeId { get; set; }
        [Required]
        public DateTime OvertimeStart { get; set; } = DateTime.Now;
        [Required]
        public DateTime OvertimeEnd { get; set; } = DateTime.Now;
        [Required]
        public bool Holiday { get; set; } = false;
        public double HourlyRate { get; set; }
        public double TotalAmount { get; set; } = 0;
        public string WorkOrderNo { get; set; }
        public string Reason { get; set; }
        public string Department { get; set; }


        public int OvertimeHours
        {
            get
            {
                double total_hrs = (OvertimeEnd - OvertimeStart).TotalHours;
                if (total_hrs >= 1)
                    return Convert.ToInt32(total_hrs);
                else
                    return 0;
            }
        }

        public Employee Employee { get; set; }

    }
}

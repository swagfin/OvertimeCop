using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OvertimeCop
{
    public class Overtime
    {
        public int Id { get; set; }
        public DateTime OvertimeStart { get; set; }
        public DateTime OvertimeEnd { get; set; }
        public bool Holiday { get; set; } = false;
        public double HourlyRate { get; set; }
        public string WorkOrderNo { get; set; }
        public string Reason { get; set; }
        public string Department { get; set; }

        public int OvertimeHours
        {
            get
            {
                double total_hrs = (OvertimeStart - OvertimeEnd).TotalHours;
                if (total_hrs >= 1)
                    return Convert.ToInt32(total_hrs);
                else
                    return 0;
            }
        }

    }
}

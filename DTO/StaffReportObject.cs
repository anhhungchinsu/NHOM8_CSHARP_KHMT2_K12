using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class StaffReportObject
    {
        private String staff_id;
        private int? revenue;

        public string Staff_id { get => staff_id; set => staff_id = value; }
        public int? Revenue { get => revenue; set => revenue = value; }
    }
}

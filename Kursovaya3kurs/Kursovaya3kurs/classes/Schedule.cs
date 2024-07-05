using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya3kurs.classes
{
    internal class Schedule
    {
        public int ScheduleId { get; set; }
        public required string? ScheduleTime { get; set; }

        public override string ToString()
        {
            string st = string.Format("{0}", ScheduleTime);
            return st;
        }
    }
}

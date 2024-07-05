using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya3kurs.classes
{
    internal class PaidVisits
    {
        public int PaidVisitsId { get; set; }
        public required string ScheduleTime { get; set; }
        public required DateTime Date {  get; set; }
        public required string SportObjectName { get; set; }
        public required double Price { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya3kurs.classes
{
    internal class Visits
    {
        public int VisitsId { get; set; }
        public required int StudentId { get; set; }
        public required string ScheduleTime { get; set; }
        public required string SportObjectName { get; set; }
        public required DateTime Date {  get; set; }
        public Student? Student { get; set; }
        public string ViewerFio {  get; set; }

        public override string ToString()
        {
            string st = string.Format("{0}. Время: {1}", SportObjectName, ScheduleTime);
            return st;
        }
    }
}

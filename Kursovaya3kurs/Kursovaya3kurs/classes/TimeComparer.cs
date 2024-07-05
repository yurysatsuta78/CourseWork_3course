using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya3kurs.classes
{
    internal class TimeComparer : IComparer<Schedule>
    {
        public int Compare(Schedule x, Schedule y) 
        {
            string[] xParts = x.ScheduleTime.Split("-");
            string[] yParts = y.ScheduleTime.Split("-");
            TimeSpan startTimeX = TimeSpan.Parse(xParts[0]);
            TimeSpan startTimeY = TimeSpan.Parse(yParts[0]);

            int startTimeComparison = startTimeX.CompareTo(startTimeY);
            if (startTimeComparison != 0) 
            {
                return startTimeComparison;
            }
            else
            {
                TimeSpan endTimeX = TimeSpan.Parse(xParts[1]);
                TimeSpan endTimeY = TimeSpan.Parse(yParts[1]);
                return endTimeX.CompareTo(endTimeY);
            }
        }
    }
}

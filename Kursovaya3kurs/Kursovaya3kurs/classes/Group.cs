using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya3kurs.classes
{
    internal class Group
    {
        public int GroupId { get; set; }
        public required string GroupName { get; set; }
        public required string Tutor {  get; set; }
        public ICollection<Student>? Students { get; set; }

        public override string ToString()
        {
            string st = string.Format("{0}. Куратор: {1}", GroupName, Tutor);
            return st;
        }
    }
}

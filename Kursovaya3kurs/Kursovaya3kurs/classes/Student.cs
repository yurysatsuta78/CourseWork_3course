using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya3kurs.classes
{
    internal class Student
    {
        public int StudentId { get; set; }
        public required string Fio { get; set; }

        public int GroupId { get; set; }
        public Group? Group { get; set; }

        public override string ToString()
        {
            string st = string.Format("{0} ({1}) №{2}", Fio, Group.GroupName, StudentId);
            return st;
        }
    }
}

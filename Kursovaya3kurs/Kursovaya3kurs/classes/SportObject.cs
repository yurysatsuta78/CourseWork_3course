using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya3kurs.classes
{
    internal class SportObject
    {
        public int SportObjectId { get; set; }
        public required string? SportObjectName { get; set; }

        public override string ToString()
        {
            string st = string.Format("{0}", SportObjectName);
            return st;
        }
    }
}

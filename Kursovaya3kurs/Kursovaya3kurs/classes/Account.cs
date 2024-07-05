using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya3kurs.classes
{
    internal class Account
    {
        public int AccountId { get; set; }
        public required string Login {  get; set; }
        public required string Password { get; set; }
        public required string Name { get; set; }
        public required int IsAdmin { get; set; }
    }
}

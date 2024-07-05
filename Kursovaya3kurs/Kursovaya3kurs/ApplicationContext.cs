using Kursovaya3kurs.classes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Kursovaya3kurs
{
    internal class ApplicationContext : DbContext
    {
        public DbSet<Student> students => Set<Student>();
        public DbSet<Schedule> schedules => Set<Schedule>();
        public DbSet<SportObject> sportObjects => Set<SportObject>();
        public DbSet<Group> groups => Set<Group>();
        public DbSet<Visits> visits => Set<Visits>();
        public DbSet<PaidVisits> paidVisits => Set<PaidVisits>();
        public DbSet<Account> accounts => Set<Account>();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.LogTo(Console.WriteLine);
            optionsBuilder.UseSqlServer(@"Data Source=Yura-PC;Initial Catalog=newdatabase;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        }
    }
}

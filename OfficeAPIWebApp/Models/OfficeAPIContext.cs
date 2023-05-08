using Microsoft.EntityFrameworkCore;

namespace OfficeAPIWebApp.Models
{
    public class OfficeAPIContext: DbContext
    {
        public OfficeAPIContext(DbContextOptions<OfficeAPIContext> options)
    : base(options)
        {
            Database.EnsureCreated();
        }
        public virtual DbSet<Accountant> Accountants { get; set; }

        public virtual DbSet<Employee> Employees { get; set; }

        public virtual DbSet<Employer> Employers { get; set; }

        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
    }
}

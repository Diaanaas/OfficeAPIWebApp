namespace OfficeAPIWebApp.Models
{
    public class Accountant
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int EmployerId { get; set; }
        public virtual Person Person { get; set; }
        public virtual Employer Employer { get; set; }
    }
}

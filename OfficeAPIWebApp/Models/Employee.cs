namespace OfficeAPIWebApp.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int EmployerId { get; set; }
        public int PositionId { get; set; }
        public virtual Person Person { get; set; }
        public virtual Position Position { get; set; }
    }
}

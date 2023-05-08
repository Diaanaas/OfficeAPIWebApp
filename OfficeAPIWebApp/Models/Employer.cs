namespace OfficeAPIWebApp.Models
{
    public struct Staff
    {
        Employee eemployee;
        bool free;
    };
    public class Employer
    {
        public int Id { get; set; }
        public Person me { get; set; }
        public int volume { get; set; }
        public ICollection<Staff>? Office;
    }
}

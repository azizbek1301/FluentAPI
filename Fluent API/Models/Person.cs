namespace Fluent_API.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public ICollection<Car>? Cars { get; set; }
    }
}

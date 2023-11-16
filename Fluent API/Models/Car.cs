using System.ComponentModel.DataAnnotations.Schema;

namespace Fluent_API.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }

        
        
        public ICollection<PersonCars>? CarPersons { get; set; }
    }
}

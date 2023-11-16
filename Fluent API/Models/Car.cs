using System.ComponentModel.DataAnnotations.Schema;

namespace Fluent_API.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PersonInfoId {  get; set; }
        
        [ForeignKey("PersonInfoId")]
        public Person? Person { get; set; }
    }
}

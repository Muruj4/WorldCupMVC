using System.ComponentModel.DataAnnotations;

namespace WorldCup.Models
{
    public class TransportationCategories
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

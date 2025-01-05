using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

namespace WorldCup.Models
{
    public class Hotels
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Location { get; set; }
        public string City { get; set; }
        public double Price { get; set; }
        public List<string> Facility { get; set; } = new List<string>();

    }
}

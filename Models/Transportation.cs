using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorldCup.Models
{
    public class Transportation
    {
        [Key]
        public int Id { get; set; }
        public int Capacity { get; set; }

        public int vehicle { get; set; }
        public string Color { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public string ModelVersion { get; set; }
        public int Km { get; set; }
    }
}

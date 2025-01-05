using System.ComponentModel.DataAnnotations;

namespace WorldCup.Models
{
    public class Stadiums
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public string City { get; set; }
        public string Type { get; set; }
        public DateTime ConstractionDate { get; set; }
        public string Owner { get; set; }

        public double Length { get; set; }

        public double Width { get; set; }
        public double Height { get; set; }
        public string Image { get; set; }

        public List<string> Facility { get; set; } = new List<string>();
    }
}

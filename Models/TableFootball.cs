using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorldCup.Models
{
    public class TableFootball
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Stadiums")]
        public int Stadiums_id { get; set; }

        public Stadiums Stadium { get; set; }

        public string Team1 { get; set; }
        public string Team2 { get; set; }
        public DateTime MatchTime { get; set; }
    }
}

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WorldCup.Models;
using System;
using System.Collections.Generic;
using WorldCup.Data;

namespace WorldCup.Controllers
{
    public class HomeController : Controller
    {
    
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var Categories = _context.categories.ToList();
            var categories = new List<Categories>
{
    new Categories
    {
        Id = 1,
        Name = "«·„·«⁄»",
        Icon = "<i class=\"fa fa-futbol-o text-success\" aria-hidden=\"true\" style=\"font-size: 100px;\"></i>",
        Url = "Stadiums"
    },
    new Categories
    {
        Id = 2,
        Name = "ÃœÊ· «·„»«—Ì« ",
        Icon = "<i class=\"fa fa-clock-o text-success\" aria-hidden=\"true\" style=\"font-size: 100px;\"></i>",
        Url = "TableFootball"
    },
    new Categories
    {
        Id = 3,
        Name = "«·›‰«œﬁ",
        Icon = "<i class=\"fa fa-bed text-success\" aria-hidden=\"true\" style=\"font-size: 100px;\"></i>",
        Url = "Hotels"
    },
    new Categories
    {
        Id = 4,
        Name = "«·‰ﬁ·",
        Icon = "<i class=\"fa fa-car text-success\" aria-hidden=\"true\" style=\"font-size: 100px;\"></i>",
        Url = "Transportation"
    }
};


            return View(Categories);
        }

        public IActionResult Stadiums()
        {
            var stadiums = new List<Stadiums>
            {
                new Stadiums
                {
                    Id = 1,
                    Name = "„·⁄» «·„·ﬂ ›Âœ «·œÊ·Ì",
                    Capacity = 68752,
                    City = "«·—Ì«÷",
                    Type = "ﬂ—… «·ﬁœ„",
                    ConstractionDate = new DateTime(1987, 6, 18),
                    Owner = "«·ÂÌ∆… «·⁄«„… ··—Ì«÷…",
                    Length = 105,
                    Width = 68,
                    Facility = new List<string> { "„Ê«ﬁ› ”Ì«—« ", "„ÿ«⁄„", "‘«‘… ⁄„·«ﬁ…" },
                    Image = "images/Stadiums.jpg"
                },
                new Stadiums
                {
                    Id = 2,
                    Name = "„·⁄» „œÌ‰… «·„·ﬂ ⁄»œ«··Â «·—Ì«÷Ì… ",
                    Capacity = 65000,
                    City = "Ãœ…",
                    Type = "ﬂ—… «·ﬁœ„",
                    ConstractionDate = new DateTime(1987, 6, 18),
                    Owner = "«·ÂÌ∆… «·⁄«„… ··—Ì«÷…",
                    Length = 105,
                    Width = 68,
                    Facility = new List<string> { "„Ê«ﬁ› ”Ì«—« ", "„ÿ«⁄„", "‘«‘… ⁄„·«ﬁ…" },
                    Image = "images/squer.jpg"
                },
                new Stadiums
                {
                    Id = 3,
                    Name = "„·⁄» «—«„ﬂÊ ",
                    Capacity = 20000,
                    City = "«·œ„«„",
                    Type = "ﬂ—… «·ﬁœ„",
                    ConstractionDate = new DateTime(1987, 6, 18),
                    Owner = "«·ÂÌ∆… «·⁄«„… ··—Ì«÷…",
                    Length = 105,
                    Width = 68,
                    Facility = new List<string> { "„Ê«ﬁ› ”Ì«—« ", "„ÿ«⁄„", "‘«‘… ⁄„·«ﬁ…" },
                    Image = "images/aramco.png"
                }
            };

            return View(stadiums);
        }

        public IActionResult TableFootball()
        {
            //var stadiums = new List<Stadiums>
            //{
            //    new Stadiums
            //    {
            //        Id = 1,
            //        Name = "„·⁄» «·„·ﬂ ›Âœ «·œÊ·Ì"
            //    },
            //    new Stadiums
            //    {
            //        Id = 2,
            //        Name = "„·⁄» „œÌ‰… «·„·ﬂ ⁄»œ«··Â «·—Ì«÷Ì…"
            //    },
            //    new Stadiums
            //    {
            //        Id = 3,
            //        Name = "„·⁄» «—«„ﬂÊ"
            //    }
            //};

            //var matches = new List<TableFootball>
            //{
            //    new TableFootball
            //    {
            //        Id = 1,
            //        Team1 = "«·”⁄ÊœÌ…",
            //        Team2 = "›—‰”«",
            //        MatchTime = new DateTime(2034, 1, 12, 20, 0, 0),
            //        Stadiums_id = 1
            //    },
            //    new TableFootball
            //    {
            //        Id = 2,
            //        Team1 = "«·√—Ã‰ Ì‰",
            //        Team2 = "√·„«‰Ì«",
            //        MatchTime = new DateTime(2034, 1, 13, 21, 0, 0),
            //        Stadiums_id = 2
            //    },
            //    new TableFootball
            //    {
            //        Id = 3,
            //        Team1 = "≈”»«‰Ì«",
            //        Team2 = "«·»—«“Ì·",
            //        MatchTime = new DateTime(2034, 1, 14, 22, 0, 0),
            //        Stadiums_id = 3
            //    },
            //    new TableFootball
            //    {
            //        Id = 4,
            //        Team1 = "„’—",
            //        Team2 = "«·Ì«»«‰",
            //        MatchTime = new DateTime(2034, 1, 15, 20, 0, 0),
            //        Stadiums_id = 1
            //    },
            //    new TableFootball
            //    {
            //        Id = 5,
            //        Team1 = "≈Ìÿ«·Ì«",
            //        Team2 = "»·ÃÌﬂ«",
            //        MatchTime = new DateTime(2034, 1, 16, 21, 0, 0),
            //        Stadiums_id = 2
            //    },
            //    new TableFootball
            //    {
            //        Id = 6,
            //        Team1 = "«·»— €«·",
            //        Team2 = "ÂÊ·‰œ«",
            //        MatchTime = new DateTime(2034, 1, 17, 22, 0, 0),
            //        Stadiums_id = 3
            //    },
            //    new TableFootball
            //    {
            //        Id = 7,
            //        Team1 = "≈‰Ã· —«",
            //        Team2 = "«·»— €«·",
            //        MatchTime = new DateTime(2034, 1, 18, 20, 0, 0),
            //        Stadiums_id = 1
            //    },
            //    new TableFootball
            //    {
            //        Id = 8,
            //        Team1 = "›—‰”«",
            //        Team2 = "«·»—«“Ì·",
            //        MatchTime = new DateTime(2034, 1, 19, 21, 0, 0),
            //        Stadiums_id = 2
            //    },
            //    new TableFootball
            //    {
            //        Id = 9,
            //        Team1 = "«·„€—»",
            //        Team2 = "≈”»«‰Ì«",
            //        MatchTime = new DateTime(2034, 1, 20, 22, 0, 0),
            //        Stadiums_id = 3
            //    },
            //    new TableFootball
            //    {
            //        Id = 10,
            //        Team1 = "„’—",
            //        Team2 = "≈Ìÿ«·Ì«",
            //        MatchTime = new DateTime(2034, 1, 21, 20, 0, 0),
            //        Stadiums_id = 1
            //    }
            //};

            //foreach (var match in matches)
            //{
            //    match.Stadium = stadiums.Find(s => s.Id == match.Stadiums_id);
            //}

            return View();
        }
        public IActionResult Transportation()
        {
            var transportation = new List<Transportation>
    {
        new Transportation
        {
            Id = 1,
            Name = "ﬁÿ«—",
            Capacity = 300,
            Color = "√Õ„—",
            Image = "images/train.jpg",
            Model = "2024",
            ModelVersion = "V1",
            Km = 120,
            
        },
        new Transportation
        {
            Id = 2,
            Name = "ÿ«∆—Â",
            Capacity = 150,
            Color = "√»Ì÷",
            Image = "images/plane.jpg",
            Model = "2020",
            ModelVersion = "V1",
            Km = 8000,
           
        },
        new Transportation
        {
            Id = 3,
            Name = "”Ì«—… «Ã—Â",
            Capacity = 4,
            Color = "«Œ÷—",
            Image = "images/taxi.png",
            Model = "2024",
            ModelVersion = "V1",
            Km = 40,
            
        }
    };

            return View(transportation);
        }
        public IActionResult Hotels()
        {

            var hotels = _context.hotels;
           
     
            return View(hotels);
        }
    


public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

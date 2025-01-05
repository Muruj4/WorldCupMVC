using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WorldCup.Models;
using System;
using System.Collections.Generic;

namespace WorldCup.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var categories = new List<Categories>
{
    new Categories
    {
        Id = 1,
        Name = "�������",
        Icon = "<i class=\"fa fa-futbol-o text-success\" aria-hidden=\"true\" style=\"font-size: 100px;\"></i>",
        Url = "Stadiums"
    },
    new Categories
    {
        Id = 2,
        Name = "���� ���������",
        Icon = "<i class=\"fa fa-clock-o text-success\" aria-hidden=\"true\" style=\"font-size: 100px;\"></i>",
        Url = "TableFootball"
    },
    new Categories
    {
        Id = 3,
        Name = "�������",
        Icon = "<i class=\"fa fa-bed text-success\" aria-hidden=\"true\" style=\"font-size: 100px;\"></i>",
        Url = "Hotels"
    },
    new Categories
    {
        Id = 4,
        Name = "�����",
        Icon = "<i class=\"fa fa-car text-success\" aria-hidden=\"true\" style=\"font-size: 100px;\"></i>",
        Url = "Transportation"
    }
};

            return View(categories);
        }

        public IActionResult Stadiums()
        {
            var stadiums = new List<Stadiums>
            {
                new Stadiums
                {
                    Id = 1,
                    Name = "���� ����� ��� ������",
                    Capacity = 68752,
                    City = "������",
                    Type = "��� �����",
                    ConstractionDate = new DateTime(1987, 6, 18),
                    Owner = "������ ������ �������",
                    Length = 105,
                    Width = 68,
                    Facility = new List<string> { "����� ������", "�����", "���� ������" },
                    Image = "images/Stadiums.jpg"
                },
                new Stadiums
                {
                    Id = 2,
                    Name = "���� ����� ����� ������� �������� ",
                    Capacity = 65000,
                    City = "���",
                    Type = "��� �����",
                    ConstractionDate = new DateTime(1987, 6, 18),
                    Owner = "������ ������ �������",
                    Length = 105,
                    Width = 68,
                    Facility = new List<string> { "����� ������", "�����", "���� ������" },
                    Image = "images/squer.jpg"
                },
                new Stadiums
                {
                    Id = 3,
                    Name = "���� ������ ",
                    Capacity = 20000,
                    City = "������",
                    Type = "��� �����",
                    ConstractionDate = new DateTime(1987, 6, 18),
                    Owner = "������ ������ �������",
                    Length = 105,
                    Width = 68,
                    Facility = new List<string> { "����� ������", "�����", "���� ������" },
                    Image = "images/aramco.png"
                }
            };

            return View(stadiums);
        }

        public IActionResult TableFootball()
        {
            var stadiums = new List<Stadiums>
            {
                new Stadiums
                {
                    Id = 1,
                    Name = "���� ����� ��� ������"
                },
                new Stadiums
                {
                    Id = 2,
                    Name = "���� ����� ����� ������� ��������"
                },
                new Stadiums
                {
                    Id = 3,
                    Name = "���� ������"
                }
            };

            var matches = new List<TableFootball>
            {
                new TableFootball
                {
                    Id = 1,
                    Team1 = "��������",
                    Team2 = "�����",
                    MatchTime = new DateTime(2034, 1, 12, 20, 0, 0),
                    Stadiums_id = 1
                },
                new TableFootball
                {
                    Id = 2,
                    Team1 = "���������",
                    Team2 = "�������",
                    MatchTime = new DateTime(2034, 1, 13, 21, 0, 0),
                    Stadiums_id = 2
                },
                new TableFootball
                {
                    Id = 3,
                    Team1 = "�������",
                    Team2 = "��������",
                    MatchTime = new DateTime(2034, 1, 14, 22, 0, 0),
                    Stadiums_id = 3
                },
                new TableFootball
                {
                    Id = 4,
                    Team1 = "���",
                    Team2 = "�������",
                    MatchTime = new DateTime(2034, 1, 15, 20, 0, 0),
                    Stadiums_id = 1
                },
                new TableFootball
                {
                    Id = 5,
                    Team1 = "�������",
                    Team2 = "������",
                    MatchTime = new DateTime(2034, 1, 16, 21, 0, 0),
                    Stadiums_id = 2
                },
                new TableFootball
                {
                    Id = 6,
                    Team1 = "��������",
                    Team2 = "������",
                    MatchTime = new DateTime(2034, 1, 17, 22, 0, 0),
                    Stadiums_id = 3
                },
                new TableFootball
                {
                    Id = 7,
                    Team1 = "�������",
                    Team2 = "��������",
                    MatchTime = new DateTime(2034, 1, 18, 20, 0, 0),
                    Stadiums_id = 1
                },
                new TableFootball
                {
                    Id = 8,
                    Team1 = "�����",
                    Team2 = "��������",
                    MatchTime = new DateTime(2034, 1, 19, 21, 0, 0),
                    Stadiums_id = 2
                },
                new TableFootball
                {
                    Id = 9,
                    Team1 = "������",
                    Team2 = "�������",
                    MatchTime = new DateTime(2034, 1, 20, 22, 0, 0),
                    Stadiums_id = 3
                },
                new TableFootball
                {
                    Id = 10,
                    Team1 = "���",
                    Team2 = "�������",
                    MatchTime = new DateTime(2034, 1, 21, 20, 0, 0),
                    Stadiums_id = 1
                }
            };

            foreach (var match in matches)
            {
                match.Stadium = stadiums.Find(s => s.Id == match.Stadiums_id);
            }

            return View(matches);
        }
        public IActionResult Transportation()
        {
            var transportation = new List<Transportation>
    {
        new Transportation
        {
            Id = 1,
            Name = "����",
            Capacity = 300,
            Color = "����",
            Image = "images/train.jpg",
            Model = "2024",
            ModelVersion = "V1",
            Km = 120,
            vehicle = new TransportationCategories { Id = 1, Name = "����" }
        },
        new Transportation
        {
            Id = 2,
            Name = "�����",
            Capacity = 150,
            Color = "����",
            Image = "images/plane.jpg",
            Model = "2020",
            ModelVersion = "V1",
            Km = 8000,
            vehicle = new TransportationCategories { Id = 2, Name = "�����" }
        },
        new Transportation
        {
            Id = 3,
            Name = "����� ����",
            Capacity = 4,
            Color = "����",
            Image = "images/taxi.png",
            Model = "2024",
            ModelVersion = "V1",
            Km = 40,
            vehicle = new TransportationCategories { Id = 3, Name = "����� ����" }
        }
    };

            return View(transportation);
        }
        public IActionResult Hotels()
        {
            var hotels = new List<Hotels>
            {
                new Hotels
                {
                    Id = 1,
                    Name = "Paradise Elite Hotel",
                    Description = "Luxurious 5-star hotel with a beautiful view.",
                    Image = "images/jeddah.jpg",
                    Location = "0.7 km from downtown",
                    City = "Jeddah",
                    Price = 1450,
                    Facility = new List<string> { "Free Wifi", "Pool", "Gym", "Restaurant" }
                },
                new Hotels
                {
                    Id = 2,
                    Name = "Haven Plaza Hotel",
                    Description = "Excellent stay with modern amenities.",
                    Image = "images/riyadh.jpg",
                    Location = "1.2 km from downtown",
                    City = "Riyadh",
                    Price = 2500,
                    Facility = new List<string> { "Free Wifi", "Spa", "Gym", "Bar" }
                },
                new Hotels
                {
                    Id = 3,
                    Name = "Tripper Inn Hotel",
                    Description = "Comfortable and affordable with great services.",
                    Image = "images/dammam.jpg",
                    Location = "0.5 km from downtown",
                    City = "Dammam",
                    Price = 3000,
                    Facility = new List<string> { "Free Wifi", "Parking", "Restaurant" }
                }
            };

     
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

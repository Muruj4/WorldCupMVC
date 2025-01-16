using System.Security.Cryptography.Xml;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using WorldCup.Data;
using WorldCup.Models;

namespace WorldCup.Controllers
{
    public class DashboardController : Controller
    {

        private readonly ApplicationDbContext _context;
        private IWebHostEnvironment _webHostEnvironment;

        public DashboardController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;

            _context = context;
        }
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
        // pass 3!Wgx/uuVb3#_wr
        public IActionResult Categories(string name)
        {

            if (name != null)
            {
                var search = _context.categories.Where(p => p.Name.Contains(name)).ToList();
                return View(search);
            }

            var getdata = _context.categories.ToList();

            return View(getdata);

        }

        public IActionResult CreateNewCategories(Categories categories)
        {
            if (ModelState.IsValid)
            {
                _context.Add(categories);
                _context.SaveChanges();

                TempData["save"] = "تمت عملية الحفظ";
                return RedirectToAction("Categories");
            }
            else
            {
                TempData["save"] = "لم تتم عملية الحفظ";

                return View("Categories");
            }


        }
        public IActionResult DeleteCategory(int id)
        {
            var category = _context.categories.SingleOrDefault(c => c.Id == id); //search
            if (category != null)
            {
                _context.categories.Remove(category);
                _context.SaveChanges();
            }

            return RedirectToAction("Categories");

        }

        public IActionResult DeleteHotels(int id)
        {
            var hotel = _context.categories.SingleOrDefault(c => c.Id == id); //search
            if (hotel != null)
            {
                _context.categories.Remove(hotel);
                _context.SaveChanges();
            }

            return RedirectToAction("Hotels");

        }
        public IActionResult TransportationCategories()
        {
            var getdata = _context.transportationcategoriess.ToList();

            return View(getdata);


        }
        public IActionResult CreateNewTransportationCategories(TransportationCategories Tcategories)
        {

            _context.Add(Tcategories);
            _context.SaveChanges();
            return RedirectToAction("TransportationCategories");


        }
        public IActionResult Hotels()

        {

            var getdata = _context.hotels.ToList();

            return View(getdata);


        }
        public IActionResult CreateNewHotels(Hotels hotels, IFormFile photo)
        {
            if (photo == null || photo.Length == 0)
            {
                return Content("File not selected");
            }
            var path = Path.Combine(_webHostEnvironment.WebRootPath, "images", photo.FileName);
            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                photo.CopyTo(stream);
                stream.Close();
            }
            hotels.Image = photo.FileName;
            _context.Add(hotels);
            _context.SaveChanges();
            return RedirectToAction("Hotels");


        }
        public IActionResult Transportations()
        {
            var getdata = _context.transportationcategoriess.ToList();
            ViewBag.getdata1 = getdata;
            var transport = _context.transportation.ToList();
            var getdatatransport = _context.transportation.Join( //FK
                _context.transportationcategoriess,//PK
                transportation => transportation.vehicle,
                transportationcategoriess => transportationcategoriess.Id,

                (transportation, transportationcategoriess) => new
                {
                    Id = transportation.Id,
                    NameCar = transportation.Name,
                    NameCategory = transportationcategoriess.Name,
                    capacity = transportation.Capacity,
                    color = transportation.Color,
                    image = transportation.Image,
                    model = transportation.Model,
                    Km = transportation.Km

                }

                ).ToList();
            ViewBag.getdata = getdatatransport;



            return View(transport);
        }
        public IActionResult CreateNewTransport(Transportation transport, IFormFile photo)
        {

            if (photo == null || photo.Length == 0)
            {
                return Content("File not selected");
            }
            var path = Path.Combine(_webHostEnvironment.WebRootPath, "images", photo.FileName);
            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                photo.CopyTo(stream);
                stream.Close();
            }
            transport.Image = photo.FileName;
            _context.Add(transport);
            _context.SaveChanges();
            return RedirectToAction("Transportations");
        }
        public IActionResult edit_categories(int id)
        {
            var edit = _context.categories.SingleOrDefault(c => c.Id == id);
            return View(edit);
        }
        public IActionResult update_categories(Categories categories) {

            _context.categories.Update(categories);
            _context.SaveChanges();
            return RedirectToAction("Categories");


        }
       

        public IActionResult Stadiums(string name)
        {
            var stadiumsQuery = _context.stadiums.AsQueryable();

            if (!string.IsNullOrEmpty(name))
            {
                stadiumsQuery = stadiumsQuery.Where(s => s.Name.Contains(name));
            }

            var getdata = stadiumsQuery.ToList();

            return View(getdata);
        }



        [HttpPost]
        public IActionResult CreateNewStadium(Stadiums stadium, IFormFile photo)
        {

            if (photo == null || photo.Length == 0)
            {
                return Content("File not selected");
            }
            var path = Path.Combine(_webHostEnvironment.WebRootPath, "images", photo.FileName);
            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                photo.CopyTo(stream);
                stream.Close();
            }
            stadium.Image = photo.FileName;
            _context.Add(stadium);
            _context.SaveChanges();
            return RedirectToAction("Stadiums");
        }

        public IActionResult DeleteStadium(int id)
        {
            var stadium = _context.stadiums.SingleOrDefault(c => c.Id == id); //search
            if (stadium != null)
            {
                _context.stadiums.Remove(stadium);
                _context.SaveChanges();
            }

            return RedirectToAction("Stadiums");

        }
        public IActionResult edit_stadiums(int id)
        {
            var edit = _context.stadiums.SingleOrDefault(c => c.Id == id);
            return View(edit);
        }
        [HttpPost]
        [HttpPost]
        public IActionResult update_stadiums(Stadiums stadium, IFormFile photo)
        {
            if (stadium.Id == 0)
            {
                return NotFound();
            }

            var existingStadium = _context.stadiums.FirstOrDefault(s => s.Id == stadium.Id);
            if (existingStadium == null)
            {
                return NotFound();
            }

            if (photo != null && photo.Length > 0)
            {
                var oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, "images", existingStadium.Image);
                if (System.IO.File.Exists(oldImagePath))
                {
                    System.IO.File.Delete(oldImagePath);
                }

                var path = Path.Combine(_webHostEnvironment.WebRootPath, "images", photo.FileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    photo.CopyTo(stream);
                }
                existingStadium.Image = photo.FileName;
            }

            existingStadium.Name = stadium.Name;
            existingStadium.Capacity = stadium.Capacity;
            existingStadium.City = stadium.City;
            existingStadium.Type = stadium.Type;
            existingStadium.Owner = stadium.Owner;
            existingStadium.Length = stadium.Length;
            existingStadium.Width = stadium.Width;
            existingStadium.Height = stadium.Height;

            _context.stadiums.Update(existingStadium);
            _context.SaveChanges();

            return RedirectToAction("Stadiums");
        }



        public IActionResult CreateNewTableFootball(TableFootball tableFootball)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tableFootball);
                _context.SaveChanges();
                TempData["save"] = "تمت عملية الحفظ";
                return RedirectToAction("TableFootball");
            }
            else
            {
                TempData["save"] = "لم تتم عملية الحفظ";
                return View("TableFootball");
            }
        }

        public IActionResult TableFootball(string teamName)
        {
            var getdata = _context.stadiums.ToList();
            ViewBag.getdata1 = getdata;

            var tableFootballMatches = _context.tableFootballs.AsQueryable();

            if (!string.IsNullOrEmpty(teamName))
            {
                
                tableFootballMatches = tableFootballMatches.Where(m => m.Team1.Contains(teamName) || m.Team2.Contains(teamName));
            }

            var gettableFootballMatches = tableFootballMatches.Join(
                _context.stadiums,
                tablefootabll => tablefootabll.Stadiums_id,
                stadium => stadium.Id,
                (tablefootabll, stadium) => new
                {
                    Id = tablefootabll.Id,
                    Team1 = tablefootabll.Team1,
                    Team2 = tablefootabll.Team2,
                    MatchTime = tablefootabll.MatchTime,
                    StadiumName = stadium.Name,
                }).ToList();

            ViewBag.getdata = gettableFootballMatches;

            return View(tableFootballMatches.ToList());
        }

        public IActionResult DeleteTable(int id)
        {
            var table = _context.tableFootballs.SingleOrDefault(c => c.Id == id); 
            if (table != null)
            {
                _context.tableFootballs.Remove(table);
                _context.SaveChanges();
            }

            return RedirectToAction("TableFootball");

        }
    
    
        public IActionResult edit_tablefootball(int id)
        {

            var edit = _context.tableFootballs.SingleOrDefault(c => c.Id == id);
            return View(edit);
        }

        [HttpPost]
        public IActionResult update_table(TableFootball table)
        {
            if (table == null || table.Id == 0)
            {
                return NotFound();
            }

           
            var existingTable = _context.tableFootballs.Find(table.Id);
            if (existingTable == null)
            {
                return NotFound();
            }

           
            existingTable.Team1 = table.Team1;
            existingTable.Team2 = table.Team2;
            existingTable.MatchTime = table.MatchTime;

           
            _context.SaveChanges();
            return RedirectToAction("TableFootball");
        }










    }
}
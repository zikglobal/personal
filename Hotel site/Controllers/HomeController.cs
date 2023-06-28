using Hotel.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Hotel.Controllers;
namespace Hotel.Controllers
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
            var Allproperties = ReadPropertiesFromFile("Database.txt");
            var mostpicks = Allproperties.Where(property => property.Group == "Most Picks").ToList();
            ViewData["Most"] = mostpicks;

            //var Allproperties = ReadPropertiesFromFile("Database.txt");
            var housewithbeautifulbackyard = Allproperties.Where(property => property.Group == "Houses With Beautiful Backyard").ToList();
            ViewData["BeautifulBackyard"] = housewithbeautifulbackyard;

            var Largelivingroom = Allproperties.Where(property => property.Group == "Hotels With Large Living Rooms").ToList();
            ViewData["LargeRoom"] = Largelivingroom;

            var Kitchenset = Allproperties.Where(property => property.Group == "Apartments With Kitchen Set").ToList();
            ViewData["Kitchen"] = Kitchenset;


            return View();
        }
        public IActionResult Browseby()
        {
            return View();
        }
        public IActionResult Stories()
        {
            return View();
        }
        public IActionResult Agents()
        {
            return View();
        }









        public static List<Property> ReadPropertiesFromFile(string filePath)
        {
            List<Property> properties = new List<Property>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        string[] fields = line.Split('|');

                        if (fields.Length >= 6)
                        {
                            string Location = fields[1].Trim();
                            string Propname = fields[2].Trim();
                            string Price = fields[3].Trim();
                            string Pic = fields[4].Trim();
                            string Group = fields[5].Trim();
                           
                            string popularity = fields[6].Trim();

                            Property property = new Property(Location,Propname,Price,Pic,Group, popularity);
                            properties.Add(property);
                        }
                    }
                }
            }

            return properties;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
            public IActionResult Error()
            {
                return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }
        }
   
    }  

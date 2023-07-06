using Microsoft.AspNetCore.Mvc;
using Hotels.Models;
namespace Hotels.Controllers

{
	public class HotelController : Controller
	{
        private readonly HotelDbContext _context;

        public HotelController(HotelDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
		{
            var hotels = _context.Hotels.ToList();

            return View(hotels);
		}

        public IActionResult view(int id)
        {
            var hotel = _context.Hotels.FirstOrDefault(h => h.Id == id);
            return View(hotel);
        }

        public IActionResult createHotel() {

			return View();
				
		}
        [HttpPost]
        public async Task<IActionResult> Create(Hotel hotel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hotel);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Hotel");
            }

            return Ok(hotel);
        }

        public IActionResult About()
        {
            return View();
        }
    }
}

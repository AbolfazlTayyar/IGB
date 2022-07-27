using IGB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;

namespace IGB.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly AppDbContext _context;

		public HomeController(ILogger<HomeController> logger, AppDbContext context)
		{
			_logger = logger;
			_context = context;
		}

		public IActionResult Index()
		{
			ViewBag.Services = new SelectList(_context.Services.ToList(), "Id", "Name");
			return View();
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

		[HttpPost]
		public IActionResult Create(AddVM vm)
		{
			foreach (var service in vm.ServiceIds)
			{
				var newPatientServices = new Patient_Services()
				{
					PatientId = vm.PatientId,
					ServiceId = service
				};
				_context.Patient_Services.Add(newPatientServices);
			}

			_context.SaveChanges();
			return View();
		}
	}
}
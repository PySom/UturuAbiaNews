using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UturuAbiaNews.Data;
using UturuAbiaNews.Models;

namespace UturuAbiaNews.Controllers
{
	public class HomeViewModel
	{
		
		public ICollection<Content> Headlines { get; set; }
		public ICollection<Category> Categories { get; set; }

	}
    public class HomeController : Controller
    {
		private ApplicationDbContext _context;
		public HomeController(ApplicationDbContext context)
		{
			_context = context;
		}
        public IActionResult Index()
        {
			List<Content> contents = _context.Content.Include(c => c.Category).ToList();

			HomeViewModel catcont = new HomeViewModel();
			catcont.Headlines = new List<Content>();
			catcont.Categories = new List<Category>();
			foreach (Content content in contents)
			{
				if (content.IsHeadline)
					catcont.Headlines.Add(content);

				else
					catcont.Categories.Add(content.Category);

			}
			return View(catcont);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
    }
}

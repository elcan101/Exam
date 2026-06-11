using Health_Center.Data;
using Health_Center.Models;
using Health_Center.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Health_Center.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeVM viewModel = new HomeVM();
            viewModel.doctors = _context.Doctors.ToList();

            return View(viewModel);
        }


    }
}

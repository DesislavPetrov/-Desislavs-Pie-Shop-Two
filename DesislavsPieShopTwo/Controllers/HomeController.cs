using Microsoft.AspNetCore.Mvc;
using DesislavsPieShopTwo.Models;
using System.Linq;
using DesislavsPieShopTwo.ViewModels;

namespace DesislavsPieShopTwo.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;

        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }
        
        public IActionResult Index()
        {
            var pies = _pieRepository.GetAllPies().OrderBy(p => p.Name);

            var homeViewModel = new HomeViewModel()
            {
                Title = "Welcome to Desislav's Pie Shop",
                Pies = pies.ToList()
            };

            return View(homeViewModel);
        }
    }
}

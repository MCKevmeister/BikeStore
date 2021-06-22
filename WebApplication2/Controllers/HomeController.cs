using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Threading.Tasks;
using BikeStoreApi.Repositories;
using BikeStoreApi.UnitOfWork;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly IManufacturerRepository _manufacturerRepository;
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(IUnitOfWork unitOfWork, IManufacturerRepository manufacturerRepository)
        {
            _unitOfWork = unitOfWork;
            _manufacturerRepository = manufacturerRepository;
        }

        public async Task<IActionResult> Index()
        {
            var model = new ManufacturersViewModel
            {
                Title = "Manufacturers", 
                Manufacturers = await _manufacturerRepository.GetAll()
            };
            return View(model);
        }

        public async Task<IActionResult> Manufacturer(string id)
        {
            var model = new ManufacturerViewModel()
            {
                Title = "Manufacturer",
                Manufacturer = await _manufacturerRepository.GetById(id)
            };
            return View(model);
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

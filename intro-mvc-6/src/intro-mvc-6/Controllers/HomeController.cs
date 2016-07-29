using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using intro_mvc_6.Models;
using Microsoft.AspNet.Mvc;

namespace intro_mvc_6.Controllers
{
    public class HomeController : Controller
    {

        private IApplicationRepository _repository;

        public HomeController(IApplicationRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            var todos = _repository.GetAllToDos();
            return View(AutoMapper.Mapper.Map(todos, new List<ViewModels.ToDoViewModel>()));
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

        public IActionResult Error()
        {
            return View();
        }
    }
}

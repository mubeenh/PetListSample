using PetFinder.Common;
using PetFinder.Models;
using PetFinder.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PetFinder.Controllers
{
    public class HomeController : Controller
    {
        private PetFinderService PetFinderService;

        public HomeController()
        {
            // DI would be nice but for now this should do :)
            PetFinderService = new PetFinderService(new WebClientFactory());
        }

        [HandleError]
        public ActionResult Index()
        {
            PetsViewModel vm = new PetsViewModel();
            vm.People = PetFinderService.GetPeople();

            return View(vm);
        }
    }
}
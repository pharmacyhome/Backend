using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmacyHome.Web.Controllers
{
       
    public class SearchController : Controller
    {
        private readonly IMedicineRepository medicineRepository;
        public SearchController(IMedicineRepository medicineRepository)
        {
            this.medicineRepository = medicineRepository;
        }

        public IActionResult Index(string query)
        {
            var medicine = medicineRepository.GetAllByTitle(query);
            return View(medicine);
        }
    }
}

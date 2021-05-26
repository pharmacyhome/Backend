using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmacyHome.Web.Controllers
{
       
    public class SearchController : Controller
    {
        private readonly MedicineService medicineService;
        public SearchController(MedicineService medicineService)
        {
            this.medicineService = medicineService;
        }

        public IActionResult Index(string query)
        {
            var medicine = medicineService.GetAllByQuery(query);

            return View(medicine);
        }
    }
}

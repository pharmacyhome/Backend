using Microsoft.AspNetCore.Mvc;

namespace PharmacyHome.Web.Controllers
{
    public class MedicineController : Controller
    {
        private readonly IMedicineRepository medicineRepository;

        public MedicineController(IMedicineRepository medicineRepository)
        {
            this.medicineRepository = medicineRepository;
        }
        public IActionResult Index(int id)
        {
            Medicine medicine = medicineRepository.GetById(id);

            return View(medicine);
        }
    }
}

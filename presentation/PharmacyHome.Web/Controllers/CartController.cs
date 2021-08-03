using Microsoft.AspNetCore.Mvc;
using PharmacyHome.Web.Models;

namespace PharmacyHome.Web.Controllers
{
    public class CartController : Controller
    {
        private readonly IMedicineRepository medicineRepository;

        public CartController(IMedicineRepository medicineRepository)
        {
            this.medicineRepository = medicineRepository;
        }
        public IActionResult Add(int id)
        {
            var medicine = medicineRepository.GetById(id);
            Cart cart;
            if (!HttpContext.Session.TryGetCart(out cart))
                cart = new Cart();

            if (cart.Items.ContainsKey(id))
            {
                cart.Items[id]++;
                cart.Amount += medicine.Dosage;
            }
            else
                cart.Items[id] = 1;

            cart.Amount += medicine.Dosage;

            HttpContext.Session.Set(cart);

            return RedirectToAction("Index", "Medicine", new { id});
        }
    }
}

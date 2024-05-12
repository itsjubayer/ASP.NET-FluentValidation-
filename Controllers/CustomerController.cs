using Microsoft.AspNetCore.Mvc;
using WebFluentValidation.Models;

namespace WebFluentValidation.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CustomerModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            //TODO: Save the customer to the database.

            return Ok();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Unit_Of_Work.Infrastructure.Interfaces;

namespace Unit_Of_Work_Rep_UI.Controllers
{
    public class ProductsController1 : Controller
    {
        private readonly IProductRepository productRepo;

        public ProductsController1(IProductRepository productRepo)
        {
            this.productRepo = productRepo;
        }

        public async Task<IActionResult> Index()
        {
            var products = await productRepo.GetaAll();
            return View(products);
        }
    }
}

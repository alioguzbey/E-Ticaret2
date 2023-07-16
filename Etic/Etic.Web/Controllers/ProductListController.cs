using Etic.Business.ControllerHandler;
using Microsoft.AspNetCore.Mvc;

namespace Etic.Web.Controllers
{
    public class ProductListController : Controller
    {
        private IProductListControllerHandler _productListControllerHandler;

        public ProductListController(IProductListControllerHandler productListControllerHandler)
        {
            _productListControllerHandler = productListControllerHandler;
        }

        public IActionResult Index(string name,int? page = 0)
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Store.Application.Interfaces;
using Store.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Web.Mvc.Controllers
{
    public class ProductsController : Controller
    {
        private IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index()
        {
            ProductViewModel model = _productService.GetProducts();
            return View(model);
        }
    }
}

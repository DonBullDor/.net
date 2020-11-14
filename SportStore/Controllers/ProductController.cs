using SportStore.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportStore.Controllers
{
    public class ProductController : Controller
    {
        private IProductsRepository repository;
        
        public ProductController(IProductsRepository productsRepository)
        {
            this.repository = productsRepository;
        }
        public ActionResult Index()
        {
            return View();
        }

        public ViewResult List()
        {
            return View(repository.Products);   
        }
    }
}
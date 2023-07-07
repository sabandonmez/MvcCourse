using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Repositories;
using Repositories.Contracts;

namespace StoreApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IRepositoryManager _repositoryManager;

        public ProductController(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public IActionResult Index()
        {
            var model = _repositoryManager.Product.GetAllProducts(false);
            return View(model);
        }
        public IActionResult Get(int id)
        {
            var model = _repositoryManager.Product.GetOneProduct(id, false);
            return View(model);
        }

    }
}
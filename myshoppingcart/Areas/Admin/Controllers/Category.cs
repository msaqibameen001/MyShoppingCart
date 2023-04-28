using Microsoft.AspNetCore.Mvc;
using ShoppingCart.DataAccess.Repositories;
using ShoppingCart.DataAccess.ViewModels;

namespace myshoppingcart.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
      private IUnitOfWork _unitOfWork;

        public CategoryController(IUnitOfWork unitOfWork ) 
        {
            _unitOfWork = unitOfWork;
        
        }
        public IActionResult Index()
        {
            CategoryVM categoryVM = new CategoryVM();
            categoryVM.categories=_unitOfWork.Category.GetAll();
            return View(categoryVM);
        }

    }
}

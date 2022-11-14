using KamalsBooks.DataAccess.Repository.IRepository;
using KamalsBookStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using KamalsBooks.Models;


namespace KamalsBookStore.Area.Admin.Controllers
{
    [Area("Admin")]

    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult upsert(int? id)
        {
            Category category = new Category();
            if (id == null)
            {
                return View(category);

            }
            category = _unitOfWork.Category.Get(id.GetValueOrDefault());
            if (category == null)
            {
                return NotFound();
            }
            return View();
        }

        #region API CALLS
        [HttpGet]

        public IActionResult GetAll()
        {
            var allobj = _unitOfWork.Category.GetAll();
            return Json(new { data = allobj });
        }

        #endregion
    }


}

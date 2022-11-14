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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Category category)
        {
            if (ModelState.IsValid)
            {
                if (category.Id == 0)

                {
                    _unitOfWork.Category.Add(category);
                    _unitOfWork.Save();

                }
                else
                {
                    _unitOfWork.Category.Update(category);
                }
                
                
            }
            return View(category);
        }





        #region API CALLS
        [HttpGet]

        public IActionResult GetAll()
        {
            var allobj = _unitOfWork.Category.GetAll();
            return Json(new { data = allobj });
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var objFromDb = _unitOfWork.Category.Get(id);
            if (objFromDb == null)
            {
                return Json(new { success = false, message = "Error while deleting" });

            }
            _unitOfWork.Category.Remove(objFromDb);
            _unitOfWork.Save();
            return Json(new { success = true, messasge = "Delete successful" });
        }

        #endregion
    }


}

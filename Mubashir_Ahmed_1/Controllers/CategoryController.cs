using Microsoft.AspNetCore.Mvc;
using Mubashir_Ahmed_1.Data;
using Mubashir_Ahmed_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mubashir_Ahmed_1.Controllers
{
    public class CategoryController : Controller
    {

        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
            IEnumerable<Category> objlist = _db.Category;
            return View(objlist);
        }

        // GET Method
        public IActionResult Create()
        {
            return View();
        }

        // POST Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category obj)
        {
            _db.Category.Add(obj);
            _db.SaveChanges();

            return RedirectToAction("Index"); 
        }

    }
}

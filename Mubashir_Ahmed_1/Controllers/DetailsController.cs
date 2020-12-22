using Microsoft.AspNetCore.Mvc;
using Mubashir_Ahmed_1.Data;
using Mubashir_Ahmed_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mubashir_Ahmed_1.Controllers
{
    public class DetailsController : Controller
    {
        private readonly ApplicationDbContext _db;

        public DetailsController(ApplicationDbContext db)
        {
            _db = db;

        }



        public IActionResult Index()
        {
            IEnumerable<DetailsModel> obj = _db.DetailDbSet;

            return View(obj);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(DetailsModel obj)
        {
            if (ModelState.IsValid)
            {
                _db.DetailDbSet.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }else
            {
                return View(obj);
            }
        }

        public IActionResult Edit(int? id)
        {
            if(id==null || id <= 0) {

                return NotFound();
            }
            var obj = _db.DetailDbSet.Find(id);
            if(obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(DetailsModel obj)
        {
            if (ModelState.IsValid)
            {
                _db.DetailDbSet.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(obj);
            }
        }


        public IActionResult Delete(int? id)
        {
            if (id == null || id <= 0)
            {
                return NotFound();
            }
            var obj = _db.DetailDbSet.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.DetailDbSet.Find(id);
            if (ModelState.IsValid)
            {
                _db.DetailDbSet.Remove(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(obj);
            }
        }




    }
}

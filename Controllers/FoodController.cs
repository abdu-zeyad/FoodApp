using FoodApp.Data;
using FoodApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodApp.Controllers
{
    public class FoodController : Controller
    {
        private readonly FoodDbContext _db;
        public FoodController(FoodDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Food> objList = _db.Foods;
            return View(objList);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Food obj)
        {
            // _db.Add(obj);
            // _db.SaveChanges();
            return RedirectToAction("Index");
        }


        public IActionResult Delete(int? Id)
        {
            var obj = _db.Foods.Find(Id);

            return View(obj);
        }
        [HttpPost]
        public IActionResult DeletePost(int? Id)
        {
            var obj = _db.Foods.Find(Id);
            // _db.Remove(obj);
            // _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Update(int? Id)
        {
            var obj = _db.Foods.Find(Id);

            return View(obj);
        }
        [HttpPost]
        public IActionResult Update(Food obj)
        {

            // _db.Update(obj);
            // _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
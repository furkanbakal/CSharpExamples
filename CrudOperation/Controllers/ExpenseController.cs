using CrudOperation.Data;
using CrudOperation.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudOperation.Controllers
{
    public class ExpenseController : Controller
    {
        private readonly ApplicationDBContext _db;

        public ExpenseController(ApplicationDBContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Expense> objList = _db.Expenses;
            return View(objList);
           
        }

        //GET-Create
        public IActionResult Create()
        {
            return View();
        }

        //POST-Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Expense expense)
        {
            if (ModelState.IsValid)
            {
                _db.Expenses.Add(expense);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(expense);
        }

        //GET DELETE İŞLEMİ
        public IActionResult Delete(int? id)
        {
            

            if(id==null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Expenses.Find(id);

            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //POST DELETE İŞLEMİ
            [HttpPost]
            [ValidateAntiForgeryToken]
            public IActionResult DeletePost(int? id)
            {
                var obj = _db.Expenses.Find(id);

                if(obj == null)
                {
                    return NotFound();
                }

                _db.Expenses.Remove(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");

            
        }

        public IActionResult Update(int? id)
        {


            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Expenses.Find(id);

            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdatePost(Expense expense)
        {
            if (ModelState.IsValid)
            {
                _db.Expenses.Update(expense);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
    
            return View(expense);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using SimpleWebApp.Data;
using SimpleWebApp.Migrations;
using SimpleWebApp.Models;
using System.ComponentModel;


namespace SimpleWebApp.Controllers
{
    public class PersonInfoController : Controller
    {
        private readonly ApplicationDbContext _db;
        public PersonInfoController(ApplicationDbContext db)
        {
            _db = db;
        }

        
        public IActionResult Index()
        {
            List<Person> objPersonList = _db.Person_Info.ToList();
            return View(objPersonList);
        }

        public IActionResult Create()
        {
            return View();    
        }
        [HttpPost]
        public IActionResult Create(Person obj)
        {
            if (ModelState.IsValid)
            {
                _db.Person_Info.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Create successfully";
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Edit(int? id)
        {
            if(id==null || id ==0)
            {
                return NotFound();
            }
            Person? personFromDb = _db.Person_Info.FirstOrDefault(x => x.Id == id);
            if(personFromDb == null)
            {
                return NotFound();
            }

            return View(personFromDb);
        }
        [HttpPost]
        public IActionResult Edit(Person obj)
        {
            if (ModelState.IsValid)
            {
                _db.Person_Info.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "Edited successfully";
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Person? personFromDb = _db.Person_Info.FirstOrDefault(x => x.Id == id);
            if (personFromDb == null)
            {
                return NotFound();
            }

            return View(personFromDb);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            Person? obj = _db.Person_Info.FirstOrDefault(x => x.Id == id);
            if (obj == null)
            { 
                return NotFound();
            }
            _db.Person_Info.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "Deleted successfully";
            return RedirectToAction("Index");
            }
        }
}

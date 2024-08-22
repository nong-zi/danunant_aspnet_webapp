using Microsoft.AspNetCore.Mvc;
using SimpleWebApp.Data;
using SimpleWebApp.Migrations;
using SimpleWebApp.Models;
using System.ComponentModel; //data binding with models

namespace SimpleWebApp.Controllers 
{
    public class PersonInfoController : Controller //define action method inside this class
    {
        private readonly ApplicationDbContext _db;
        //declare a variable for providing access to interact with database
        public PersonInfoController(ApplicationDbContext db)
        {
            _db = db; //store the object from this contructor 
        }

        public IActionResult Index()
        {
            List<Person> objPersonList = _db.Person_Info.ToList();
            //convert the object from the data base to list and store it

            return View(objPersonList);
        }

        public IActionResult Create()
        {
            return View();    
        }
        [HttpPost] //this specifies that this action handles HTTP POST
        public IActionResult Create(Person obj) //take a parameter from Model Person
        //The model binding system automatically maps the form submitted
        //in the create view to Person
        {
            if (ModelState.IsValid)
            {
                _db.Person_Info.Add(obj); //add a new obj to database
                _db.SaveChanges();
                TempData["success"] = "Create successfully"; //inside TempData will stay for one instance
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
        public IActionResult Delete(int? id) //delete get method
            //? makes the parameter nullable
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

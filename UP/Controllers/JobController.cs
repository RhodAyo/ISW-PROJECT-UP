using UP.Data;
using UP.Models;
using Microsoft.AspNetCore.Mvc;
using UP.Migrations;

namespace UP.Controllers
{
    public class JobController : Controller
    {
        private readonly ApplicationDbContext _context;
        public JobController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<Job> objCatlist = _context.Jobs;
            return View(objCatlist);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Job empobj)
        {
            if (ModelState.IsValid)
            {
                _context.Jobs.Add(empobj);
                _context.SaveChanges();
                TempData["ResultOk"] = "Record Added Successfully!";
                return RedirectToAction("Index");
            }
            return View(empobj);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var empfromdb = _context.Jobs.Find(id);
            if (empfromdb == null)
            {
                return NotFound();
            }
            return View(empfromdb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Job empobj)
        {
            if (ModelState.IsValid)
            {
                _context.Jobs.Update(empobj);
                _context.SaveChanges();
                TempData["ResultOk"] = "Data Updated Successfully!";
                return RedirectToAction("Index");
            }
            return View(empobj);
        }


        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var empfromdb = _context.Jobs.Find(id);
            if (empfromdb == null)
            {
                return NotFound();
            }
            return View(empfromdb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteEmp(int? id)
        {
            var deleterecord = _context.Jobs.Find(id);
            if (deleterecord == null)
            {
                return NotFound();
            }
            _context.Jobs.Remove(deleterecord);
            _context.SaveChanges();
            TempData["ResultOk"] = "Data Deleted Successfully!";
            return RedirectToAction("Index");
        }

    }
}

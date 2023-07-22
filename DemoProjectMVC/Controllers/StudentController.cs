using DemoProjectMVC.DbCon;
using DemoProjectMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace DemoProjectMVC.Controllers
{
    public class StudentController : Controller
    {
        private readonly DbConnectionContext _context;
        public StudentController(DbConnectionContext context)
        {
            _context = context;
        }
        public async Task<ActionResult> Index()
        {
            var data = await _context.Students.ToListAsync();
            return View(data);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student student)
        {
            if (!ModelState.IsValid)
            {
                return View(student);
            }
            

            _context.Students.Add(student);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public async Task<ActionResult> Edit(int id)
        {
            var student = await _context.Students.FindAsync(id);
            return View(student);
        }

        [HttpPut]
        public async Task<ActionResult> Edit(Student student)
        {
            if (!ModelState.IsValid)
            {
                return View(student);
            }
            _context.Entry(student).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();

                return RedirectToAction("Index");
            }
            catch (DBConcurrencyException)
            {
                throw;
            }
        }
    }
}

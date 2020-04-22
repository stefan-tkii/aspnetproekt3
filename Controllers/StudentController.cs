using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AspNetProekt3.Models;
using System.Xml.Xsl;

namespace AspNetProekt3.Controllers
{
    public class StudentController : Controller
    {
        private readonly MVCSchoolContext _context;

        public StudentController(MVCSchoolContext context)
        {
            _context = context;
        }

        // GET: Student
        public async Task<IActionResult> Index()
        {
            return View(await _context.Student.ToListAsync());
        }

        public async Task<IActionResult> filterIndeks(string indeks)
        {
            if(string.IsNullOrEmpty(indeks))
            {
                return View(await _context.Student.ToListAsync());
            }
            var students = _context.Student;
            var result = students.Where(s => s.Indeks.Equals(indeks));
            return View(await result.ToListAsync());
        }

        public async Task<IActionResult> filterFullName(string fullName)
        {
            if(string.IsNullOrEmpty(fullName))
            {
                return View(await _context.Student.ToListAsync());
            }
            var students = _context.Student;
            var result = students.Where(s => s.FirstName.Contains(fullName) || s.LastName.Contains(fullName));
            return View(await result.ToListAsync());
        }

        public async Task<IActionResult> filterByCourse(string courseName) //pregled na studenti po predmet na koj se zapisani, pri sto EnrolledOn e lista na kursevi vo junction tabelata za ostvaruvanje na M 2 M vrska
        {
            if(string.IsNullOrEmpty(courseName))
            {
                return View(await _context.Student.ToListAsync());
            }
            var allStudents = _context.Student.Include(s => s.EnrolledOn).ThenInclude(s => s.course);
            var resultingStudents = allStudents.Where(s => s.EnrolledOn.Any(m => m.course.Title.Contains(courseName)));
            return View(await resultingStudents.ToListAsync());
        }

        // GET: Student/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Student
                .FirstOrDefaultAsync(m => m.Id == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // GET: Student/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Indeks,FirstName,LastName,EnrollmentDate,AcquiredCredits,CurrentSemester,EducationLevel")] Student student)
        {
            if (ModelState.IsValid)
            {
                _context.Add(student);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        // GET: Student/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Student.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        // POST: Student/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Indeks,FirstName,LastName,EnrollmentDate,AcquiredCredits,CurrentSemester,EducationLevel")] Student student)
        {
            if (id != student.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(student);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentExists(student.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        // GET: Student/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Student
                .FirstOrDefaultAsync(m => m.Id == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // POST: Student/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var student = await _context.Student.FindAsync(id);
            _context.Student.Remove(student);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentExists(long id)
        {
            return _context.Student.Any(e => e.Id == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AspNetProekt3.Models;
using System.Collections;

namespace AspNetProekt3.Controllers
{
    public class CourseController : Controller
    {
        private readonly MVCSchoolContext _context;

        public CourseController(MVCSchoolContext context)
        {
            _context = context;
        }

        // GET: Course
        public async Task<IActionResult> Index()
        {
            var mVCSchoolContext = _context.Course.Include(c => c.FirstTeacher).Include(c => c.SecondTeacher);
            return View(await mVCSchoolContext.ToListAsync());
        }

        public async Task<IActionResult> titleFilter(string title)
        {
            if(string.IsNullOrEmpty(title))
            {
                var mVCSchoolContext = _context.Course.Include(c => c.FirstTeacher).Include(c => c.SecondTeacher);
                return View(await mVCSchoolContext.ToListAsync());
            }

            var courses = _context.Course.Include(c => c.FirstTeacher).Include(c => c.SecondTeacher);
            var result = courses.Where(s => s.Title.Contains(title));
            return View(await result.ToListAsync());
        }

        public async Task<IActionResult> semesterFilter(int semester)
        {
            if (semester == default(int))
            {
                var mVCSchoolContext = _context.Course.Include(c => c.FirstTeacher).Include(c => c.SecondTeacher);
                return View(await mVCSchoolContext.ToListAsync());
            }

            var courses = _context.Course.Include(c => c.FirstTeacher).Include(c => c.SecondTeacher);
            var result = courses.Where(s => s.Semester == semester);
            return View(await result.ToListAsync());
        }

        public async Task<IActionResult> programmeFilter(string programme)
        {
            if (string.IsNullOrEmpty(programme))
            {
                var mVCSchoolContext = _context.Course.Include(c => c.FirstTeacher).Include(c => c.SecondTeacher);
                return View(await mVCSchoolContext.ToListAsync());
            }

            var courses = _context.Course.Include(c => c.FirstTeacher).Include(c => c.SecondTeacher);
            var result = courses.Where(s => s.Programme.Contains(programme));
            return View(await result.ToListAsync());
        }

        public async Task<IActionResult> teacherFirstFilter(string fullName)
        {
            if(string.IsNullOrEmpty(fullName))
            {
                var mVCSchoolContext = _context.Course.Include(c => c.FirstTeacher).Include(c => c.SecondTeacher);
                return View(await mVCSchoolContext.ToListAsync());
            }
            var courses = _context.Course.Include(c => c.FirstTeacher).Include(c => c.SecondTeacher);
            var result = courses.Where(s => s.FirstTeacher.FirstName.Contains(fullName) || s.FirstTeacher.LastName.Contains(fullName));
            return View(await result.ToListAsync());
        }

        public async Task<IActionResult> teacherSecondFilter(string fullName)
        {
            if (string.IsNullOrEmpty(fullName))
            {
                var mVCSchoolContext = _context.Course.Include(c => c.FirstTeacher).Include(c => c.SecondTeacher);
                return View(await mVCSchoolContext.ToListAsync());
            }
            var courses = _context.Course.Include(c => c.FirstTeacher).Include(c => c.SecondTeacher);
            var result = courses.Where(s => s.SecondTeacher.FirstName.Contains(fullName) || s.SecondTeacher.LastName.Contains(fullName));
            return View(await result.ToListAsync());
        }


        // GET: Course/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Course
                .Include(c => c.FirstTeacher)
                .Include(c => c.SecondTeacher)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }

        // GET: Course/Create
        public IActionResult Create()
        {
            ViewData["FirstTeacherId"] = new SelectList(_context.Teacher, "Id", "FirstName");
            ViewData["SecondTeacherId"] = new SelectList(_context.Teacher, "Id", "FirstName");
            return View();
        }

        // POST: Course/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Credits,Semester,Programme,EducationLevel,FirstTeacherId,SecondTeacherId")] Course course)
        {
            if (ModelState.IsValid)
            {
                _context.Add(course);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FirstTeacherId"] = new SelectList(_context.Teacher, "Id", "FirstName", course.FirstTeacherId);
            ViewData["SecondTeacherId"] = new SelectList(_context.Teacher, "Id", "FirstName", course.SecondTeacherId);
            return View(course);
        }

        // GET: Course/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Course.FindAsync(id);
            if (course == null)
            {
                return NotFound();
            }
            ViewData["FirstTeacherId"] = new SelectList(_context.Teacher, "Id", "FirstName", course.FirstTeacherId);
            ViewData["SecondTeacherId"] = new SelectList(_context.Teacher, "Id", "FirstName", course.SecondTeacherId);
            return View(course);
        }

        // POST: Course/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Credits,Semester,Programme,EducationLevel,FirstTeacherId,SecondTeacherId")] Course course)
        {
            if (id != course.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(course);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CourseExists(course.Id))
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
            ViewData["FirstTeacherId"] = new SelectList(_context.Teacher, "Id", "FirstName", course.FirstTeacherId);
            ViewData["SecondTeacherId"] = new SelectList(_context.Teacher, "Id", "FirstName", course.SecondTeacherId);
            return View(course);
        }

        // GET: Course/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Course
                .Include(c => c.FirstTeacher)
                .Include(c => c.SecondTeacher)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }

        // POST: Course/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var course = await _context.Course.FindAsync(id);
            _context.Course.Remove(course);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CourseExists(int id)
        {
            return _context.Course.Any(e => e.Id == id);
        }
    }
}

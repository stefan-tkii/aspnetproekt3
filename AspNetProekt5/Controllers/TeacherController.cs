using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AspNetProekt3.Models;

namespace AspNetProekt3.Controllers
{
    public class TeacherController : Controller
    {
        private readonly MVCSchoolContext _context;

        public TeacherController(MVCSchoolContext context)
        {
            _context = context;
        }

        // GET: Teacher
        public async Task<IActionResult> Index()
        {
            return View(await _context.Teacher.ToListAsync());
        }

        public async Task<IActionResult> filterFullName(string fullName)
        {
            if(string.IsNullOrEmpty(fullName))
            {
                return View(await _context.Teacher.ToListAsync());
            }

            var teachers = _context.Teacher;
            var result = teachers.Where(s => s.FirstName.Contains(fullName) || s.LastName.Contains(fullName));
            return View(await result.ToListAsync());
        }

        public async Task<IActionResult> filterDegree(string degree)
        {
            if (string.IsNullOrEmpty(degree))
            {
                return View(await _context.Teacher.ToListAsync());
            }

            var teachers = _context.Teacher;
            var result = teachers.Where(s => s.Degree.Contains(degree));
            return View(await result.ToListAsync());
        }

        public async Task<IActionResult> filterRank(string rank)
        {
            if (string.IsNullOrEmpty(rank))
            {
                return View(await _context.Teacher.ToListAsync());
            }

            var teachers = _context.Teacher;
            var result = teachers.Where(s => s.AcademicRank.Contains(rank));
            return View(await result.ToListAsync());
        }

        public async Task<IActionResult> ViewCourses(int? Id)
        {
            if(Id == null)
            {
                return NotFound();
            }
            var allCourses = _context.Course;
            var selectedCourses = allCourses.Where(s => s.FirstTeacherId == Id || s.SecondTeacherId == Id).Include(s=>s.FirstTeacher).Include(s=>s.SecondTeacher).ToListAsync();
            return View(await selectedCourses);
        }

        public async Task<IActionResult> ViewEnrollments(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var allEnrollments = _context.Enrollment;
            var currentSemester = _context.Course.Where(s => s.Id == id).FirstOrDefault().Semester;
            var selectedEnrollments = allEnrollments.Where(s => s.CourseId == id && (s.Student.CurrentSemester - currentSemester == 2)).Include(s => s.Student).Include(s => s.course).ToListAsync();
            return View(await selectedEnrollments);
        }

        public async Task<IActionResult> viewEnrollmentsByYear(string searchBy, string id)
        {
            if(id == null)
            {
                return NotFound();
            }
            int currId = Int32.Parse(id);
            var allEnrollments = _context.Enrollment;
            var courseSemester = _context.Course.Where(s => s.Id == currId).FirstOrDefault().Semester;
            if(searchBy == "0 years")
            {
                var selectedEnrollments = allEnrollments.Where(s => s.CourseId == currId && s.Student.CurrentSemester == courseSemester).Include(s=>s.Student).Include(s=>s.course).ToListAsync();
                return View(await selectedEnrollments);
            }
            else if(searchBy == "1 years")
            {
                var selectedEnrollments = allEnrollments.Where(s => s.CourseId == currId && (s.Student.CurrentSemester - courseSemester == 2)).Include(s => s.Student).Include(s => s.course).ToListAsync();
                return View(await selectedEnrollments);
            }
            else if (searchBy == "2 years")
            {
                var selectedEnrollments = allEnrollments.Where(s => s.CourseId == currId && (s.Student.CurrentSemester - courseSemester == 4)).Include(s => s.Student).Include(s => s.course).ToListAsync();
                return View(await selectedEnrollments);
            }
            else if (searchBy == "3 years")
            {
                var selectedEnrollments = allEnrollments.Where(s => s.CourseId == currId && (s.Student.CurrentSemester - courseSemester == 6)).Include(s => s.Student).Include(s => s.course).ToListAsync();
                return View(await selectedEnrollments);
            }
            else
            {
                return NotFound();
            }
        }

        public async Task<IActionResult> studentEnrollment(int? Id)
        {
            if(Id==null)
            {
                return NotFound();
            }
            var selected = _context.Enrollment.Where(s => s.Id == Id).Include(s=>s.course).Include(s=>s.Student).FirstOrDefaultAsync();
            return View(await selected);
        }

        public async Task<IActionResult> updateEnrollment(int? id, string examPoints, string additionalPoints, string seminalPoints, string grade, string finishDate)
        {
            if(id == null) { return NotFound(); }
            var result = await _context.Enrollment.Where(s => s.Id == id).FirstOrDefaultAsync();
            if(examPoints !=null)
            {
                var points = Int32.Parse(examPoints);
                result.ExamPoints = points;
            }
            if(additionalPoints !=null)
            {
                var points = Int32.Parse(additionalPoints);
                result.AdditionalPoints = points;
            }
            if(seminalPoints !=null)
            {
                var points = Int32.Parse(seminalPoints);
                result.SeminalPoints = points;
            }
            if(grade!=null)
            {
                var gr = Int32.Parse(grade);
                if(gr<5 || gr>10) { return NotFound(); }
                result.Grade = gr;
            }
            if(finishDate != null)
            {
                if(result.FinishDate !=null) { return NotFound(); }
                DateTime date = Convert.ToDateTime(finishDate);
                var dateNow = DateTime.Now;
                if(dateNow > date) { return NotFound(); }
                result.FinishDate = date;
            }

            try
            {
                _context.Update(result);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
            return RedirectToAction(nameof(Index));
        }



        // GET: Teacher/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teacher = await _context.Teacher
                .FirstOrDefaultAsync(m => m.Id == id);
            if (teacher == null)
            {
                return NotFound();
            }

            return View(teacher);
        }

        // GET: Teacher/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Teacher/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,Degree,AcademicRank,OfficeNumber,HireDate")] Teacher teacher)
        {
            if (ModelState.IsValid)
            {
                _context.Add(teacher);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(teacher);
        }

        // GET: Teacher/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teacher = await _context.Teacher.FindAsync(id);
            if (teacher == null)
            {
                return NotFound();
            }
            return View(teacher);
        }

        // POST: Teacher/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,Degree,AcademicRank,OfficeNumber,HireDate")] Teacher teacher)
        {
            if (id != teacher.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(teacher);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TeacherExists(teacher.Id))
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
            return View(teacher);
        }

        // GET: Teacher/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teacher = await _context.Teacher
                .FirstOrDefaultAsync(m => m.Id == id);
            if (teacher == null)
            {
                return NotFound();
            }

            return View(teacher);
        }

        // POST: Teacher/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var teacher = await _context.Teacher.FindAsync(id);
            _context.Teacher.Remove(teacher);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TeacherExists(int id)
        {
            return _context.Teacher.Any(e => e.Id == id);
        }
    }
}

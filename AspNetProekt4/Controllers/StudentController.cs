using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AspNetProekt3.Models;
using System.Xml.Xsl;
using System.Net.WebSockets;
using AspNetProekt3.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.Extensions.Hosting;

namespace AspNetProekt3.Controllers
{
    public class StudentController : Controller
    {
        private readonly MVCSchoolContext _context;
        private readonly IWebHostEnvironment hostEnvironment;

        public StudentController(MVCSchoolContext context, IWebHostEnvironment hostingEnvironment)
        {
            _context = context;
            this.hostEnvironment = hostingEnvironment;
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

        public async Task<IActionResult> addMenu(string semester, string type)
        {
            int check = Int32.Parse(semester);
            if(check < 1 || check >10)
            {
                return NotFound();
            }
            if(type.Equals("zimski") && (check == 2 || check == 4 || check == 6 || check == 8 || check == 10))
            {
                return NotFound();
            }

            if (type.Equals("leten") && (check == 1 || check == 3 || check == 5 || check == 7 || check == 9))
            {
                return NotFound();
            }

            var allCourses = _context.Course;
            var selectedCourses = allCourses.Where(s => s.Semester.Equals(Int32.Parse(semester)));
            var allStudents = _context.Student;
            if(type.Equals("zimski"))
            {
                var selectedStudents = allStudents.Where(s => s.CurrentSemester == 1 || s.CurrentSemester == 3 || s.CurrentSemester == 5 || s.CurrentSemester == 7 || s.CurrentSemester == 9);
                var model = new addMenuModel(await selectedCourses.ToListAsync(), await selectedStudents.ToListAsync());
                return View(model);
            }
            else if(type.Equals("leten"))
            {
                var selectedStudents = allStudents.Where(s => s.CurrentSemester == 2 || s.CurrentSemester == 4 || s.CurrentSemester == 6 || s.CurrentSemester == 8 || s.CurrentSemester == 10);
                var model = new addMenuModel(await selectedCourses.ToListAsync(), await selectedStudents.ToListAsync());
                return View(model);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EnrollStudent(string indeks, string title)
        {
            var allStudents = _context.Student;
            var selectedStudent = allStudents.Where(s => s.Indeks.Equals(indeks)).FirstOrDefault();
            var allCourses = _context.Course;
            var selectedCourse = allCourses.Where(s => s.Title.Equals(title)).FirstOrDefault();
            var enroll = new Enrollment();
            enroll.Student = selectedStudent;
            enroll.StudentId = selectedStudent.Id;
            enroll.course = selectedCourse;
            enroll.CourseId = selectedCourse.Id;
            enroll.Semester = selectedCourse.Semester.ToString();
            if(selectedCourse.Semester == 1 || selectedCourse.Semester== 2)
            { enroll.Year = 1;}
            if (selectedCourse.Semester == 3 || selectedCourse.Semester == 4)
            { enroll.Year = 2; }
            if (selectedCourse.Semester == 5 || selectedCourse.Semester == 6)
            { enroll.Year = 3; }
            if (selectedCourse.Semester == 7 || selectedCourse.Semester == 8)
            { enroll.Year = 4; }
            if(selectedCourse.Semester == 9 || selectedCourse.Semester == 10)
            {
                enroll.Year = 5;
            }
            _context.Add(enroll);
            await _context.SaveChangesAsync();
            return View(await _context.Enrollment.ToListAsync());
        }

        public async Task<IActionResult> EditEnrollment(long? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var student = await _context.Student.FirstOrDefaultAsync(m => m.Id == id);
            if(student == null)
            {
                return NotFound();
            }
            var allEnrollments = _context.Enrollment;
            var selectedEnrollments = allEnrollments.Where(s => s.StudentId == id).Include(s => s.course).Include(s=>s.Student).ToListAsync();
            return View(await selectedEnrollments);
        }

        public async Task<IActionResult> InsertDate(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var selectedEnrollment = _context.Enrollment.Where(s => s.Id == id).Include(s=>s.course).Include(s=>s.Student).FirstOrDefaultAsync();
            return View(await selectedEnrollment);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> finishDateEdit(string finishDate, string ID)
        {
            DateTime date = Convert.ToDateTime(finishDate);
            var dateNow = DateTime.Now;
            bool result = date > dateNow;
            if(result)
            {
                return NotFound();
            }
            long id = Int64.Parse(ID);
            var enrollment = _context.Enrollment.Where(s => s.Id == id).Include(s=> s.Student).FirstOrDefault();
            var studentDate = enrollment.Student.EnrollmentDate;
            if(studentDate>date)
            {
                return NotFound();
            }
            enrollment.FinishDate = date;
            try
            {
                _context.Update(enrollment);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ViewMyCourses(int? id)
        {
            if(id==null) { return NotFound(); }
            var res = await _context.Enrollment.Where(s => s.StudentId == id).Include(s=>s.course).Include(s=>s.Student).ToListAsync();
            return View(res);
        }

        public async Task<IActionResult> editStudentEnrollment(long? id)
        {
            if(id == null) { return NotFound(); }
            var res = await _context.Enrollment.Where(s => s.Id == id).Include(s => s.course).Include(s=>s.Student).FirstOrDefaultAsync();
            EnrollmentViewModel model = new EnrollmentViewModel();
            model.Id = (long) id;
            model.Grade = res.Grade;
            model.FinishDate = res.FinishDate;
            model.course = res.course;
            model.CourseId = res.CourseId;
            model.AdditionalPoints = res.AdditionalPoints;
            model.ExamPoints = res.ExamPoints;
            model.ProjectPoints = res.ProjectPoints;
            model.ProjectUrl = res.ProjectUrl;
            model.Semester = res.Semester;
            model.Student = res.Student;
            model.StudentId = res.StudentId;
            model.SeminalPoints = res.SeminalPoints;
            model.Year = res.Year;
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> changeUrl(long? id, string url)
        {
            if(id == null) { return NotFound(); }
            var res = await _context.Enrollment.Where(s => s.Id == id).FirstOrDefaultAsync();
            res.ProjectUrl = url;
            try
            {
                _context.Update(res);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> uploadProject(long? id, IFormFile uploadedFile)
        {
            if(id==null) { return NotFound(); }
            if(uploadedFile == null) { return NotFound(); }
            string uploaded = Path.Combine(hostEnvironment.WebRootPath + "/projects/");
            string uniqueFileName = Guid.NewGuid().ToString() + "_" + uploadedFile.FileName;
            string filePath = Path.Combine(uploaded + uniqueFileName);
            using(var filestream = new FileStream(filePath, FileMode.Create))
            {
                uploadedFile.CopyTo(filestream);
            }

            var res = await _context.Enrollment.Where(s => s.Id == id).FirstOrDefaultAsync();
            res.SeminalUrl = uniqueFileName;
            try
            {
                _context.Update(res);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
            return RedirectToAction(nameof(Index));
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

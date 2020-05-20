using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AspNetProekt3.Models;
using System.Collections;
using AspNetProekt3.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System.IO;
using System.Web;

namespace AspNetProekt3.Controllers
{
    public class DataImageController : Controller
    {
        private readonly MVCSchoolContext _context;
        private readonly IWebHostEnvironment hostEnvironment;

        public DataImageController(MVCSchoolContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            this.hostEnvironment = hostEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> showTeachers()
        {
            var res = _context.Teacher.ToListAsync();
            return View(await res);
        }

        public async Task<IActionResult> showStudents()
        {
            var res = _context.Student.ToListAsync();
            return View(await res);
        }

        public async Task<IActionResult> EditSingleStudent(int? id)
        {
            var selected = await  _context.Student.Where(s => s.Id == id).FirstOrDefaultAsync();
            StudentViewModel model = new StudentViewModel();
            model.Id = selected.Id;
            model.FirstName = selected.FirstName;
            model.LastName = selected.LastName;
            model.Indeks = selected.Indeks;
            model.EducationLevel = selected.EducationLevel;
            model.EnrollmentDate = selected.EnrollmentDate;
            model.CurrentSemester = selected.CurrentSemester;
            model.AcquiredCredits = selected.AcquiredCredits;
            string smallpath = hostEnvironment.WebRootPath + "/student_images/";
            string uniq = id.ToString() + "_" + "profileimage.png";
            if(System.IO.File.Exists(Path.Combine(smallpath + uniq)))
            {
                model.filePath = Path.Combine(smallpath + uniq);
            }
            return View(model);
        }

        public async Task<IActionResult> EditSingle(int? id)
        {
            var selected =  await _context.Teacher.Where(s => s.Id == id).FirstOrDefaultAsync();
            TeacherViewModel model = new TeacherViewModel();
            model.Id = selected.Id;
            model.FirstName = selected.FirstName;
            model.LastName = selected.LastName;
            model.HireDate = selected.HireDate;
            model.OfficeNumber = selected.OfficeNumber;
            model.Degree = selected.Degree;
            model.AcademicRank = selected.AcademicRank;
            string smallpath = hostEnvironment.WebRootPath + "/teacher_images/";
            string uniq = id.ToString() + "_" + "profileimage.png";
            if (System.IO.File.Exists(Path.Combine(smallpath + uniq)))
            {
                model.filePath = Path.Combine(smallpath + uniq);
            }
            return View(model);
        }

        public async Task<IActionResult> uploadTeacher(int? id, IFormFile uploadedTeacher)
        {
            if(id == null) { return NotFound(); }
            if(uploadedTeacher == null) { return NotFound(); }
            string uploaded = Path.Combine(hostEnvironment.WebRootPath + "/teacher_images/");
            string uniqueFileName = id.ToString() + "_" + "profileimage.png";
            string filePath = Path.Combine(uploaded + uniqueFileName);
            if(System.IO.File.Exists(filePath))
            {
                System.IO.File.Delete(filePath);
            }
            using (var filestream = new FileStream(filePath, FileMode.Create))
            {
                uploadedTeacher.CopyTo(filestream);
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> uploadStudent(int? id, IFormFile uploadedStudent)
        {
            if(id==null) { return NotFound(); }
            if(uploadedStudent == null) { return NotFound(); }
            string uploaded = Path.Combine(hostEnvironment.WebRootPath + "/student_images/");
            string uniqueFileName = id.ToString() + "_" + "profileimage.png";
            string filePath = Path.Combine(uploaded + uniqueFileName);
            if (System.IO.File.Exists(filePath))
            {
                System.IO.File.Delete(filePath);
            }
            using(var filestream = new FileStream(filePath, FileMode.Create))
            {
                uploadedStudent.CopyTo(filestream);
            }
            return RedirectToAction(nameof(Index));
        }

    }
}

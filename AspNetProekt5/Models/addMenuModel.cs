using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetProekt3.Models
{
    public class addMenuModel
    {
        public addMenuModel(ICollection<Course> selectedCourses, ICollection<Student> selectedStudents)
        {
            this.selectedCourses = selectedCourses;
            this.selectedStudents = selectedStudents;
        }

        public ICollection<Course> selectedCourses { get; set; }

        public ICollection<Student> selectedStudents { get; set; }

    }
}

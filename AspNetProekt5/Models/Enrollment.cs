using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetProekt3.Models
{
    public class Enrollment
    {
        public Enrollment() { }
        public Int64 Id { get; set; }

        [Required]
        public int CourseId { get; set; }

#nullable enable
        public Course? course { get; set; }

        [Required]
        public Int64 StudentId { get; set; }

#nullable enable
        public Student? Student { get; set; }

        [RegularExpression(@"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$")]
        [MaxLength(10)]
#nullable enable
        public string? Semester { get; set; }


#nullable enable
        public int? Year { get; set; }

#nullable enable
        public int? Grade { get; set; }

        [MaxLength(255)]
#nullable enable
        public string? SeminalUrl { get; set; }

        [MaxLength(255)]
#nullable enable
        public string? ProjectUrl { get; set; }

#nullable enable
        public int? ExamPoints { get; set; }


#nullable enable
        public int? SeminalPoints { get; set; }

#nullable enable
        public int? ProjectPoints { get; set; }

#nullable enable
        public int? AdditionalPoints { get; set; }


#nullable enable
        [DataType(DataType.Date)]
        public DateTime? FinishDate { get; set; }
    }
}

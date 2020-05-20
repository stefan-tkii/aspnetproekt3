using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetProekt3.Models
{
    public class Seed
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MVCSchoolContext(serviceProvider.GetRequiredService<DbContextOptions<MVCSchoolContext>>()))
            {
                context.Enrollment.AddRange(
                    new Enrollment { CourseId=1, StudentId=2 },
                    new Enrollment { CourseId=2, StudentId=1}
                    );
                context.SaveChanges();
            }
        }
    }
}

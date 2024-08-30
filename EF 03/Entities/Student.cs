using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_03.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public   int? Age { get; set; }
        // public ICollection<Course> Course { get; set; } = new HashSet<Course>();
        //Navigtional Property (Many)

        public virtual ICollection<StudentCourse> StudentCourses { get; set; } = new HashSet<StudentCourse>();
    }
}

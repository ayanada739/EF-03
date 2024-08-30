using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_03.Entities
{


    public class Course
    {
        public int Id { get; set; }
        public  string Title { get; set; }
        //public ICollection<Student> Student { get; set; } = new HashSet<Student>();
        //Navigtional Property (Many)
        public virtual ICollection<StudentCourse> StudentCourses { get; set; } = new HashSet<StudentCourse>();

    }
}

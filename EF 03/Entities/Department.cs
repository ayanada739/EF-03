using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_01.Entities
{
    public class Department
    {
        [Key]
        public int DeptId { get; set; } 

        public string Name { get; set; }
        public DateTime DateOfCreation { get; set; }

        public virtual ICollection<Employee> employees { get; set; } = new HashSet<Employee>();
        //Navigation Property => Many 


    }
}
 
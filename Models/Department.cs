using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentDepartmentApp.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
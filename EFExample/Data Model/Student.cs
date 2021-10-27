using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFExample.Data_Model
{
    public class Student
    {
        public int StudentId { get; set; }
        [MaxLength(50)]
        public string StudentName { get; set; }
        [Required]
        public int StudentAge { get; set; }

        public List<Class> ClassList { get; set; }
    }
}

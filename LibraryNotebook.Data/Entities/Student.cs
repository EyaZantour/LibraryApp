using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryNotebook.Data.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string EnrollmentNumber { get; set; } // unique
        public string FullName { get; set; }
        public string Department { get; set; }
        public string Semester { get; set; }
        public string Email { get; set; }
    }


}

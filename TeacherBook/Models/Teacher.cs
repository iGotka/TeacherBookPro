using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherBook.Models
{
    public partial class Teacher
    {
        public int IdTeacher { get; set; }

        public string TeacherName { get; set; }

        public virtual ICollection<History> Histories { get; } = new List<History>();

        public virtual ICollection<TeacherHasSubject> TeacherHasSubjects { get; } = new List<TeacherHasSubject>();
    }
}

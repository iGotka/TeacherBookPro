using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherBook.Models
{
    public partial class Subject
    {
        public int IdSubject { get; set; }

        public string NameSubject { get; set; }

        public virtual ICollection<Journal> Journals { get; } = new List<Journal>();

        public virtual ICollection<TeacherHasSubject> TeacherHasSubjects { get; } = new List<TeacherHasSubject>();
    }
}

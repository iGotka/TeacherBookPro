using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherBook.Models
{
    public partial class TeacherHasSubject
    {
        public int IdTd { get; set; }

        public int IdTeacher { get; set; }

        public int IdSubject { get; set; }

        public int Duration { get; set; }

        public virtual Subject IdSubjectNavigation { get; set; }

        public virtual Teacher IdTeacherNavigation { get; set; }
    }
}

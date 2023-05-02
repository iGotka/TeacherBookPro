using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherBook.Models
{
    public partial class History
    {
        public int IdHistory { get; set; }

        public int IdTeacher { get; set; }

        public int IdStudent { get; set; }

        public int IdStatus { get; set; }

        public DateTime? DateEvent { get; set; }

        public virtual Status IdStatusNavigation { get; set; }

        public virtual Student IdStudentNavigation { get; set; }

        public virtual Teacher IdTeacherNavigation { get; set; }
    }
}

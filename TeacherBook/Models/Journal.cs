using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherBook.Models
{
    public partial class Journal
    {
        public int IdJournal { get; set; }

        public int IdStudent { get; set; }

        public int? IdSubject { get; set; }

        public int? Evaluation { get; set; }

        public int? IdGroup { get; set; }

        public virtual Group IdGroupNavigation { get; set; }

        public virtual Student IdStudentNavigation { get; set; } = null;

        public virtual Subject IdSubjectNavigation { get; set; }
    }
}

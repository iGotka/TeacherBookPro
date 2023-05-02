using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherBook.Models
{
    public partial class Group
    {
        public int IdGroup { get; set; }

        public string NameGroup { get; set; }

        public virtual ICollection<Journal> Journal { get; } = new List<Journal>();

        public virtual ICollection<Student> Student { get; } = new List<Student>();
    }
}

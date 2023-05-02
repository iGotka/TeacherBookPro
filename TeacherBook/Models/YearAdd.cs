using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherBook.Models
{
    public partial class YearAdd
    {
        public int IdYear { get; set; }

        public int Year { get; set; }

        public virtual ICollection<Student> Students { get; } = new List<Student>();
    }
}

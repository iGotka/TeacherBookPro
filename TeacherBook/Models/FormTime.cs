using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherBook.Models
{
    public partial class FormTime
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Student> Students { get; } = new List<Student>();
    }
}

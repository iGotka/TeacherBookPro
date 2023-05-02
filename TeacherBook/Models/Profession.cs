using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherBook.Models
{
    public partial class Profession
    {
        public int IdProfession { get; set; }

        public string NameProfession { get; set; }

        public virtual ICollection<Student> Students { get; } = new List<Student>();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace TeacherBook.Models
{
    public partial class Student
    {
        public int IdStudent { get; set; }

        public string FiestName { get; set; }

        public string LastName { get; set; }

        public string PatronomicName { get; set; }
        public string FullName { get {
                return FiestName + " "+ LastName + " "+PatronomicName;
            } } 

        public int? IdProfession { get; set; }

        public int? IdFormTime { get; set; }

        public int? IdGroup { get; set; }

        public int? IdYearAdd { get; set; }

        public virtual ICollection<History> History { get; } = new List<History>();

        public virtual FormTime FormTime { get; set; }

        public virtual Group Group { get; set; }

        public virtual Profession Profession { get; set; }

        public virtual YearAdd YearAdd { get; set; }

        public virtual ICollection<Journal> Journal { get; } = new List<Journal>();
    }
}

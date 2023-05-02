using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherBook.Models
{
    public partial class Status
    {
        public int IdStatus { get; set; }

        public string NameStatus { get; set; }

        public virtual ICollection<History> Histories { get; } = new List<History>();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherBook.Models
{
    public partial class Role
    {
        public int IdRole { get; set; }

        public string NameRole { get; set; }

        public virtual ICollection<User> Users { get; } = new List<User>();
    }
}

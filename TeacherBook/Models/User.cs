using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherBook.Models
{
    public partial class User
    {
        public int IdUser { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public int IdRole { get; set; }

        public virtual Role IdRoleNavigation { get; set; }
    }
}

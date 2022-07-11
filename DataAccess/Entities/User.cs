using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class User : BaseEntities
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

    }
}

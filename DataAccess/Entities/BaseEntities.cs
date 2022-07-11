using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class BaseEntities
    {
        public int Id { get; set; }
        public DateTime CreatDate { get; set; }
        public DateTime UploadDate { get; set; }

    }
}

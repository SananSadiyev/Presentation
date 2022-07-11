
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstract
{
    public interface IUserServices :IBaseServices<User>
    {

        public User Login(string user,string pas)
        {     
            return new User();
        }
     
        
    }
}

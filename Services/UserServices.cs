using Api2._1;
using DataAccess.Entities;
using Services.Abstract;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{

    public class UserServices : BaseServices<User>, IUserServices
    {
        public UserServices(AppDbConntext db) : base(db)
        {

        }

        public User Login(string user, string pas)
        {
           var log= _db.Users.Where(x=>x.Username == user && x.Password == pas);
            if (log.Count() == 1)
            {

                return log.First();
            }
            else
            {
                throw new Exception("Login Tapilmadi !!!");
            }

        }
    }
}

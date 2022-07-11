using Api2._1;
using Microsoft.EntityFrameworkCore;
using Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    
    public class BaseServices
    {

    }
    public class BaseServices<Tmodel> : BaseServices, IBaseServices<Tmodel> where Tmodel : class
    {

        protected readonly DbSet<Tmodel> _dbSet;

        protected readonly AppDbConntext _db;
        


        public BaseServices(AppDbConntext db)
        {
            _db = db;
            _dbSet = db.Set<Tmodel>();
            
        }


        public Tmodel Create(Tmodel model)
        {
           _dbSet.Add(model);

             _db.SaveChanges();

            return model;

        }

        public void Delete(int id)
        {
            
           var item = Get(id);
            
                _dbSet.Remove(item);

            _db.SaveChanges();

        }

        public Tmodel Get(int id)
        {
            var get = _dbSet.Find(id);
            return get;
        }

        public IEnumerable<Tmodel> Get()
        {
            return _dbSet;
        }

        public Tmodel Update(Tmodel model)
        {
            _dbSet.Update(model);
            _db.SaveChanges();
            return model;
        }

    }



}

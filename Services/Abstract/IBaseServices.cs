using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstract
{
    public interface IBaseServices
    {
        

    } 
    
    public interface IBaseServices<Tmodel> : IBaseServices where Tmodel : class
    {

        public Tmodel Get(int id);


        public IEnumerable<Tmodel> Get();


        public void Delete(int id);


        public Tmodel Create(Tmodel model);


        public Tmodel Update(Tmodel model);

    }


}

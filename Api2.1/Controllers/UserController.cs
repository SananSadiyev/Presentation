
using DataAccess.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;
using Services.Abstract;


using System.Collections.Generic;

namespace Api2._1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserServices _userServices;

        public UserController(IUserServices userServices)
        {
            _userServices = userServices;
        }

        [HttpGet]
        [Route("Get/{id}")]
        public User Get( [FromRoute] int id )
        {
            
            return _userServices.Get(id);
           // _userServices.Login();
        }


        [HttpGet]
        [Route("Get")]
        public IEnumerable<User> Get()
        {

            return _userServices.Get();
        }


        [HttpDelete]
        [Route("Delete")]
        public void Delete([FromRoute] int id)
        {
            _userServices.Delete(id);

        }

        [HttpPost]
        [Route("Create")]
        public User Create([FromBody]User user)
        {
            return _userServices.Create(user);

        }


        [HttpPut]
        [Route("Update")]
        public User Update([FromBody]User user)
        {
            return _userServices.Update(user);

        }



    }
}

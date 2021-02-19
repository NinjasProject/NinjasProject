using APIFlixNinjas.Data.Interface;
using APIFlixNinjas.Model;
using APIFlixNinjas.Requests;
using APIFlixNinjas.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;


namespace APIFlixNinjas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : Controller
    {
        private readonly IUserService _userservice;
        public CustomerController(IUserService userservice)
        {
            _userservice = userservice;

        }
        
        [HttpPost]
        [Route("SaveUser")]
        public ActionResult<UsersResponse> Save(UsersRequest request)
        {
            int userId=_userservice.SaveUser(request);
            return StatusCode((int)HttpStatusCode.OK, new UsersResponse { ID=userId});
        }
        [HttpGet]
        [Route("RetrieveUser")]
        public List<Users> Retrieve()
        {
            List<Users> employeeList = new List<Users>();
            employeeList=_userservice.RetriveUser();
            return employeeList;
        }

    }
}




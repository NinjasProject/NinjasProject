using APIFlixNinjas.Data.Interface;
using APIFlixNinjas.Model;
using APIFlixNinjas.Requests;
using APIFlixNinjas.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Http;

namespace APIFlixNinjas.Service.Implementations
{
    public class UserService : IUserService
    {
        
        private readonly IAPIFlixNinjasDbContext _ninjasDbContext;
        public UserService(IAPIFlixNinjasDbContext ninjasDbContext)
        {
            _ninjasDbContext = ninjasDbContext;

        }
        public int SaveUser(UsersRequest request)
        {
            Users demo = new Users()
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Age = request.Age,
                Username = request.Username,
                Email = request.Email,
                MobileNo = request.MobileNo,
                Gender = request.Gender,
                Password = request.Password,
                ConfirmPassword = request.ConfirmPassword,

            };

            _ninjasDbContext.Users.Add(demo);

            _ninjasDbContext.SaveChanges();
            
            return demo.ID;
           
        }
        public List<Users> RetriveUser()
        {
            List<Users> employeeList = new List<Users>();
            employeeList = _ninjasDbContext.Users.ToList();
            return employeeList;
        }
   
    }


}

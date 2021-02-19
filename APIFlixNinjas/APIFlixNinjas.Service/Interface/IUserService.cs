using APIFlixNinjas.Model;
using APIFlixNinjas.Requests;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace APIFlixNinjas.Service.Interface
{
    public interface IUserService
    {
        int SaveUser(UsersRequest request);
        List<Users> RetriveUser();
    }
}

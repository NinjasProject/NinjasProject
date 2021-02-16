using APIFlixNinjas.Data;
using APIFlixNinjas.Data.Interface;
using APIFlixNinjas.Models;
using APIFlixNinjas.Requests;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace APIFlixNinjas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : Controller
    {
        private readonly APIFlixNinjasDbContext _APIFlixNinjasDbContext;

        public CustomerController(APIFlixNinjasDbContext APIFlixNinjasDbContext)
        {
            _APIFlixNinjasDbContext = APIFlixNinjasDbContext;

        }
        [HttpPost]
        public IActionResult Index(CustomerRequest request)
        {

            Customer obj = new Customer()
            {
                Age = request.Age,
                Name = request.Name
            };
            CustomerSubscription obj1 = new CustomerSubscription()
            {
                Name = request.Name
            };
            // _APIFlixNinjasDbContext.Customer.Add(obj);
            _APIFlixNinjasDbContext.CustomerSubscription.Add(obj1);

            _APIFlixNinjasDbContext.SaveChanges();

            return View();
        }
        [HttpPost]
        [Route("SaveSubscription")]
        public IActionResult SaveSubscription(SubscriptionRequest request)
        {

            CustomerSubscription obj = new CustomerSubscription()
            {
                Name = request.Name
            };
            _APIFlixNinjasDbContext.CustomerSubscription.Add(obj);
            _APIFlixNinjasDbContext.SaveChanges();

            return View();
        }
    }
}

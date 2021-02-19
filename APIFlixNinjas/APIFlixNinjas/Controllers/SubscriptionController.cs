using APIFlixNinjas.Model;
using APIFlixNinjas.Requests;
using APIFlixNinjas.Service.Interface;
using Microsoft.AspNetCore.Http;
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
    public class SubscriptionController : Controller
    {
        private readonly ISubscriptionService _subscriptionService;
        public SubscriptionController(ISubscriptionService subscriptionService)
        {
            _subscriptionService = subscriptionService;

        }
        [HttpPost]
        [Route("SaveSubscription")]
        public ActionResult Save(SubscriptionRequest request)
        {
             _subscriptionService.SaveSubscription(request);
            return Ok();
        }
        [HttpGet]
        [Route("RetrieveSubscription")]
        public List<Subscription> Retrieve()
        {
            List<Subscription> subscriptionList = new List<Subscription>();
            subscriptionList = _subscriptionService.RetrieveSubscription();
            return subscriptionList;
        }
    }
}

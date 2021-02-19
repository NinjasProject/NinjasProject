using APIFlixNinjas.Model;
using APIFlixNinjas.Requests;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace APIFlixNinjas.Service.Interface
{
   public  interface ISubscriptionService
    {
        int SaveSubscription(SubscriptionRequest request);
        List<Subscription> RetrieveSubscription();
    }
}

using APIFlixNinjas.Data.Interface;
using APIFlixNinjas.Service.Interface;
using System;
using APIFlixNinjas.Model;
using APIFlixNinjas.Requests;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace APIFlixNinjas.Service.Implementations
{
    public class SubscriptionService : ISubscriptionService
    {
        DateTime currentdate;
        DateTime expiryDate;
        private readonly IAPIFlixNinjasDbContext _ninjasDbContext;
        public SubscriptionService(IAPIFlixNinjasDbContext ninjasDbContext)
        {
            _ninjasDbContext = ninjasDbContext;

        }
        public int SaveSubscription(SubscriptionRequest request)
        {
            if (request.subscriptionType == subtype.Monthly)
            {
                 currentdate = DateTime.Now;
                 expiryDate = DateTime.Now.AddMonths(1);

            }
            else if
                (request.subscriptionType == subtype.Quartely)
            {
                 currentdate = DateTime.Now;
                 expiryDate = DateTime.Now.AddMonths(3);
            }

            else if
                (request.subscriptionType == subtype.Yearly)
            {
                 currentdate = DateTime.Now;
                 expiryDate = DateTime.Now.AddMonths(12);

            }
            Subscription subscription = new Subscription()
            {
              
                subscriptionType=request.subscriptionType,
                startDate = currentdate,
                endDate = expiryDate,
                customerID=request.customerID,

            };

            _ninjasDbContext.Subscription.Add(subscription);

            _ninjasDbContext.SaveChanges();

            return subscription.ID;
        }
        public List<Subscription> RetrieveSubscription()
        {
            DateTime sdate= DateTime.Now;
            DateTime ldate = DateTime.Now.AddDays(10);
            List<Subscription> subscription = new List<Subscription>();
            subscription = _ninjasDbContext.Subscription.Where(x => x.endDate > sdate & x.endDate<ldate).ToList();
            return subscription;
        }

        
    }
}

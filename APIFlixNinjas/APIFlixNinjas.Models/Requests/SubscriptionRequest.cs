using System;
using System.Collections.Generic;
using System.Text;

namespace APIFlixNinjas.Requests
{
    public enum subtype
    {
        Monthly = 1,
        Quartely = 2,
        Yearly =3,
        
    }
   public  class SubscriptionRequest
    {

        public subtype subscriptionType { get; set; }

        public DateTime startDate { get; set; }

        public DateTime endDate { get; set; }
        public int customerID { get; set; }
    }
}

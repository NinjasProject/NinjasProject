using APIFlixNinjas.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace APIFlixNinjas.Model
{
   public class Subscription
    {
        public int ID { get; set; }

        public subtype subscriptionType { get; set; }

        public DateTime startDate { get; set; }

        public DateTime endDate { get; set; }

        public int customerID { get; set; }
        

    }
}

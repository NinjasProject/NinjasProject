using System;

namespace APIFlixNinjas.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public class CustomerSubscription
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
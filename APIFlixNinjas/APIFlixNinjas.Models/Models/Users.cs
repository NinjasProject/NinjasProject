﻿using System;
using System.ComponentModel.DataAnnotations;

namespace APIFlixNinjas.Model
{
  public  class Users
  {
        public int ID { get; set; }

       
        public string FirstName { get; set; }
       
        public string LastName { get; set; }
        
        public int Age { get; set; }
      
        public string Username { get; set; }
        
        public string Email { get; set; }
        
        public string MobileNo { get; set; }
       
        public string Gender { get; set; }
       
        public string Password { get; set; }
      
        public string ConfirmPassword { get; set; }

       
    }
}

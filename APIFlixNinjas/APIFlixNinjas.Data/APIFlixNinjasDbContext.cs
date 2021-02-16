using APIFlixNinjas.Data.Interface;
using APIFlixNinjas.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace APIFlixNinjas.Data
{
    public class APIFlixNinjasDbContext : DbContext, IAPIFlixNinjasDbContext
    {
        public DbSet<Customer> Customer { get; set; }
        public DbSet<CustomerSubscription> CustomerSubscription { get; set; }

        public APIFlixNinjasDbContext()
        {

        }
        public APIFlixNinjasDbContext(DbContextOptions<APIFlixNinjasDbContext> options) : base(options)
        {

        }

    }
}
    

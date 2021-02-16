using APIFlixNinjas.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace APIFlixNinjas.Data.Interface
{
    interface IAPIFlixNinjasDbContext : IDisposable, IDbContext
    {
        DbSet<Customer> Customer { get; set; }
        DbSet<CustomerSubscription> CustomerSubscription { get; set; }
    }
}

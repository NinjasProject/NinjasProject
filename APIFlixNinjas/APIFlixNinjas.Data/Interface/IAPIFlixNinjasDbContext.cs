using APIFlixNinjas.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace APIFlixNinjas.Data.Interface
{
    public interface IAPIFlixNinjasDbContext : IDisposable, IDbContext
    {
        DbSet<Customer> Customer { get; set; }
        DbSet<Users> Users { get; set; }
       DbSet<Subscription> Subscription { get; set; }
    }
}


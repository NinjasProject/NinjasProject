using APIFlixNinjas.Data.Interface;
using APIFlixNinjas.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace APIFlixNinjas.Data
{
    public class APIFlixNinjasDbContext : DbContext, IAPIFlixNinjasDbContext
    {
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Users> Users { get; set; }

        public DbSet<Subscription> Subscription { get; set; }
        public APIFlixNinjasDbContext()
        {

        }
        public APIFlixNinjasDbContext(DbContextOptions<APIFlixNinjasDbContext> options) : base(options)
        {

        }

    }
}
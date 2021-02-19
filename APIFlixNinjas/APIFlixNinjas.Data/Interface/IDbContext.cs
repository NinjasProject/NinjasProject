using System;
using APIFlixNinjas.Model;
using System.Collections.Generic;
using System.Text;

namespace APIFlixNinjas.Data.Interface
{
    public interface IDbContext
    {
        int SaveChanges();
    }
}

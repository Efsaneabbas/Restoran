using Microsoft.EntityFrameworkCore;
using RestoranCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranData.DAL
{
    public  class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }   

        public DbSet<Cheif> cheifs { get; set; }
    }

    
}

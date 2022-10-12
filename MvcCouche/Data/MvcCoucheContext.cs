using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcCouche.Models;

namespace MvcCouche.Data
{
    public class MvcCoucheContext : DbContext
    {
        public MvcCoucheContext(DbContextOptions<MvcCoucheContext> options)
           : base(options)
        {
        }

        public DbSet<Couche> Couche { get; set; }
    }
}

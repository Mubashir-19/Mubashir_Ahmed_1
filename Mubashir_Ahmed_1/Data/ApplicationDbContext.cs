using Microsoft.EntityFrameworkCore;
using Mubashir_Ahmed_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mubashir_Ahmed_1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
                
        }

        public DbSet<Category> Category { get; set; }

        public DbSet<DetailsModel> DetailDbSet { get; set; }
    }
}

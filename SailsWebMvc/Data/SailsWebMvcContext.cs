using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SailsWebMvc.Models;

namespace SailsWebMvc.Data
{
    public class SailsWebMvcContext : DbContext
    {
        public SailsWebMvcContext (DbContextOptions<SailsWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<SailsWebMvc.Models.Department> Department { get; set; } = default!;
    }
}

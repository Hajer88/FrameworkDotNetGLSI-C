using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FrameworkDotNetGLSI_C.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            :base("name=DefaultConnection")
        {

        }
        public DbSet<Movie> movies { get; set; }
        public DbSet<Genre> genres { get; set; }
    }
}
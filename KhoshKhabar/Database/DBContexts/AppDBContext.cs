using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.Models;
using Microsoft.EntityFrameworkCore;

namespace Database.DBContexts
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }
        public virtual DbSet<Category> categories { get; set; }
        public virtual DbSet<Content> news { get; set; }
        public virtual DbSet<User> users { get; set; }
    }
}

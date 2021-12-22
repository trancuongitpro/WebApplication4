using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication4.Models;

namespace WebApplication4.Data
{
    public class MvcBooksContext : DbContext
    {
        public MvcBooksContext(DbContextOptions<MvcBooksContext> options)
                : base(options)
        {
        }

        public DbSet<Book> Book { get; set; }
    }
}

using ConsoleApp7.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.DAL
{
    internal class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-FHK353D;Database=Bb102Library;Trusted_Connection=True;MultipleActiveResultSets=true;");
        }
        public DbSet<Book> Books { get; set; }
    }
}

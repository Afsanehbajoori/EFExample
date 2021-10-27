using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFExample.Data_Model
{
    public class Context: DbContext
    {
        public DbSet<Student> Student { get; set; }
        public DbSet<Class> Class { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=TEC-A-PC7P; Database=EFExample; Trusted_Connection=true");
        }
    }
}

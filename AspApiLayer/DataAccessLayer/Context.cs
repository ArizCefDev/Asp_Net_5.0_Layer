using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace AspApiLayer.DataAccessLayer
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-TDMNHDM; database=ApiLayerSql; integrated security=true;");
        }

        public DbSet<Employee> Employees { get; set; }
    }
}

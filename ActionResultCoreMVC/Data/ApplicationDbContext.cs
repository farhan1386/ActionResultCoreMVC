using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ActionResultCoreMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace ActionResultCoreMVC.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options)
            :base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}

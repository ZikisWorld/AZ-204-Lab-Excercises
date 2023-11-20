using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AzureAppWithCRUD.Models;

namespace AzureAppWithCRUD.Data
{
    public class AzureAppWithCRUDContext : DbContext
    {
        public AzureAppWithCRUDContext (DbContextOptions<AzureAppWithCRUDContext> options)
            : base(options)
        {
        }

        public DbSet<AzureAppWithCRUD.Models.Employee> Employees { get; set; } = default!;
        public DbSet<AzureAppWithCRUD.Models.Department> Departments { get; set; } = default!;
    }
}

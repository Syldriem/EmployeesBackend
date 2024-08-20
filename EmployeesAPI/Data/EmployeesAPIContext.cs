using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmployeesAPI.Models;

namespace EmployeesAPI.Data
{
    public class EmployeesAPIContext : DbContext
    {
        public EmployeesAPIContext (DbContextOptions<EmployeesAPIContext> options)
            : base(options)
        {
        }

        public DbSet<TodoItem> TodoItem { get; set; } = default!;
    }
}

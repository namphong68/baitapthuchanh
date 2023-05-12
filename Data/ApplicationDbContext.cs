using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using baithuchanhexcels.Models;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<baithuchanhexcels.Models.Faculty> Faculty { get; set; } = default!;

        public DbSet<baithuchanhexcels.Models.Employee> Employee { get; set; } = default!;
        public DbSet<baithuchanhexcels.Models.Student> Student { get; set; } = default!;
    }

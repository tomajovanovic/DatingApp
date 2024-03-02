using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DateApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace DateApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUser> Users { get; set; } // tabela koja se zove users sa kolonama id i username
    }
}
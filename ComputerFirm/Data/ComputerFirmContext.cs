using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Computerfirm.Models;

namespace ComputerFirm.Data
{
    public class ComputerFirmContext : DbContext
    {
        public ComputerFirmContext (DbContextOptions<ComputerFirmContext> options)
            : base(options)
        {
        }

        public DbSet<Computerfirm.Models.Service> Service { get; set; }

        public DbSet<Computerfirm.Models.Order> Order { get; set; }

        public DbSet<Computerfirm.Models.Component> Component { get; set; }

        public DbSet<Computerfirm.Models.Position> Position { get; set; }

        public DbSet<Computerfirm.Models.Customer> Customer { get; set; }

        public DbSet<Computerfirm.Models.Staff> Staff { get; set; }

        public DbSet<Computerfirm.Models.TypesofСomponent> TypesofСomponent { get; set; }
        public IEnumerable<object> Orders { get; internal set; }
        
    }
}

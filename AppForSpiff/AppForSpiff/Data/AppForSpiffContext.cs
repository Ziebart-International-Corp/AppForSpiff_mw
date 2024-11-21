using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AppForSpiff.Models;

namespace AppForSpiff.Data
{
    public class AppForSpiffContext : DbContext
    {
        public AppForSpiffContext (DbContextOptions<AppForSpiffContext> options)
            : base(options)
        {
        }

        public DbSet<AppForSpiff.Models.MainDataDealer> MainDataDealer { get; set; } = default!;
        public DbSet<AppForSpiff.Models.MainDataEmployee> MainDataEmployee { get; set; } = default!;
        public DbSet<AppForSpiff.Models.MainDataPackage> MainDataPackage { get; set; } = default!;
        public DbSet<AppForSpiff.Models.MainDataService> MainDataService { get; set; } = default!;
        public DbSet<AppForSpiff.Models.MainData> MainData { get; set; } = default!;
        public DbSet<ChemicalsData> DisplayEmpRecords { get; set; } = default!;
    }
}

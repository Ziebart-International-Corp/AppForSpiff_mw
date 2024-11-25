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
        public DbSet<ChemAccData> DisplayChemAccRecords { get; set; } = default!;
        public DbSet<ChemData> DisplayChemRecords { get; set; } = default!;
        public DbSet<AccData> DisplayAccRecords { get; set; } = default!;
        public DbSet<PackagesData> DisplayPackagesRecords { get; set; } = default!;
        public DbSet<ServiceCodesData> DisplayServiceCodesRecords { get; set; } = default!;
    }
}

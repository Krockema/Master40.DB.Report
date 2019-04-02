using Master40.DB.Report.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace Master40.DB.Report
{
    public class ReportContext : DbContext
    {
        public ReportContext(DbContextOptions<ReportContext> options) : base(options) {

        }

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     optionsBuilder.UseSqlServer(@"Server=.\;Database=EFCoreDemo;Trusted_Connection=True;MultipleActiveResultSets=true");
        // }

        public DbSet<Kpi> Kpis { get; set; }
        public DbSet<SimulationOrder> SimulationOrders { get; set; }
        public DbSet<SimulationConfiguration> SimulationConfigurations { get; set; }
        public DbSet<StockExchange> StockExchanges { get; set; }
    }
}

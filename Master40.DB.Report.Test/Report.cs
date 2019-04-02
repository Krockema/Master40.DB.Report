using Microsoft.EntityFrameworkCore;
using System;
using Xunit;

namespace Master40.DB.Report.Test
{
    public class Report
    {
        ReportContext _ctx = new ReportContext(new DbContextOptionsBuilder<ReportContext>()
            .UseSqlServer("Server=(localdb)\\mssqllocaldb;" +
                          "Database=Master40Report;" +
                          "Trusted_Connection=True;" +
                          "MultipleActiveResultSets=true")
             .Options);
        [Fact]
        public void CreateDatabase()
        {
            Assert.True(_ctx.Database.EnsureCreated());
        }
    }
}

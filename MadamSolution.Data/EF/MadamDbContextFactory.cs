using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MadamSolution.Data.EF
{
    public class MadamDbContextFactory : IDesignTimeDbContextFactory<MadamDbContext>
    {
        public MadamDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("MadamSolutionDb");

            var optionsBuilder = new DbContextOptionsBuilder<MadamDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new MadamDbContext(optionsBuilder.Options);
        }
    }
}

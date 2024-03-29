﻿using ByYsmn.EntityFramework.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ByYsmn.Entityframework
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {

        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var dbContext = new ApplicationDbContext(
                new DbContextOptionsBuilder<ApplicationDbContext>()

                .UseSqlite(

                    new ConfigurationBuilder()

                    .AddJsonFile(Path.Combine(Directory.GetCurrentDirectory(), $"appsettings.json"))
                    .Build()
                    .GetConnectionString("SQLiteConnection")

                    ).Options);

            // dbContext.Database.Migrate();

            return dbContext;
        }
    }

}

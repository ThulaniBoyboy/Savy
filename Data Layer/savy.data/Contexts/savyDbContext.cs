using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using Microsoft.EntityFrameworkCore;
using savy.domain.Entities.Catalog;

namespace savy.data.Contexts
{
    public class savyDbContext : DbContext
    {
        public savyDbContext(DbContextOptions<savyDbContext> builder) : base(builder) {}

        public Dbset<Product> products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            //assign connection string  override void
            var conn = @"connection string";
            builder.UseSqlServer(conn);
        }
    }
}

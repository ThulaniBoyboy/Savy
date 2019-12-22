using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFramework.Design;
using savy.data.Contexts;

namespace savy.data.ContextFactory
{
    public class DbContextFactory //: IDesignTimeDbCOntextFactory(savyDbContext)
    {
        public savyDbContecxt CreateDbContext(string[] args)
        {
            var builder =  new DbContextOptionsBuilder<savyDbContext>();
            var conn = @"";
            builder.UseSqlServer(conn,
             builderOption =>
                 builderOption.MigrationAssembly(typeof(savyDbContext).GetTypeInfo().Assembly.GetName().Name));    
            return new savyDbContext(builder.Options);
        }
    }
}